using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using SharpDX;
using SharpDX.DirectInput;
using TrainCrew;

namespace ZDG_TC
{
    public partial class MainForm : Form
    {
        // コントローラーが押されている場合と押されていない場合の色の値
        private Color CONTROLLER_ON_COLOR { get; } = Color.Red;
        private Color CONTROLLER_OFF_COLOR { get; } = SystemColors.ControlText;

        // バージョンフォームクラス
        private VersionForm versionForm;
        // DirectInput用
        private DirectInput di;
        // ジョイスティック
        private Joystick joystick;
        // 前回押された十字パッド
        private int previousPOVValue = -1;
        // レバーサ位置 (1: 前進, 0: 中立, -1: 後進)
        private int reverserDir = 1;
        
        // コントローラーコンボボックス用のリストアイテムクラス
        public class ControllerItem
        {
            public string Name { set; get; }
            public Guid Guid { set; get; }

            public ControllerItem(string n, Guid g)
            {
                Name = n;
                Guid = g;
            }
        }

        public class SWEnumItem
        {
            public string Name { set; get; }
            public InputAction? Action { set; get; }

            public SWEnumItem(string n, InputAction? a)
            {
                Name = n;
                Action = a;
            }

            public static List<SWEnumItem> GetList()
            {
                return new List<SWEnumItem>() {
                    new SWEnumItem("(未設定)", null),
                    new SWEnumItem("力行側へ1段", InputAction.NotchUp),
                    new SWEnumItem("制動側へ1段", InputAction.NotchDw),
                    new SWEnumItem("ノッチをNにする", InputAction.NotchN),
                    new SWEnumItem("ノッチをN側へ1段", InputAction.NotchToN),
                    new SWEnumItem("EBノッチ", InputAction.NotchEB),
                    new SWEnumItem("B1ノッチ", InputAction.NotchB1),
                    new SWEnumItem("勾配起動", InputAction.GradientStart),
                    new SWEnumItem("ブザー", InputAction.Buzzer),
                    new SWEnumItem("空笛", InputAction.HornAir),
                    new SWEnumItem("電笛", InputAction.HornEle),
                    new SWEnumItem("外部視点との切り替え", InputAction.ViewChange),
                    new SWEnumItem("ポーズメニュー", InputAction.PauseMenu),
                    new SWEnumItem("スタフの表示・非表示", InputAction.ViewDiagram),
                    new SWEnumItem("UIの表示・非表示", InputAction.ViewUserInterface),
                    new SWEnumItem("視点の回転をリセット", InputAction.ViewHome),
                    new SWEnumItem("EBリセット", InputAction.EBReset),
                    new SWEnumItem("右側へ視点移動", InputAction.DriverViewR),
                    new SWEnumItem("左側へ視点移動", InputAction.DriverViewL),
                    new SWEnumItem("運転席へ視点移動", InputAction.DriverViewC),
                };
            }
        }

        // コンストラクタ
        public MainForm()
        {
            InitializeComponent();

            InitializeVersionForm();

            // DirectInputの初期化
            di = new DirectInput();

            // コントローラーの割当のコンボボックスの設定 ↓
            // Aボタン
            ButtonACombo.DataSource = SWEnumItem.GetList();
            ButtonACombo.SelectedValue = InputAction.HornEle; // 電笛

            // Bボタン
            ButtonBCombo.DataSource = SWEnumItem.GetList();
            ButtonBCombo.SelectedValue = InputAction.Buzzer; // ブザー

            // Xボタン
            ButtonXCombo.DataSource = SWEnumItem.GetList();
            ButtonXCombo.SelectedValue = InputAction.HornAir; // 空笛

            // Yボタン
            ButtonYCombo.DataSource = SWEnumItem.GetList();
            ButtonYCombo.SelectedValue = InputAction.EBReset; // EBリセット

            // Lボタン
            ButtonLCombo.DataSource = SWEnumItem.GetList();

            // Rボタン
            ButtonRCombo.DataSource = SWEnumItem.GetList();

            // +ボタン
            ButtonPlusCombo.DataSource = SWEnumItem.GetList();
            ButtonPlusCombo.SelectedValue = InputAction.PauseMenu;

            // -ボタン
            ButtonMinusCombo.DataSource = SWEnumItem.GetList();

            // ZRボタン
            ButtonZRCombo.DataSource = SWEnumItem.GetList();
            // コントローラーの割当のコンボボックスの設定 ↑
        }

        // VersionFormの初期化
        private void InitializeVersionForm()
        {
            versionForm = new VersionForm();
        }

        private void DetectController()
        {
            List <ControllerItem> items = new List<ControllerItem>();
            foreach (DeviceInstance device in di.GetDevices(DeviceType.Gamepad, DeviceEnumerationFlags.AllDevices))
            {
                items.Add(new ControllerItem(device.InstanceName, device.InstanceGuid));
            }

            GamepadComboBox.DataSource = items;
            GamepadComboBox.DisplayMember = "Name";
            GamepadComboBox.ValueMember = "Guid";

            if (items.Count > 0)
            {
                GamepadComboBox.SelectedIndex = 0;
                SetupJoystick();
            }
        }

