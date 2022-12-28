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
            this.MenuFileRedetect = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFileSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuFileQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelpHomePage = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelpHomePageYuzulia = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelpHomePageYuzuRyo61 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHelpVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.StatusBarMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.DeviceListLabel = new System.Windows.Forms.Label();
            this.GamepadComboBox = new System.Windows.Forms.ComboBox();
            this.MainMenu.SuspendLayout();
            this.StatusBar.SuspendLayout();
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
            this.MenuFileRedetect,
            this.MenuFileSeparator1,
            this.MenuFileQuit});
            this.MenuFile.Name = "MenuFile";
            resources.ApplyResources(this.MenuFile, "MenuFile");
            // 
            // MenuFileRedetect
            // 
            this.MenuFileRedetect.Name = "MenuFileRedetect";
            resources.ApplyResources(this.MenuFileRedetect, "MenuFileRedetect");
            this.MenuFileRedetect.Click += new System.EventHandler(this.MenuFileRedetect_Click);
            // 
            // MenuFileSeparator1
            // 
            this.MenuFileSeparator1.Name = "MenuFileSeparator1";
            resources.ApplyResources(this.MenuFileSeparator1, "MenuFileSeparator1");
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
            // MainTimer
            // 
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // DeviceListLabel
            // 
            resources.ApplyResources(this.DeviceListLabel, "DeviceListLabel");
            this.DeviceListLabel.Name = "DeviceListLabel";
            // 
            // GamepadComboBox
            // 
            resources.ApplyResources(this.GamepadComboBox, "GamepadComboBox");
            this.GamepadComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.GamepadComboBox.FormattingEnabled = true;
            this.GamepadComboBox.Name = "GamepadComboBox";
            this.GamepadComboBox.SelectedIndexChanged += new System.EventHandler(this.GamepadComboBox_SelectedIndexChanged);
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GamepadComboBox);
            this.Controls.Add(this.DeviceListLabel);
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
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.ToolStripMenuItem MenuFileRedetect;
        private System.Windows.Forms.ToolStripSeparator MenuFileSeparator1;
        private System.Windows.Forms.Label DeviceListLabel;
        private System.Windows.Forms.ComboBox GamepadComboBox;
    }
}

