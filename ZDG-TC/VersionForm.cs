using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace ZDG_TC
{
    public partial class VersionForm : Form
    {
        public VersionForm()
        {
            InitializeComponent();

            // 実行中のアセンブリを取得
            var assm = Assembly.GetExecutingAssembly();
            T GetCustomAttribute<T>() where T : Attribute => (T)Attribute.GetCustomAttribute(assm, typeof(T));

            // アプリのロゴ表示
            using (var stream = assm.GetManifestResourceStream("YZLIA_ZDGTC.resources.yuzulia-logo.png"))
            {
                LogoPicture.Image = Image.FromStream(stream);
            }

            // アプリの名前
            ProductNameValue.Text = assm.GetName().Name;

            // アプリのバージョン
            VersionValue.Text = assm.GetName().Version.ToString();

            // アプリの著作権表示
            Copyright.Text = GetCustomAttribute<AssemblyCopyrightAttribute>().Copyright;

            // ライセンス表示
            using (var stream = assm.GetManifestResourceStream("YZLIA_ZDGTC.resources.Licenses.txt"))
            {
                var reader = new StreamReader(stream);
                LicenseTextbox.Text = reader.ReadToEnd();
            }
        }

        private void ButtonOK_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SourceCodeLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(SourceCodeLink.Text);
        }
    }
}
