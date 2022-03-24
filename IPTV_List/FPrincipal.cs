using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace M3U_GST
{
    public partial class FPrincipal : Form
    {
        string m3uLoadFromServer = String.Empty;
        string m3uOpened = String.Empty;

        string urlUserIPTV = ConfigurationManager.AppSettings["url"].ToString();
        string urlToPlay = String.Empty;
        string urlFromFileSaveLoad = String.Empty;

        List<IPTV> lsIptv = new List<IPTV>();
        List<IPTV> lsIptvExcluded = new List<IPTV>();
        ObservableCollection<IPTV> filteredIptv = new ObservableCollection<IPTV>();
        ObservableCollection<IPTV> lstToSave = new ObservableCollection<IPTV>();

        string lsSave = String.Empty;

        public FPrincipal()
        {
            InitializeComponent();

            StartApplication();
            tslTotalResult.Text = lsIptv.Count.ToString();
        }

        private void StartApplication()
        {
            urlUserIPTV = ConfigurationManager.AppSettings["url"].ToString();

            if (!String.IsNullOrEmpty(urlUserIPTV))
            {
                m3uLoadFromServer = (new WebClient()).DownloadString(urlUserIPTV);
                lsIptv = ReturnIPTVFILE(m3uLoadFromServer);

                ReloadGrupo();
            }
        }

        private List<IPTV> ReturnIPTVFILE(string str)
        {
            str = str.Replace("tvg-logo=\"LINK_LOGO\"", "").Replace("tvg-logo=\"MUDAR\"", "");
            int count = 0;

            return str.Split("#EXTINF").Select(x => new IPTV()
            {
                id = count++,
                tvg_logo = x.Contains("#EXTM3U") ? String.Empty : ReturnIptvLogo(x),
                group_title = x.Contains("#EXTM3U") ? String.Empty : ReturnIptvGroupTitle(x),
                title = x.Contains("#EXTM3U") ? String.Empty : ReturnIptvTitle(x),
                url = x.Contains("#EXTM3U") ? String.Empty : ReturnIptvUrl(x),
            }).ToList();
        }

        private string ReturnIptvLogo(string str)
        {
            if (str.Split("\"")[1].Contains("http")) return str.Split("\"")[1];
            return String.Empty;
        }

        private string ReturnIptvGroupTitle(string str)
        {
            if (str.Split("\"")[1].Contains("http")) return TratarCampos(str.Split("\"")[3]);
            return str.Split("\"")[1];
        }

        private string ReturnIptvTitle(string str)
        {
            return TratarCampos(str.Split(",")[1].Split("\n")[0]);
        }

        private string ReturnIptvUrl(string str)
        {
            return str.Split(",").Last().Split("\n")[1].Replace("\r", "");
        }

        private string TratarCampos(string str)
        {
            if (String.IsNullOrEmpty(str)) return String.Empty;
            if(String.IsNullOrWhiteSpace(str[0].ToString())) str = str.Remove(0, 1);
            return str;
        }

        private void ReloadGrupo()
        {
            IList<String> ils = lsIptv.Where(x => !String.IsNullOrEmpty(x.group_title) && x.group_title.ToLower().Contains(txtGrupo.Text.ToLower()))
                .Select(x => x.group_title).Distinct().ToList();

            dgvGrupo.DataSource = null;
            dgvGrupo.DataSource = ils.Select(x => new { Value = x }).ToList();

            dgvGrupo.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvGrupo.Refresh();
        }

        private void dgvGrupo_SelectionChanged(object sender, EventArgs e)
        {
            ReloadConteudo();
        }

        private void btnAddAll_Click(object sender, EventArgs e)
        {
            foreach (IPTV iPTV in filteredIptv)
            {
                if (dgvIPTV.CurrentRow != null)
                {
                    int newIndex = dgvIPTV.CurrentRow.Index + 1;
                    lstToSave.Insert(newIndex, iPTV);
                }
                else lstToSave.Add(iPTV);
            }

            SetListToSave();
            ReloadConteudo();
        }

        private void btnAddOne_Click(object sender, EventArgs e)
        {
            AddOne();
        }

        private void dgvConteudo_DoubleClick(object sender, EventArgs e)
        {
            AddOne();
        }

        private void AddOne()
        {
            if (dgvConteudo.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvConteudo.SelectedRows)
                {
                    IPTV iPTV = filteredIptv.Where(x => x.id == Convert.ToInt32(row.Cells[0].Value)).FirstOrDefault();
                    if (!lstToSave.Contains(iPTV))
                    {
                        if (dgvIPTV.CurrentRow != null)
                        {
                            int newIndex = dgvIPTV.CurrentRow.Index + 1;
                            lstToSave.Insert(newIndex, iPTV);
                        }
                        else lstToSave.Add(iPTV);
                    }
                }

                SetListToSave();
                ReloadConteudo();
            }
        }

        private void btnRemoveOne_Click(object sender, EventArgs e)
        {
            RemoveOne();
        }

        private void dgvIPTV_DoubleClick(object sender, EventArgs e)
        {
            RemoveOne();
        }

        private void RemoveOne()
        {
            if (dgvIPTV.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvIPTV.SelectedRows)
                {
                    IPTV iPTV = lstToSave.Where(x => x.id == Convert.ToInt32(row.Cells[0].Value)).FirstOrDefault();
                    lstToSave.Remove(iPTV);
                }

                SetListToSave();
                ReloadConteudo();

                if (dgvIPTV.Rows.Count > 0)
                {
                    dgvIPTV.Rows[0].Selected = true;
                    dgvIPTV.CurrentCell = dgvIPTV.Rows[0].Cells[3];
                }
            }
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            lstToSave.Clear();
            SetListToSave();
            ReloadConteudo();
        }

        private void SetListToSave()
        {
            dgvIPTV.DataSource = null;
            dgvIPTV.DataSource = lstToSave;

            dgvIPTV.Columns[0].Visible = false;
            dgvIPTV.Columns[1].Visible = false;
            dgvIPTV.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvIPTV.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvIPTV.Columns[4].Visible = false;

            dgvIPTV.Refresh();

            tslListaResult.Text = lstToSave.Count.ToString();
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            int oldIndex = dgvIPTV.CurrentRow.Index;
            int newIndex = dgvIPTV.CurrentRow.Index - 1;

            if (dgvIPTV.CurrentRow.Index > 0) lstToSave.Move(oldIndex, newIndex);
            SetListToSave();
            dgvIPTV.Rows[newIndex].Selected = true;

            dgvIPTV.CurrentCell = dgvIPTV.Rows[newIndex].Cells[3];
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            int oldIndex = dgvIPTV.CurrentRow.Index;
            int newIndex = dgvIPTV.CurrentRow.Index + 1;

            if (dgvIPTV.CurrentRow.Index <= lstToSave.Count) lstToSave.Move(oldIndex, newIndex);
            SetListToSave();
            dgvIPTV.Rows[newIndex].Selected = true;

            dgvIPTV.CurrentCell = dgvIPTV.Rows[newIndex].Cells[3];
        }

        private void ReloadConteudo()
        {
            if (dgvGrupo.SelectedCells.Count > 0)
            {
                List<IPTV> lsConteudo = lsIptv.Where(x => x.group_title == dgvGrupo.SelectedCells[0].Value.ToString() &&
                    x.title.ToLower().Contains(txtConteudo.Text.ToLower()) &&
                    !lstToSave.Select(y => y.url).Contains(x.url)).ToList();

                lsConteudo = ImageQuality(lsConteudo);

                SetConteudo(lsConteudo);
            }
        }

        private void ReloadConteudoAll()
        {
            List<IPTV> lsConteudo = lsIptv.Where(x => x.title.ToLower().Contains(tsbFillByAll.Text.ToLower())).ToList();
            SetConteudo(lsConteudo);
        }

        private void SetConteudo(List<IPTV> lsConteudo)
        {
            filteredIptv = new ObservableCollection<IPTV>();
            foreach (IPTV iPTV in lsConteudo) filteredIptv.Add(iPTV);

            dgvConteudo.DataSource = filteredIptv;
            dgvConteudo.Columns[0].Visible = false;
            dgvConteudo.Columns[1].Visible = false;
            dgvConteudo.Columns[2].Visible = false;
            dgvConteudo.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvConteudo.Columns[4].Visible = false;

            tslPastaResult.Text = filteredIptv.Count.ToString();
        }

        private List<IPTV> ImageQuality(List<IPTV> lsConteudo)
        {
            if (!chkSD.Checked) lsConteudo = lsConteudo.Where(x => !x.title.Contains(" SD")).ToList();
            if (!chkHD.Checked) lsConteudo = lsConteudo.Where(x => !x.title.Contains(" HD")).ToList();
            if (!chkFHD.Checked) lsConteudo = lsConteudo.Where(x => !x.title.Contains(" FHD")).ToList();
            if (!chk4K.Checked) lsConteudo = lsConteudo.Where(x => !x.title.Contains("4K")).ToList();

            return lsConteudo;
        }

        private void chkSD_CheckedChanged(object sender, EventArgs e)
        {
            ReloadConteudo();
        }

        private void chkHD_CheckedChanged(object sender, EventArgs e)
        {
            ReloadConteudo();
        }

        private void chkFHD_CheckedChanged(object sender, EventArgs e)
        {
            ReloadConteudo();
        }

        private void chk4K_CheckedChanged(object sender, EventArgs e)
        {
            ReloadConteudo();
        }

        private void txtConteudo_TextChanged(object sender, EventArgs e)
        {
            ReloadConteudo();
        }

        private void txtGrupo_TextChanged(object sender, EventArgs e)
        {
            ReloadGrupo();
        }

        private void tsbFillByAll_TextChanged(object sender, EventArgs e)
        {
            if (tsbFillByAll.Text.Length > 0) ReloadConteudoAll();
            else ReloadConteudo();
        }

        private void tsbConfig_Click(object sender, EventArgs e)
        {
            FConfig fConfig = new FConfig();
            if (fConfig.ShowDialog() == DialogResult.OK) this.Close();
        }

        private void tsbLoadDoc_Click(object sender, EventArgs e)
        {
            ImportarLista();
        }

        private void tsmImportList_Click(object sender, EventArgs e)
        {
            ImportarLista();
        }

        private void ImportarLista()
        {
            lsIptvExcluded = new List<IPTV>();

            OpenFileDialog dialog = new OpenFileDialog();
            dialog.DefaultExt = "m3u";
            dialog.Filter = "m3u files (*.m3u)|*.m3u";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                urlFromFileSaveLoad = dialog.FileName;
                m3uOpened = File.ReadAllText(dialog.FileName);

                foreach (IPTV iPTV in ReturnIPTVFILE(m3uOpened))
                {
                    if (iPTV.id == 0) continue;
                    else
                    {
                        if (!lsIptv.Select(x => x.url).Contains(iPTV.url)) lsIptvExcluded.Add(iPTV);
                        lstToSave.Add(iPTV);
                    }
                }

                if (lsIptvExcluded.Count > 0) MessageBox.Show("Sua lista contém items que foram removidos do serviço!", Text, MessageBoxButtons.OK,
                     MessageBoxIcon.Information);

                SetListToSave();
                ReloadConteudo();
            }
        }

        private void dgvIPTV_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach(DataGridViewRow row in dgvIPTV.Rows)
            {
                if (lsIptvExcluded.Select(x => x.url).Contains(row.Cells[4].Value)) 
                    row.DefaultCellStyle.BackColor = Color.LightSalmon;
            }
        }

        private void dgvConteudo_SelectionChanged(object sender, EventArgs e)
        {
            ShowCurrentIPTV(sender as DataGridView);
        }

        private void dgvIPTV_SelectionChanged(object sender, EventArgs e)
        {
            ShowCurrentIPTV(sender as DataGridView);
        }

        private void ShowCurrentIPTV(DataGridView sender)
        {
            if (sender.CurrentRow != null)
            {
                if (sender.CurrentRow.Cells[4].Value == null) return;

                IPTV iPTV = lsIptv.Where(x => x.url == sender.CurrentRow.Cells[4].Value.ToString()).FirstOrDefault();

                txtGrupoConsulta.Text = iPTV.group_title;
                txtTituloConsulta.Text = iPTV.title;
                txtURLConsulta.Text = iPTV.url;
                picLogo.ImageLocation = iPTV.tvg_logo;

                urlToPlay = iPTV.url;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Play();
        }

        private void Play()
        {
            ExecuteCommand(@"C:\\Program Files (x86)\VideoLAN\VLC\vlc.exe", urlToPlay);
        }

        private void ExecuteCommand(string soft, string arg)
        {
            Process pr = new Process();
            pr.StartInfo.FileName = soft;
            pr.StartInfo.Arguments = arg;
            pr.Start();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            IPTV iPTV = lsIptv.Where(x => x.url == txtURLConsulta.Text).FirstOrDefault();
            string group = iPTV.group_title;

            iPTV.group_title = txtGrupoConsulta.Text;
            iPTV.title = txtTituloConsulta.Text;
            iPTV.url = txtURLConsulta.Text;

            if(iPTV.group_title != group)
            {
                List<IPTV> iPTVs = lsIptv.Where(x => x.group_title == group).ToList();
                foreach (IPTV ip in iPTVs) ip.group_title = txtGrupoConsulta.Text;
                ReloadGrupo();
            }
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void stsSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void tsbSaveAs_Click(object sender, EventArgs e)
        {
            urlFromFileSaveLoad = String.Empty;
            Save();
        }

        private void stsSaveAs_Click(object sender, EventArgs e)
        {
            urlFromFileSaveLoad = String.Empty;
            Save();
        }

        private void Save()
        {
            lsSave = "#EXTM3U";

            foreach (IPTV iPTV in lstToSave)
            {
                lsSave += "\r\n#EXTINF:-1";

                if (!String.IsNullOrEmpty(iPTV.tvg_logo)) lsSave += " tvg-logo=\"" + iPTV.tvg_logo + "\"";
                if (!String.IsNullOrEmpty(iPTV.group_title)) lsSave += " group-title=\"" + iPTV.group_title + "\"";
                lsSave += "," + iPTV.title.Replace("\r", "") + "\r\n" + iPTV.url;
            }

            if (String.IsNullOrEmpty(urlFromFileSaveLoad))
            {
                SaveFileDialog dialog = new SaveFileDialog();
                dialog.DefaultExt = "m3u";
                dialog.Filter = "m3u files (*.m3u)|*.m3u|All files (*.*)|*.*";
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = File.CreateText(dialog.FileName))
                    {
                        sw.WriteLine(lsSave);
                        urlFromFileSaveLoad = dialog.FileName;
                    }
                }
            }
            else
            {
                using (StreamWriter sw = File.CreateText(urlFromFileSaveLoad))
                {
                    sw.WriteLine(lsSave);
                }
            }
        }

        private void tsmSobre_Click(object sender, EventArgs e)
        {
            AboutBox aboutBox = new AboutBox();
            aboutBox.ShowDialog();
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_KeyPress(object sender, KeyPressEventArgs e)
        {
            List<Char> keys = new List<Char>() { Convert.ToChar(Keys.Enter), Convert.ToChar(Keys.Space) };
            if(keys.Contains(e.KeyChar)) Play();
        }
    }

    public class IPTV
    {
        public int id { get; set; }
        public string tvg_logo { get; set; }
        public string group_title { get; set; }
        public string title { get; set; }
        public string url { get; set; }
    }
}
