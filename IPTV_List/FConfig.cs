using System;
using System.Configuration;
using System.Windows.Forms;

namespace M3U_GST
{
    public partial class FConfig : Form
    {
        string url = ConfigurationManager.AppSettings["url"].ToString();
        public FConfig()
        {
            InitializeComponent();
            txtURL.Text = url;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.AppSettings.Settings["url"].Value = txtURL.Text;
            config.Save(ConfigurationSaveMode.Modified);

            this.Close();
            this.DialogResult = DialogResult.OK;
        }
    }
}
