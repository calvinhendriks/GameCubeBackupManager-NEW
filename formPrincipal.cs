using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCubeBackupManager
{
    public partial class formPrincipal : Form
    {
        WebClient client = new WebClient();
        HttpWebResponse response = null;

        // IniFile 
        readonly IniFile configIniFile = new IniFile("config.ini");
        // CultureInfo
        CultureInfo myCulture = new CultureInfo("pt-BR", false);
        // ProcessStartInfo
        readonly ProcessStartInfo startInfo = new ProcessStartInfo();

        private readonly string currentPath = Environment.CurrentDirectory;
        private static string getCurrentPath = Directory.GetCurrentDirectory();
        // Cover path
        private string sourcePathDisc = getCurrentPath + @"\covers\cache\disc";
        private string sourcePath2D = getCurrentPath + @"\covers\cache\2d";
        private string sourcePath3D = getCurrentPath + @"\covers\cache\3d";
        private string sourcePathFull = getCurrentPath + @"\covers\cache\full";
        // WiiTDB ZIP
        private readonly string zipWiiTDB = @"wiitdb.zip";
        // WiiTDB XML
        private readonly string ArquivoXML = @"wiitdb.xml";
        //private static string tempPath = @"\temp";
        //private readonly string tempPath = ""; //txtSettingsGeneralTempPath.Text;
        //private static string coverDirectory;

        // GCIT
        private string flushSD;
        private string scrubAlign;

        private static string filename = "";
        private static string caminhoImagem;
        private string _code = "";
        private string _codeUnion;
        private string myDirectoryCoverDestiny;
        //private string myApp = string.Format("GameCube Backup Manager {0}", Application.ProductVersion) + "(Build " + Application.ProductVersion.Substring(5).Remove(2, 2) + ")" + " | By Laete Meireles";

        public formPrincipal()
        {
            InitializeComponent();

            //this.Text = myApp;

            //SystemMemory();
            NetworkCheck();
            //RegisterHeaderLog();
            //RequiredDirectories();
            //TxtGeneral();
            //GetDrivesUSB();
            //GetAllDrives();
            //ConfigStart();
            //SaveLoadConfigFile();
            //CheckWiiTDBXML();
            //LoadDatabase();
            //timer1.Start();
        }

        /// <summary>
        /// Networks the check.
        /// </summary>
        private void NetworkCheck()
        {
            if (!NetworkInterface.GetIsNetworkAvailable()) // Remover o sinal '!'
            {
                //MessageBox.Show("Conexão de rede não disponível." + Environment.NewLine + 
                //    "GameCube Backup Manager será fechado!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Conexão de rede não disponível." + Environment.NewLine +
                    "Algumas funções do GameCube Backup Manager estarão indisponíveis até que uma conexão de rede seja fornecida!", 
                    "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Environment.Exit(-1);
            }
            return;
        }

        /// <summary>
        /// Registers the header log.
        /// </summary>
        private void RegisterHeaderLog()
        {
            textLog.AppendText("Entradas do Registro :" + Environment.NewLine);
            textLog.AppendText(Environment.NewLine + DateTime.Now.ToLongTimeString() + Environment.NewLine
                + DateTime.Now.ToLongDateString() + Environment.NewLine);
            textLog.AppendText("------------------------------------------------------------" + Environment.NewLine);
            textLog.AppendText(">> Diretório atual do programa: " + getCurrentPath + Environment.NewLine);
            //textLog.AppendText(">> Arquivo WiiTDB base: " + ArquivoXML + Environment.NewLine);
            textLog.AppendText("------------------------------------------------------------" + Environment.NewLine);
        }

        /// <summary>
        /// Configurations the start.
        /// </summary>
        private void ConfigStart()
        {
            //comboBoxSettingsGeneralFileSize.SelectedIndex = 0;
            //comboBoxSettingsNomenclatureLayoutFolder.SelectedIndex = 0;
            //comboBoxSettingsNomenclatureAppointmentStyle.SelectedIndex = 0;
            //comboBoxDriversDVD.SelectedIndex = 4;
            comboBoxDeviceDriveUSB.SelectedIndex = 0;
            //comboBoxScrubAlign.SelectedIndex = 0;
            //comboBoxScrubFormat.SelectedIndex = 1;
            //txtSettingsGeneralTempPath.Text = getCurrentPath + tempPath;

            // Configuration - Cover Disc Directory
            //groupBoxCoverTransfer.Enabled = false;
        }

        /// <summary>
        /// Totals the size of the directory.
        /// </summary>
        /// <param name="dInfo">The d information.</param>
        /// <param name="includeSubDir">if set to <c>true</c> [include sub dir].</param>
        /// <returns></returns>
        private long TotalDirectorySize(DirectoryInfo dInfo, bool includeSubDir)
        {
            long tamanhoTotal = dInfo.EnumerateFiles().Sum(file => file.Length);
            if (includeSubDir)
            {
                tamanhoTotal += dInfo.EnumerateDirectories().Sum(dir => TotalDirectorySize(dir, true));
            }
            return tamanhoTotal;
        }

        /// <summary>
        /// Exibes the arquivos da pasta selecionada.
        /// </summary>
        /// <param name="pastaOrigem">The pasta origem.</param>
        private void ExibeArquivosDaPastaSelecionada(string pastaOrigem) // DisplayFilesSelectedFolder(string pastaOrigem)
        {
            DirectoryInfo infoDiretorio = new DirectoryInfo(fbd1.SelectedPath);

            var filtros = new String[] { "iso", "gcm" };
            var arquivos = GetFolderFiles(pastaOrigem, filtros, false);

            if (dataGridViewGame.RowCount == 0)
            {
                BtnGameInstallExactCopy.Enabled = true;
                BtnGameInstallScrub.Enabled = true;
                BtnRenameGameISO.Enabled = true;
                //tsmiRanameGameISO.Enabled = true;
                BtnDeleteGame.Enabled = true;
                BtnHashGame.Enabled = true;
            }

            labelQuantISO.Text = arquivos.Length.ToString();
            labelQuantTotal.Text = arquivos.Length.ToString();

            long tamanhoDoDiretorio = TotalDirectorySize(infoDiretorio, true);
            labelSizeISO.Text = FormatFileSizeDisplay(tamanhoDoDiretorio, configIniFile.IniReadInt("General", "FileSize"));
            labelSizeTotal.Text = FormatFileSizeDisplay(tamanhoDoDiretorio, configIniFile.IniReadInt("General", "FileSize"));

            // Groups files in the folder by extension.
            var arquivosAgrupadosPorExtensao = arquivos.Select(
                arq => Path.GetExtension(arq).TrimStart('.').ToLower(myCulture)).GroupBy(x => x, (ext, extCnt) =>
                new { Extensao = ext, Contador = extCnt.Count() });

            // Scroll through the result and display the values.
            foreach (var arquivo in arquivosAgrupadosPorExtensao)
            {
                textLog.AppendText(Environment.NewLine + ">> Encontrados " + arquivo.Contador + " arquivo(s) com extensão ."
                    + arquivo.Extensao.ToUpper(myCulture));
            }
            textLog.AppendText(Environment.NewLine);

            // Creates a DataTable with file data.
            DataTable tabela = new DataTable();
            tabela.Columns.Add("Arquivo");
            tabela.Columns.Add("Tipo");
            tabela.Columns.Add("Tamanho");

            for (int i = 0; i < arquivos.Length; i++)
            {
                FileInfo arquivo = new FileInfo(arquivos[i]);
                string _getSize = FormatFileSizeDisplay(arquivo.Length, configIniFile.IniReadInt("General", "FileSize"));
                tabela.Rows.Add(arquivo.Name, arquivo.Extension.Substring(1, 3).Trim().ToUpper(myCulture), _getSize);
            }
            // Displays data in DataGridView.
            dataGridViewGame.DataSource = tabela;
            dataGridViewGame.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            dataGridViewGame.Columns[0].Width = 482;
            dataGridViewGame.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        //public string[] GetArquivosDaPasta(string pastaRaiz, string[] filtros, bool isRecursiva)
        public string[] GetFolderFiles(string pastaRaiz, string[] filtros, bool isRecursiva)
        {
            List<string> arquivosEncontrados = new List<string>();
            // Sets options for displaying root folder images.

            //if (chkSettingsGeneralRecursiva.Checked == true)
            if (configIniFile.IniReadBool("General", "RecursiveMode") == true)
            {
                isRecursiva = true;
            }
            else
            {
                isRecursiva = false;
            }

            var opcaoDeBusca = isRecursiva ? System.IO.SearchOption.AllDirectories : System.IO.SearchOption.TopDirectoryOnly;
            foreach (var filtro in filtros)
            {
                arquivosEncontrados.AddRange(Directory.GetFiles(pastaRaiz, string.Format("*.{0}", filtro), opcaoDeBusca));
            }
            return arquivosEncontrados.ToArray();
        }

        public static string FormatFileSizeDisplay(long i, int k)
        {
            // Obtém o valor absoluto
            long i_absoluto = (i < 0 ? -i : i);
            string sufixo;
            double leitura;

            if (k == 0)
            {
                if (i_absoluto >= 0x1000000000000000) // Exabyte
                {
                    sufixo = "EB";
                    leitura = (i >> 50);
                }
                else if (i_absoluto >= 0x4000000000000) // Petabyte
                {
                    sufixo = "PB";
                    leitura = (i >> 40);
                }
                else if (i_absoluto >= 0x10000000000) // Terabyte
                {
                    sufixo = "TB";
                    leitura = (i >> 30);
                }
                else if (i_absoluto >= 0x40000000) // Gigabyte
                {
                    sufixo = "GB";
                    leitura = (i >> 20);
                }
                else if (i_absoluto >= 0x100000) // Megabyte
                {
                    sufixo = "MB";
                    leitura = (i >> 10);
                }
                else if (i_absoluto >= 0x400) // Kilobyte
                {
                    sufixo = "KB";
                    leitura = i;
                }
                else
                {
                    return i.ToString("0 bytes"); // Byte
                }
            }
            else if (k == 1) // Kilobyte
            {
                sufixo = "KB";
                leitura = i;
            }
            else if (k == 2) // Megabyte
            {
                sufixo = "MB";
                leitura = (i >> 10);
            }
            else if (k == 3) // Gigabyte
            {
                sufixo = "GB";
                leitura = (i >> 20);
            }
            else if (k == 4) // Terabyte
            {
                sufixo = "TB";
                leitura = (i >> 30);
            }
            else
            {
                return i.ToString("0 bytes"); // Byte
            }
            // Divide by 1024 to get the fractional value.
            leitura = (leitura / 1024);
            // Returns the suffix formatted number.
            return leitura.ToString("0.## ") + sufixo;
        }












        // Menus
        private void tsmiConfig_Click(object sender, EventArgs e)
        {
            formConfig frmConfig = new formConfig();
            frmConfig.ShowDialog();
        }

        private void tsmiPrincipalExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            formAbout frmAbout = new formAbout();
            frmAbout.ShowDialog();
        }

        private void tsmiExtraInfo_Click(object sender, EventArgs e)
        {
            formExtralnformation frmExtraInfo = new formExtralnformation();
            frmExtraInfo.ShowDialog();
        }

        // Botões

        /// <summary>
        /// Handles the Click event of the BtnDeleteGame control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnDeleteGame_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Handles the Click event of the BtnSelectFolder control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnSelectFolder_Click(object sender, EventArgs e)
        {
            if (dataGridViewGame.RowCount == 0)
            {
                //cbbDeviceDriveUSB.Enabled = false;
                BtnGameInstallExactCopy.Enabled = false;
                BtnGameInstallScrub.Enabled = false;
                BtnDeleteGame.Enabled = false;
                BtnHashGame.Enabled = false;
            }
            else
            {
                //cbbDeviceDriveUSB.Enabled = true;
                BtnGameInstallExactCopy.Enabled = true;
                BtnGameInstallScrub.Enabled = true;
                BtnDeleteGame.Enabled = true;
                BtnHashGame.Enabled = true;
            }

            try
            {
                fbd1.Description = "Selecione uma pasta";
                fbd1.RootFolder = Environment.SpecialFolder.Desktop;
                fbd1.ShowNewFolderButton = false;
                if (fbd1.ShowDialog() == DialogResult.OK)
                {
                    // DisplayFilesSelectedFolder(fbd1.SelectedPath);
                    ExibeArquivosDaPastaSelecionada(fbd1.SelectedPath);
                    ListIsoFile();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Lists the iso file.
        /// </summary>
        private void ListIsoFile()
        {
            textLog.AppendText(">> Arquivos ISO/GCM encontrados: " + Environment.NewLine);

            foreach (DataGridViewRow dgvResultRow in dataGridViewGame.Rows)
            {
                textLog.AppendText(">> " + dataGridViewGame.Rows[dgvResultRow.Index].Cells[0].Value.ToString() + Environment.NewLine);
            }
        }








    }
}