        private void ChangeStatusMessage()
        {
            if (GamepadComboBox.SelectedIndex != -1)
            {
                StatusBarMessage.Text = "準備完了";
            }
            else
            {
                StatusBarMessage.Text = "ゲームパッドが検出されませんでした。";
            }
        }

        // メニューの「終了」ボタンの押下イベント
        private void MenuFileQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            StatusBarMessage.Text = "TrainCrewInputの初期化中";
            // TrainCrew入力の初期化
            TrainCrewInput.Init();

            // タイマー起動
            StatusBarMessage.Text = "タイマー起動";
            MainTimer.Enabled = true;

            DetectController();

            // Ready
            ChangeStatusMessage();
        }

        private void MainForm_Closing(object sender, FormClosingEventArgs e)
        {
            // タイマー停止
            StatusBarMessage.Text = "タイマー停止中";
            MainTimer.Enabled = false;

            // DirectInput停止
            StatusBarMessage.Text = "DirectInput停止中";
            di.Dispose();

            // TrainCrew入力の廃棄処理
            StatusBarMessage.Text = "TrainCrewInputを停止中";
            TrainCrewInput.Dispose();
        }

        // タイマー処理
        private void MainTimer_Tick(object sender, EventArgs e)
        {
            // ジョイスティックが認識されていない場合は処理しない
            if (joystick == null) return;

            try
            {
                // ジョイスティックを認識
                joystick.Acquire();
                joystick.Poll();
            }
            catch
            {
                // ジョイスティックの接続が切れた場合、破棄する
                joystick?.Dispose();
                joystick = null;
                DetectController();
                ChangeStatusMessage();
                return;
            }

            // ジョイスティックの状態取得、できなければ無視
            var jState = joystick.GetCurrentState();
            if (jState == null) return;

            // ノッチ制御
            switch (jState.Y)
            {
                case int n when n <= -900 && jState.Buttons[6]: // EB
                    MasconLevel.Text = "EB";
                    TrainCrewInput.SetNotch(-8);
                    break;
                case int n when n <= -766: // B6
                    MasconLevel.Text = "B6";
                    TrainCrewInput.SetNotch(-7);
                    break;
                case int n when n <= -675: // B5
                    MasconLevel.Text = "B5";
                    TrainCrewInput.SetNotch(-6);
                    break;
                case int n when n <= -577: // B4
                    MasconLevel.Text = "B4";
                    TrainCrewInput.SetNotch(-5);
                    break;
                case int n when n <= -478: // B3
                    MasconLevel.Text = "B3";
                    TrainCrewInput.SetNotch(-4);
                    break;
                case int n when n <= -387: // B2
                    MasconLevel.Text = "B2";
                    TrainCrewInput.SetNotch(-3);
                    break;
                case int n when n <= -288: // B1
                    MasconLevel.Text = "B1";
                    TrainCrewInput.SetNotch(-2);
                    break;
                case int n when n <= -190: // 抑速
                    MasconLevel.Text = "抑速";
                    TrainCrewInput.SetNotch(-1);
                    break;
                case int n when n > -190 && n < 215: // N
                    MasconLevel.Text = "N";
                    TrainCrewInput.SetNotch(0);
                    break;
                case int n when n >= 215 && n < 386: // P1
                    MasconLevel.Text = "P1";
                    TrainCrewInput.SetNotch(1);
                    break;
                case int n when n >= 386 && n < 550: // P2
                    MasconLevel.Text = "P2";
                    TrainCrewInput.SetNotch(2);
                    break;
                case int n when n >= 550 && n < 722: // P3
                    MasconLevel.Text = "P3";
                    TrainCrewInput.SetNotch(3);
                    break;
                case int n when n >= 722 && n < 900: // P4
                    MasconLevel.Text = "P4";
                    TrainCrewInput.SetNotch(4);
                    break;
                case int n when n >= 900: // P5
                    MasconLevel.Text = "P5";
                    TrainCrewInput.SetNotch(5);
                    break;
                default: // 不明
                    MasconLevel.Text = "?";
                    break;
            }

            // ボタン処理
            ButtonAction(ButtonALabel, ButtonACombo, jState.Buttons[2]); // Aボタン
            ButtonAction(ButtonBLabel, ButtonBCombo, jState.Buttons[1]); // Bボタン
            ButtonAction(ButtonXLabel, ButtonXCombo, jState.Buttons[3]); // Xボタン
            ButtonAction(ButtonYLabel, ButtonYCombo, jState.Buttons[0]); // Yボタン
            ButtonAction(ButtonLLabel, ButtonLCombo, jState.Buttons[4]); // Lボタン
            ButtonAction(ButtonRLabel, ButtonRCombo, jState.Buttons[5]); // Rボタン
            ButtonAction(ButtonPlusLabel, ButtonPlusCombo, jState.Buttons[9]); // +ボタン
            ButtonAction(ButtonMinusLabel, ButtonMinusCombo, jState.Buttons[8]); // -ボタン
            ButtonAction(ButtonZRLabel, ButtonZRCombo, jState.Buttons[7]); // ZRボタン

            // ZLボタンが押されているかの反応処理
            if (jState.Buttons[6])
            {
                ButtonZLLabel.ForeColor = CONTROLLER_ON_COLOR;
            }
            else
            {
                ButtonZLLabel.ForeColor = CONTROLLER_OFF_COLOR;
            }

            // TrainCrewからの列車情報を取得
            TrainState ts = TrainCrewInput.GetTrainState();
            if (ts.diaName != "")
            {
                StatusBarMessage.Text = string.Format("{0}列車 {1} {2}行き - {3}km/h", ts.diaName, ts.Class, ts.BoundFor, ts.Speed);
            }
            else
            {
                StatusBarMessage.Text = "準備完了";
            }

            // 十字パッド
            if (jState.PointOfViewControllers[0] != -1 && previousPOVValue != jState.PointOfViewControllers[0])
            {
                previousPOVValue = jState.PointOfViewControllers[0];
                switch (jState.PointOfViewControllers[0])
                {
                    case 0: // 上
                        if (reverserDir >= 1) break;
                        reverserDir++;
                        break;
                    case 18000: // 下
                        if (reverserDir <= -1) break;
                        reverserDir--;
                        break;
                }

                switch (reverserDir)
                {
                    case 1: // 前進
                        ReverserValue.Text = "前進";
                        break;
                    case 0: // 中立
                        ReverserValue.Text = "中立";
                        break;
                    case -1: // 後進
                        ReverserValue.Text = "後進";
                        break;
                    default: // 不明
                        ReverserValue.Text = "?";
                        break;
                }
            }
            if (jState.PointOfViewControllers[0] == -1 && previousPOVValue != -1)
            {
                // 十字パッドのボタンが離されたときリセット
                previousPOVValue = -1;
            }

            TrainCrewInput.SetReverser(reverserDir);
        }

