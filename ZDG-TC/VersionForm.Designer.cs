namespace ZDG_TC
{
    partial class VersionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VersionForm));
            this.ProductName = new System.Windows.Forms.Label();
            this.LogoPicture = new System.Windows.Forms.PictureBox();
            this.VersionLabel = new System.Windows.Forms.Label();
            this.VersionValue = new System.Windows.Forms.Label();
            this.ButtonOK = new System.Windows.Forms.Button();
            this.Copyright = new System.Windows.Forms.Label();
            this.LicenseTextbox = new System.Windows.Forms.TextBox();
            this.OpenSourceLabel = new System.Windows.Forms.Label();
            this.SourceCodeLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductName
            // 
            this.ProductName.AutoSize = true;
            this.ProductName.Location = new System.Drawing.Point(82, 12);
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(81, 12);
            this.ProductName.TabIndex = 0;
            this.ProductName.Text = "[ProductName]";
            // 
            // LogoPicture
            // 
            this.LogoPicture.Location = new System.Drawing.Point(12, 12);
            this.LogoPicture.Name = "LogoPicture";
            this.LogoPicture.Size = new System.Drawing.Size(64, 64);
            this.LogoPicture.TabIndex = 1;
            this.LogoPicture.TabStop = false;
            // 
            // VersionLabel
            // 
            this.VersionLabel.AutoSize = true;
            this.VersionLabel.Location = new System.Drawing.Point(82, 24);
            this.VersionLabel.Name = "VersionLabel";
            this.VersionLabel.Size = new System.Drawing.Size(56, 12);
            this.VersionLabel.TabIndex = 2;
            this.VersionLabel.Text = "バージョン: ";
            // 
            // VersionValue
            // 
            this.VersionValue.AutoSize = true;
            this.VersionValue.Location = new System.Drawing.Point(133, 24);
            this.VersionValue.Name = "VersionValue";
            this.VersionValue.Size = new System.Drawing.Size(91, 12);
            this.VersionValue.TabIndex = 3;
            this.VersionValue.Text = "[ProductVersion]";
            // 
            // ButtonOK
            // 
            this.ButtonOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButtonOK.Location = new System.Drawing.Point(377, 366);
            this.ButtonOK.Name = "ButtonOK";
            this.ButtonOK.Size = new System.Drawing.Size(75, 23);
            this.ButtonOK.TabIndex = 4;
            this.ButtonOK.Text = "OK";
            this.ButtonOK.UseVisualStyleBackColor = true;
            this.ButtonOK.Click += new System.EventHandler(this.ButtonOK_Click);
            // 
            // Copyright
            // 
            this.Copyright.AutoSize = true;
            this.Copyright.Location = new System.Drawing.Point(82, 36);
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(62, 12);
            this.Copyright.TabIndex = 5;
            this.Copyright.Text = "[Copyright]";
            // 
            // LicenseTextbox
            // 
            this.LicenseTextbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LicenseTextbox.BackColor = System.Drawing.SystemColors.Control;
            this.LicenseTextbox.Location = new System.Drawing.Point(12, 82);
            this.LicenseTextbox.Multiline = true;
            this.LicenseTextbox.Name = "LicenseTextbox";
            this.LicenseTextbox.ReadOnly = true;
            this.LicenseTextbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LicenseTextbox.Size = new System.Drawing.Size(440, 278);
            this.LicenseTextbox.TabIndex = 6;
            // 
            // OpenSourceLabel
            // 
            this.OpenSourceLabel.AutoSize = true;
            this.OpenSourceLabel.Location = new System.Drawing.Point(83, 52);
            this.OpenSourceLabel.Name = "OpenSourceLabel";
            this.OpenSourceLabel.Size = new System.Drawing.Size(222, 12);
            this.OpenSourceLabel.TabIndex = 7;
            this.OpenSourceLabel.Text = "このアプリはオープンソースで公開されています。";
            // 
            // SourceCodeLink
            // 
            this.SourceCodeLink.AutoSize = true;
            this.SourceCodeLink.Location = new System.Drawing.Point(83, 68);
            this.SourceCodeLink.Name = "SourceCodeLink";
            this.SourceCodeLink.Size = new System.Drawing.Size(211, 12);
            this.SourceCodeLink.TabIndex = 8;
            this.SourceCodeLink.TabStop = true;
            this.SourceCodeLink.Text = "https://github.com/YuzuRyo61/ZDG-TC";
            this.SourceCodeLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SourceCodeLink_LinkClicked);
            // 
            // VersionForm
            // 
            this.AcceptButton = this.ButtonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ButtonOK;
            this.ClientSize = new System.Drawing.Size(464, 401);
            this.Controls.Add(this.SourceCodeLink);
            this.Controls.Add(this.OpenSourceLabel);
            this.Controls.Add(this.LicenseTextbox);
            this.Controls.Add(this.Copyright);
            this.Controls.Add(this.ButtonOK);
            this.Controls.Add(this.VersionValue);
            this.Controls.Add(this.VersionLabel);
            this.Controls.Add(this.LogoPicture);
            this.Controls.Add(this.ProductName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VersionForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "バージョン情報 | ZDG-TC";
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProductName;
        private System.Windows.Forms.PictureBox LogoPicture;
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.Label VersionValue;
        private System.Windows.Forms.Button ButtonOK;
        private System.Windows.Forms.Label Copyright;
        private System.Windows.Forms.TextBox LicenseTextbox;
        private System.Windows.Forms.Label OpenSourceLabel;
        private System.Windows.Forms.LinkLabel SourceCodeLink;
    }
}