using System;
using System.Collections.Generic;
using System.Windows.Forms;

using SharpDX;
using SharpDX.DirectInput;
using TrainCrew;

namespace ZDG_TC
{
    public partial class MainForm : Form
    {
        private VersionForm versionForm;
        private DirectInput di;
        private Joystick joystick;
        
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

        public MainForm()
        {
            InitializeComponent();

            InitializeVersionForm();

            // DirectInputの初期化
            di = new DirectInput();
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
            // TODO: コントローラーの処理
            if (joystick == null) return;

            try
            {
                joystick.Acquire();
                joystick.Poll();
            }
            catch
            {
                joystick?.Dispose();
                joystick = null;
                DetectController();
                ChangeStatusMessage();
                return;
            }

            var jState = joystick.GetCurrentState();
            if (jState == null) return;
            // マスコン状態
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

            TrainState ts = TrainCrewInput.GetTrainState();
            if (ts.diaName != "")
            {
                StatusBarMessage.Text = string.Format("運転中: {0}列車 {1} {2}行き - {3}km/h", ts.diaName, ts.Class, ts.BoundFor, ts.Speed);
            }
            else
            {
                StatusBarMessage.Text = "準備完了";
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
