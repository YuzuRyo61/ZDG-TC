namespace ZDG_TC
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelpHomePage = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelpHomePageYuzulia = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelpHomePageYuzuRyo61 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelpVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.StatusBarMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainTabControl = new System.Windows.Forms.TabControl();
            this.MainTabSettings = new System.Windows.Forms.TabPage();
            this.MainTabTest = new System.Windows.Forms.TabPage();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.MainMenu.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.MainTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuHelp});
            resources.ApplyResources(this.MainMenu, "MainMenu");
            this.MainMenu.Name = "MainMenu";
            // 
            // MenuFile
            // 
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFileQuit});
            this.MenuFile.Name = "MenuFile";
            resources.ApplyResources(this.MenuFile, "MenuFile");
            // 
            // MenuFileQuit
            // 
            this.MenuFileQuit.Name = "MenuFileQuit";
            resources.ApplyResources(this.MenuFileQuit, "MenuFileQuit");
            this.MenuFileQuit.Click += new System.EventHandler(this.MenuFileQuit_Click);
            // 
            // MenuHelp
            // 
            this.MenuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuHelpHomePage,
            this.MenuHelpVersion});
            this.MenuHelp.Name = "MenuHelp";
            resources.ApplyResources(this.MenuHelp, "MenuHelp");
            // 
            // MenuHelpHomePage
            // 
            this.MenuHelpHomePage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuHelpHomePageYuzulia,
            this.MenuHelpHomePageYuzuRyo61});
            this.MenuHelpHomePage.Name = "MenuHelpHomePage";
            resources.ApplyResources(this.MenuHelpHomePage, "MenuHelpHomePage");
            // 
            // MenuHelpHomePageYuzulia
            // 
            this.MenuHelpHomePageYuzulia.Name = "MenuHelpHomePageYuzulia";
            resources.ApplyResources(this.MenuHelpHomePageYuzulia, "MenuHelpHomePageYuzulia");
            this.MenuHelpHomePageYuzulia.Click += new System.EventHandler(this.MenuHelpHomePageYuzulia_Click);
            // 
            // MenuHelpHomePageYuzuRyo61
            // 
            this.MenuHelpHomePageYuzuRyo61.Name = "MenuHelpHomePageYuzuRyo61";
            resources.ApplyResources(this.MenuHelpHomePageYuzuRyo61, "MenuHelpHomePageYuzuRyo61");
            this.MenuHelpHomePageYuzuRyo61.Click += new System.EventHandler(this.MenuHelpHomePageYuzuRyo61_Click);
            // 
            // MenuHelpVersion
            // 
            this.MenuHelpVersion.Name = "MenuHelpVersion";
            resources.ApplyResources(this.MenuHelpVersion, "MenuHelpVersion");
            this.MenuHelpVersion.Click += new System.EventHandler(this.MenuHelpVersion_Click);
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusBarMessage});
            resources.ApplyResources(this.StatusBar, "StatusBar");
            this.StatusBar.Name = "StatusBar";
            // 
            // StatusBarMessage
            // 
            this.StatusBarMessage.Name = "StatusBarMessage";
            resources.ApplyResources(this.StatusBarMessage, "StatusBarMessage");
            // 
            // MainTabControl
            // 
            resources.ApplyResources(this.MainTabControl, "MainTabControl");
            this.MainTabControl.Controls.Add(this.MainTabSettings);
            this.MainTabControl.Controls.Add(this.MainTabTest);
            this.MainTabControl.Name = "MainTabControl";
            this.MainTabControl.SelectedIndex = 0;
            // 
            // MainTabSettings
            // 
            this.MainTabSettings.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.MainTabSettings, "MainTabSettings");
            this.MainTabSettings.Name = "MainTabSettings";
            // 
            // MainTabTest
            // 
            resources.ApplyResources(this.MainTabTest, "MainTabTest");
            this.MainTabTest.Name = "MainTabTest";
            this.MainTabTest.UseVisualStyleBackColor = true;
            // 
            // MainTimer
            // 
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.MainTabControl);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.MainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.MainMenu;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_Closing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.MainTabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuFile;
        private System.Windows.Forms.ToolStripMenuItem MenuFileQuit;
        private System.Windows.Forms.ToolStripMenuItem MenuHelp;
        private System.Windows.Forms.StatusStrip StatusBar;
        private System.Windows.Forms.ToolStripStatusLabel StatusBarMessage;
        private System.Windows.Forms.ToolStripMenuItem MenuHelpHomePage;
        private System.Windows.Forms.ToolStripMenuItem MenuHelpHomePageYuzulia;
        private System.Windows.Forms.ToolStripMenuItem MenuHelpHomePageYuzuRyo61;
        private System.Windows.Forms.ToolStripMenuItem MenuHelpVersion;
        private System.Windows.Forms.TabControl MainTabControl;
        private System.Windows.Forms.TabPage MainTabSettings;
        private System.Windows.Forms.TabPage MainTabTest;
        private System.Windows.Forms.Timer MainTimer;
    }
}

