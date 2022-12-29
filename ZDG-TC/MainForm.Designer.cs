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
            this.MasconLevel = new System.Windows.Forms.Label();
            this.MasconLevelLabel = new System.Windows.Forms.Label();
            this.ButtonACombo = new System.Windows.Forms.ComboBox();
            this.ButtonALabel = new System.Windows.Forms.Label();
            this.ButtonBLabel = new System.Windows.Forms.Label();
            this.ButtonBCombo = new System.Windows.Forms.ComboBox();
            this.ButtonXLabel = new System.Windows.Forms.Label();
            this.ButtonXCombo = new System.Windows.Forms.ComboBox();
            this.ButtonYLabel = new System.Windows.Forms.Label();
            this.ButtonYCombo = new System.Windows.Forms.ComboBox();
            this.ButtonPlusLabel = new System.Windows.Forms.Label();
            this.ButtonPlusCombo = new System.Windows.Forms.ComboBox();
            this.ButtonMinusLabel = new System.Windows.Forms.Label();
            this.ButtonMinusCombo = new System.Windows.Forms.ComboBox();
            this.ButtonLLabel = new System.Windows.Forms.Label();
            this.ButtonLCombo = new System.Windows.Forms.ComboBox();
            this.ButtonRLabel = new System.Windows.Forms.Label();
            this.ButtonRCombo = new System.Windows.Forms.ComboBox();
            this.ButtonZLLabel = new System.Windows.Forms.Label();
            this.ButtonZRLabel = new System.Windows.Forms.Label();
            this.ButtonZRCombo = new System.Windows.Forms.ComboBox();
            this.ButtonZLReservedLabel = new System.Windows.Forms.Label();
            this.ReverserLabel = new System.Windows.Forms.Label();
            this.ReverserValue = new System.Windows.Forms.Label();
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
            this.MainTimer.Interval = 40;
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
            // MasconLevel
            // 
            resources.ApplyResources(this.MasconLevel, "MasconLevel");
            this.MasconLevel.Name = "MasconLevel";
            // 
            // MasconLevelLabel
            // 
            resources.ApplyResources(this.MasconLevelLabel, "MasconLevelLabel");
            this.MasconLevelLabel.Name = "MasconLevelLabel";
            // 
            // ButtonACombo
            // 
            resources.ApplyResources(this.ButtonACombo, "ButtonACombo");
            this.ButtonACombo.DisplayMember = "Name";
            this.ButtonACombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ButtonACombo.FormattingEnabled = true;
            this.ButtonACombo.Name = "ButtonACombo";
            this.ButtonACombo.ValueMember = "Action";
            // 
            // ButtonALabel
            // 
            resources.ApplyResources(this.ButtonALabel, "ButtonALabel");
            this.ButtonALabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ButtonALabel.Name = "ButtonALabel";
            // 
            // ButtonBLabel
            // 
            resources.ApplyResources(this.ButtonBLabel, "ButtonBLabel");
            this.ButtonBLabel.Name = "ButtonBLabel";
            // 
            // ButtonBCombo
            // 
            resources.ApplyResources(this.ButtonBCombo, "ButtonBCombo");
            this.ButtonBCombo.DisplayMember = "Name";
            this.ButtonBCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ButtonBCombo.FormattingEnabled = true;
            this.ButtonBCombo.Name = "ButtonBCombo";
            this.ButtonBCombo.ValueMember = "Action";
            // 
            // ButtonXLabel
            // 
            resources.ApplyResources(this.ButtonXLabel, "ButtonXLabel");
            this.ButtonXLabel.Name = "ButtonXLabel";
            // 
            // ButtonXCombo
            // 
            resources.ApplyResources(this.ButtonXCombo, "ButtonXCombo");
            this.ButtonXCombo.DisplayMember = "Name";
            this.ButtonXCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ButtonXCombo.FormattingEnabled = true;
            this.ButtonXCombo.Name = "ButtonXCombo";
            this.ButtonXCombo.ValueMember = "Action";
            // 
            // ButtonYLabel
            // 
            resources.ApplyResources(this.ButtonYLabel, "ButtonYLabel");
            this.ButtonYLabel.Name = "ButtonYLabel";
            // 
            // ButtonYCombo
            // 
            resources.ApplyResources(this.ButtonYCombo, "ButtonYCombo");
            this.ButtonYCombo.DisplayMember = "Name";
            this.ButtonYCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ButtonYCombo.FormattingEnabled = true;
            this.ButtonYCombo.Name = "ButtonYCombo";
            this.ButtonYCombo.ValueMember = "Action";
            // 
            // ButtonPlusLabel
            // 
            resources.ApplyResources(this.ButtonPlusLabel, "ButtonPlusLabel");
            this.ButtonPlusLabel.Name = "ButtonPlusLabel";
            // 
            // ButtonPlusCombo
            // 
            resources.ApplyResources(this.ButtonPlusCombo, "ButtonPlusCombo");
            this.ButtonPlusCombo.DisplayMember = "Name";
            this.ButtonPlusCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ButtonPlusCombo.FormattingEnabled = true;
            this.ButtonPlusCombo.Name = "ButtonPlusCombo";
            this.ButtonPlusCombo.ValueMember = "Action";
            // 
            // ButtonMinusLabel
            // 
            resources.ApplyResources(this.ButtonMinusLabel, "ButtonMinusLabel");
            this.ButtonMinusLabel.Name = "ButtonMinusLabel";
            // 
            // ButtonMinusCombo
            // 
            resources.ApplyResources(this.ButtonMinusCombo, "ButtonMinusCombo");
            this.ButtonMinusCombo.DisplayMember = "Name";
            this.ButtonMinusCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ButtonMinusCombo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ButtonMinusCombo.FormattingEnabled = true;
            this.ButtonMinusCombo.Name = "ButtonMinusCombo";
            this.ButtonMinusCombo.ValueMember = "Action";
            // 
            // ButtonLLabel
            // 
            resources.ApplyResources(this.ButtonLLabel, "ButtonLLabel");
            this.ButtonLLabel.Name = "ButtonLLabel";
            // 
            // ButtonLCombo
            // 
            resources.ApplyResources(this.ButtonLCombo, "ButtonLCombo");
            this.ButtonLCombo.DisplayMember = "Name";
            this.ButtonLCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ButtonLCombo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ButtonLCombo.FormattingEnabled = true;
            this.ButtonLCombo.Name = "ButtonLCombo";
            this.ButtonLCombo.ValueMember = "Action";
            // 
            // ButtonRLabel
            // 
            resources.ApplyResources(this.ButtonRLabel, "ButtonRLabel");
            this.ButtonRLabel.Name = "ButtonRLabel";
            // 
            // ButtonRCombo
            // 
            resources.ApplyResources(this.ButtonRCombo, "ButtonRCombo");
            this.ButtonRCombo.DisplayMember = "Name";
            this.ButtonRCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ButtonRCombo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ButtonRCombo.FormattingEnabled = true;
            this.ButtonRCombo.Name = "ButtonRCombo";
            this.ButtonRCombo.ValueMember = "Action";
            // 
            // ButtonZLLabel
            // 
            resources.ApplyResources(this.ButtonZLLabel, "ButtonZLLabel");
            this.ButtonZLLabel.Name = "ButtonZLLabel";
            // 
            // ButtonZRLabel
            // 
            resources.ApplyResources(this.ButtonZRLabel, "ButtonZRLabel");
            this.ButtonZRLabel.Name = "ButtonZRLabel";
            // 
            // ButtonZRCombo
            // 
            resources.ApplyResources(this.ButtonZRCombo, "ButtonZRCombo");
            this.ButtonZRCombo.DisplayMember = "Name";
            this.ButtonZRCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ButtonZRCombo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ButtonZRCombo.FormattingEnabled = true;
            this.ButtonZRCombo.Name = "ButtonZRCombo";
            this.ButtonZRCombo.ValueMember = "Action";
            // 
            // ButtonZLReservedLabel
            // 
            resources.ApplyResources(this.ButtonZLReservedLabel, "ButtonZLReservedLabel");
            this.ButtonZLReservedLabel.Name = "ButtonZLReservedLabel";
            // 
            // ReverserLabel
            // 
            resources.ApplyResources(this.ReverserLabel, "ReverserLabel");
            this.ReverserLabel.Name = "ReverserLabel";
            // 
            // ReverserValue
            // 
            resources.ApplyResources(this.ReverserValue, "ReverserValue");
            this.ReverserValue.Name = "ReverserValue";
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ReverserLabel);
            this.Controls.Add(this.ReverserValue);
            this.Controls.Add(this.ButtonZLReservedLabel);
            this.Controls.Add(this.ButtonZRLabel);
            this.Controls.Add(this.ButtonZRCombo);
            this.Controls.Add(this.ButtonZLLabel);
            this.Controls.Add(this.ButtonRLabel);
            this.Controls.Add(this.ButtonRCombo);
            this.Controls.Add(this.ButtonLLabel);
            this.Controls.Add(this.ButtonLCombo);
            this.Controls.Add(this.ButtonMinusLabel);
            this.Controls.Add(this.ButtonMinusCombo);
            this.Controls.Add(this.ButtonPlusLabel);
            this.Controls.Add(this.ButtonPlusCombo);
            this.Controls.Add(this.ButtonYLabel);
            this.Controls.Add(this.ButtonYCombo);
            this.Controls.Add(this.ButtonXLabel);
            this.Controls.Add(this.ButtonXCombo);
            this.Controls.Add(this.ButtonBLabel);
            this.Controls.Add(this.ButtonBCombo);
            this.Controls.Add(this.ButtonALabel);
            this.Controls.Add(this.ButtonACombo);
            this.Controls.Add(this.MasconLevelLabel);
            this.Controls.Add(this.MasconLevel);
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
        private System.Windows.Forms.Label MasconLevel;
        private System.Windows.Forms.Label MasconLevelLabel;
        private System.Windows.Forms.ComboBox ButtonACombo;
        private System.Windows.Forms.Label ButtonALabel;
        private System.Windows.Forms.Label ButtonBLabel;
        private System.Windows.Forms.ComboBox ButtonBCombo;
        private System.Windows.Forms.Label ButtonXLabel;
        private System.Windows.Forms.ComboBox ButtonXCombo;
        private System.Windows.Forms.Label ButtonYLabel;
        private System.Windows.Forms.ComboBox ButtonYCombo;
        private System.Windows.Forms.Label ButtonPlusLabel;
        private System.Windows.Forms.ComboBox ButtonPlusCombo;
        private System.Windows.Forms.Label ButtonMinusLabel;
        private System.Windows.Forms.ComboBox ButtonMinusCombo;
        private System.Windows.Forms.Label ButtonLLabel;
        private System.Windows.Forms.ComboBox ButtonLCombo;
        private System.Windows.Forms.Label ButtonRLabel;
        private System.Windows.Forms.ComboBox ButtonRCombo;
        private System.Windows.Forms.Label ButtonZLLabel;
        private System.Windows.Forms.Label ButtonZRLabel;
        private System.Windows.Forms.ComboBox ButtonZRCombo;
        private System.Windows.Forms.Label ButtonZLReservedLabel;
        private System.Windows.Forms.Label ReverserLabel;
        private System.Windows.Forms.Label ReverserValue;
    }
}