        private void ButtonAction(Label label, ComboBox cb,  bool on)
        {
            // ボタンが押されていれば色を変える、押されていなければ元の色にする
            if (on)
            {
                label.ForeColor = CONTROLLER_ON_COLOR;
            }
            else
            {
                label.ForeColor = CONTROLLER_OFF_COLOR;
            }

            // コンボボックスの選択しているアイテムを取得
            SWEnumItem swei = (SWEnumItem) cb.SelectedItem;
            // 「(未設定)」でなければそのアクションを実行
            if (swei.Action != null)
            {
                TrainCrewInput.SetButton((InputAction)swei.Action, on);
            }
        }

        // YuzuliaサイトのURLを開く
        private void MenuHelpHomePageYuzulia_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://yuzulia.com/");
        }

        // YuzuRyo61.meのURLを開く
        private void MenuHelpHomePageYuzuRyo61_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://yuzuryo61.me/");
        }

        private void MenuHelpVersion_Click(object sender, EventArgs e)
        {
            // バージョン情報フォームを表示
            versionForm.ShowDialog();
        }

        // メニューの「再検出」ボタン押下
        private void MenuFileRedetect_Click(object sender, EventArgs e)
        {
            DetectController();
            ChangeStatusMessage();
        }

        private ControllerItem GetController()
        {
            if (GamepadComboBox.SelectedItem == null) return null;
            // 現在選択されているコントローラー
            return (ControllerItem)GamepadComboBox.SelectedItem;
        }

        private void SetupJoystick()
        {
            joystick?.Dispose();
            ControllerItem ci = GetController();
            if (ci == null)
            {
                joystick = null;
                return;
            }
            joystick = new Joystick(di, ci.Guid);

            joystick.Properties.BufferSize = 128;

            foreach (DeviceObjectInstance deviceObject in joystick.GetObjects())
            {
                switch (deviceObject.ObjectId.Flags)
                {
                    // 絶対軸 or 相対軸
                    case DeviceObjectTypeFlags.Axis:
                    case DeviceObjectTypeFlags.AbsoluteAxis:
                    case DeviceObjectTypeFlags.RelativeAxis:
                        var ir = joystick.GetObjectPropertiesById(deviceObject.ObjectId);
                        if (ir != null)
                        {
                            try
                            {
                                ir.Range = new InputRange(-900, 900);
                            }
                            catch (Exception) { }
                        }
                        break;
                }
            }

            // TODO: 参照→ https://lipoyang.hatenablog.com/entry/2020/02/14/085800
        }

        // コントローラーコンボボックス変更イベント
        private void GamepadComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetupJoystick();
        }
    }
}
