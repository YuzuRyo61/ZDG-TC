using System;
using System.Windows.Forms;

using TrainCrew;

namespace ZDG_TC
{
    public partial class MainForm : Form
    {
        private VersionForm versionForm;

        public MainForm()
        {
            InitializeComponent();

            InitializeVersionForm();
        }

        // VersionFormの初期化
        private void InitializeVersionForm()
        {
            versionForm = new VersionForm();
        }

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

            // Ready
            StatusBarMessage.Text = "準備完了";
        }

        private void MainForm_Closing(object sender, FormClosingEventArgs e)
        {
            // タイマー停止
            StatusBarMessage.Text = "タイマー停止中";
            MainTimer.Enabled = false;

            // TrainCrew入力の廃棄処理
            StatusBarMessage.Text = "TrainCrewInputを停止中";
            //TrainCrewInput.Dispose();
        }

        private void MainTimer_Tick(object sender, EventArgs e)
        {
            // TODO: コントローラーの処理
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
    }
}
