﻿using System;
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
            //TrainCrewInput.Init();

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
            //TrainCrewInput.Dispose();
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            // TODO: コントローラーの処理
            if (joystick == null) return;
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
            if (ci == null) return;
            joystick = new Joystick(di, ci.Guid);

            // TODO: 参照→ https://lipoyang.hatenablog.com/entry/2020/02/14/085800
        }

        // コントローラーコンボボックス変更イベント
        private void GamepadComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetupJoystick();
        }
    }
}