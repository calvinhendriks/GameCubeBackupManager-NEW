using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Management;

namespace GameCubeBackupManager
{
    public partial class formConfig : Form
    {
        // Initialize IniFile Class
        readonly IniFile configIniFile = new IniFile("config.ini");

        public formConfig()
        {
            InitializeComponent();
            
        }

        // Funções

        /// <summary>
        /// Configurations the start.
        /// </summary>
        private void ConfigStart()
        {
            comboBoxSettingsGeneralFileSize.SelectedIndex = 0;
            //comboBoxSettingsNomenclatureLayoutFolder.SelectedIndex = 0;
            comboBoxSettingsNomenclatureAppointmentStyle.SelectedIndex = 0;
            comboBoxDriversDVD.SelectedIndex = 4;
            //comboBoxDeviceDriveUSB.SelectedIndex = 0;
            comboBoxScrubAlign.SelectedIndex = 0;
            comboBoxScrubFormat.SelectedIndex = 1;
            //txtSettingsGeneralTempPath.Text = getCurrentPath + tempPath;

            // Configuration - Cover Disc Directory
            //groupBoxCoverTransfer.Enabled = false;
        }

        /// <summary>
        /// Configurations the folder browser dialog.
        /// </summary>
        private void ConfigFolderBrowserDialog()
        {
            //Define as propriedades do controle FolderBrowserDialog
            fbd1.Description = "Selecione uma pasta";
            fbd1.RootFolder = Environment.SpecialFolder.Desktop;
            fbd1.ShowNewFolderButton = false;
            //fbd1.SelectedPath = @"D:\GC_ISO";
        }

        /// <summary>
        /// Handles the Tick event of the timer1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            ObjectQuery objectQuery = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
            ManagementObjectSearcher managementObjectSearcher = new ManagementObjectSearcher(objectQuery);
            ManagementObjectCollection managementObjectCollection = managementObjectSearcher.Get();
            foreach (ManagementObject managementObject in managementObjectCollection)
            {
                labelTotalVisibleMemorySize.Text = managementObject["TotalVisibleMemorySize"].ToString();
                labelFreePhysicalMemory.Text = managementObject["FreePhysicalMemory"].ToString();
                labelTotalVirtualMemorySize.Text = managementObject["TotalVirtualMemorySize"].ToString();
                labelFreeVirtualMemory.Text = managementObject["FreeVirtualMemory"].ToString();
            }
            managementObjectSearcher.Dispose();
        }

        /// <summary>
        /// Saves the configuration file.
        /// </summary>
        private void SaveConfigFile()
        {
            // General
            configIniFile.IniWriteBool("General", "DiscClean", rbSettingsGeneralDiscClean.Checked);
            configIniFile.IniWriteBool("General", "DiscDelete", rbSettingsGeneralDiscDelete.Checked);
            configIniFile.IniWriteInt("General", "FileSize", comboBoxSettingsGeneralFileSize.SelectedIndex);
            configIniFile.IniWriteBool("General", "ExtractZip", chkExtractZip.Checked);
            configIniFile.IniWriteBool("General", "Extract7z", chkExtract7z.Checked);
            configIniFile.IniWriteBool("General", "ExtractRar", chkExtractRar.Checked);
            configIniFile.IniWriteBool("General", "ExtractBZip2", chkExtractBZip2.Checked);
            configIniFile.IniWriteBool("General", "ExtractSplitFile", chkExtractSplitFile.Checked);
            configIniFile.IniWriteString("General", "TemporaryFolder", textSettingsGeneralTempPath.Text);
            configIniFile.IniWriteBool("General", "RecursiveMode", chkSettingsGeneralRecursiva.Checked);
            configIniFile.IniWriteBool("General", "CheckMD5", chkSettingsGeneralMD5.Checked);
            configIniFile.IniWriteBool("General", "TemporaryBuffer", chkSettingsGeneralTemporaryBuffer.Checked);
            configIniFile.IniWriteBool("General", "CheckSHA1", chkSettingsGeneralSHA1.Checked);

            // Nomenclature
            //configIniFile.IniWriteInt("Nomenclature", "LayoutFolder", comboBoxSettingsNomenclatureLayoutFolder.SelectedIndex);
            configIniFile.IniWriteInt("Nomenclature", "AppointmentStyle", comboBoxSettingsNomenclatureAppointmentStyle.SelectedIndex);

            // Start

            // Titles
            configIniFile.IniWriteBool("Titles", "GameTDBTXT", chkGameTdbTXT.Checked);
            configIniFile.IniWriteBool("Titles", "GameTDBXML", chkGameTdbXML.Checked);
            configIniFile.IniWriteBool("Titles", "CustomTitles", chkGameCustomTitles.Checked);
            configIniFile.IniWriteString("Titles", "LocationTitles", textTitles.Text);
            configIniFile.IniWriteString("Titles", "LocationCustomTitles", textCustomTitles.Text);

            // Covers
            //configIniFile.IniWriteBool("Covers", "BackupCovers", chkCoversBackup.Checked);
            configIniFile.IniWriteBool("Covers", "DeleteCovers", chkCoversSynchronizeDelete.Checked);
            configIniFile.IniWriteBool("Covers", "KeepCovers", chkCoversSynchronizeKeep.Checked);
            configIniFile.IniWriteBool("Covers", "TransferCovers", chkEnableCoverTransfer.Checked);
            configIniFile.IniWriteBool("Covers", "CoversAutomaticDownload", chkCoversAutomaticDownload.Checked);
            configIniFile.IniWriteBool("Covers", "CoversIncludeDisplayed", chkCoversIncludeDisplayed.Checked);
            configIniFile.IniWriteBool("Covers", "WiiFlowCoverUSBLoader", rbCoverWiiFlow.Checked);
            configIniFile.IniWriteBool("Covers", "GXCoverUSBLoader", rbCoverUSBLoaderGX.Checked);
            configIniFile.IniWriteString("Covers", "CoverDirectoryCache", textBoxDirectoryCoverCache.Text);

            if (rbCoverWiiFlow.Checked)
            {
                configIniFile.IniWriteString("Covers", "WiiFlowCoverDirectoryDisc", textBoxDirectoryCoverDisc.Text);
                configIniFile.IniWriteString("Covers", "WiiFlowCoverDirectory2D", textBoxDirectoryCover2D.Text);
                configIniFile.IniWriteString("Covers", "WiiFlowCoverDirectory3D", textBoxDirectoryCover3D.Text);
                configIniFile.IniWriteString("Covers", "WiiFlowCoverDirectoryFull", textBoxDirectoryCoverFull.Text);
            }
            else
            {
                configIniFile.IniWriteString("Covers", "GXCoverDirectoryDisc", textBoxDirectoryCoverDisc.Text);
                configIniFile.IniWriteString("Covers", "GXCoverDirectory2D", textBoxDirectoryCover2D.Text);
                configIniFile.IniWriteString("Covers", "GXCoverDirectory3D", textBoxDirectoryCover3D.Text);
                configIniFile.IniWriteString("Covers", "GXCoverDirectoryFull", textBoxDirectoryCoverFull.Text);
            }

            // Downloads
            configIniFile.IniWriteBool("Downloads", "ListTaskComplete", chkDownloadListTaskComplete.Checked);
            configIniFile.IniWriteBool("Downloads", "ListTaskFailure", chkDownloadListTaskFailure.Checked);
            configIniFile.IniWriteBool("Downloads", "ListTaskCanceled", chkDownloadListTaskCanceled.Checked);
            configIniFile.IniWriteBool("Downloads", "PreviewCovers", chkDownloadPreviewCovers.Checked);

            // Emulators
            //configIniFile.IniWriteString("Emulators", "DolphinPath", textDolphinPath.Text);
            //configIniFile.IniWriteBool("Emulators", "DolphinD3D", rbDolphinD3D.Checked);
            //configIniFile.IniWriteBool("Emulators", "DolphinOpenGL", rbDolphinOpenGL.Checked);
            //configIniFile.IniWriteBool("Emulators", "DolphinHLE", rbDolphinHLE.Checked);
            //configIniFile.IniWriteBool("Emulators", "DolphinLLE", rbDolphinLLE.Checked);

            // Drives/DVD
            configIniFile.IniWriteInt("DriversDVD", "DriveSpeedDVD", comboBoxDriversDVD.SelectedIndex);
        }

        /// <summary>
        /// Loads the configuration file.
        /// </summary>
        private void LoadConfigFile()
        {
            // General
            rbSettingsGeneralDiscClean.Checked = configIniFile.IniReadBool("General", "DiscClean");
            rbSettingsGeneralDiscDelete.Checked = configIniFile.IniReadBool("General", "DiscDelete");
            comboBoxSettingsGeneralFileSize.SelectedIndex = configIniFile.IniReadInt("General", "FileSize");
            chkExtractZip.Checked = configIniFile.IniReadBool("General", "ExtractZip");
            chkExtract7z.Checked = configIniFile.IniReadBool("General", "Extract7z");
            chkExtractRar.Checked = configIniFile.IniReadBool("General", "ExtractRar");
            chkExtractBZip2.Checked = configIniFile.IniReadBool("General", "ExtractBZip2");
            chkExtractSplitFile.Checked = configIniFile.IniReadBool("General", "ExtractSplitFile");
            textSettingsGeneralTempPath.Text = configIniFile.IniReadString("General", "TemporaryFolder", "");
            chkSettingsGeneralRecursiva.Checked = configIniFile.IniReadBool("General", "RecursiveMode");
            chkSettingsGeneralMD5.Checked = configIniFile.IniReadBool("General", "CheckMD5");
            chkSettingsGeneralTemporaryBuffer.Checked = configIniFile.IniReadBool("General", "TemporaryBuffer");
            chkSettingsGeneralSHA1.Checked = configIniFile.IniReadBool("General", "CheckSHA1");

            // Nomenclature
            //comboBoxSettingsNomenclatureLayoutFolder.SelectedIndex = configIniFile.IniReadInt("Nomenclature", "LayoutFolder");
            comboBoxSettingsNomenclatureAppointmentStyle.SelectedIndex = configIniFile.IniReadInt("Nomenclature", "AppointmentStyle");

            // Start

            // Titles
            chkGameTdbTXT.Checked = configIniFile.IniReadBool("Titles", "GameTDBTXT");
            chkGameTdbXML.Checked = configIniFile.IniReadBool("Titles", "GameTDBXML");
            chkGameCustomTitles.Checked = configIniFile.IniReadBool("Titles", "CustomTitles");
            textTitles.Text = configIniFile.IniReadString("Titles", "LocationTitles", "");
            textCustomTitles.Text = configIniFile.IniReadString("Titles", "LocationCustomTitles", "");

            // Covers
            //chkCoversBackup.Checked = configIniFile.IniReadBool("Covers", "BackupCovers");
            chkCoversSynchronizeDelete.Checked = configIniFile.IniReadBool("Covers", "DeleteCovers");
            chkCoversSynchronizeKeep.Checked = configIniFile.IniReadBool("Covers", "KeepCovers");
            chkEnableCoverTransfer.Checked = configIniFile.IniReadBool("Covers", "TransferCovers");
            chkCoversAutomaticDownload.Checked = configIniFile.IniReadBool("Covers", "CoversAutomaticDownload");
            chkCoversIncludeDisplayed.Checked = configIniFile.IniReadBool("Covers", "CoversIncludeDisplayed");
            rbCoverWiiFlow.Checked = configIniFile.IniReadBool("Covers", "WiiFlowCoverUSBLoader");
            rbCoverUSBLoaderGX.Checked = configIniFile.IniReadBool("Covers", "GXCoverUSBLoader");
            textBoxDirectoryCoverCache.Text = configIniFile.IniReadString("Covers", "CoverDirectoryCache", "");

            if (rbCoverWiiFlow.Checked)
            {
                textBoxDirectoryCoverDisc.Text = configIniFile.IniReadString("Covers", "WiiFlowCoverDirectoryDisc", "");
                textBoxDirectoryCover2D.Text = configIniFile.IniReadString("Covers", "WiiFlowCoverDirectory2D", "");
                textBoxDirectoryCover3D.Text = configIniFile.IniReadString("Covers", "WiiFlowCoverDirectory3D", "");
                textBoxDirectoryCoverFull.Text = configIniFile.IniReadString("Covers", "WiiFlowCoverDirectoryFull", "");
            }
            else
            {
                textBoxDirectoryCoverDisc.Text = configIniFile.IniReadString("Covers", "GXCoverDirectoryDisc", "");
                textBoxDirectoryCover2D.Text = configIniFile.IniReadString("Covers", "GXCoverDirectory2D", "");
                textBoxDirectoryCover3D.Text = configIniFile.IniReadString("Covers", "GXCoverDirectory3D", "");
                textBoxDirectoryCoverFull.Text = configIniFile.IniReadString("Covers", "GXCoverDirectoryFull", "");
            }

            // Downloads
            chkDownloadListTaskComplete.Checked = configIniFile.IniReadBool("Downloads", "ListTaskComplete");
            chkDownloadListTaskFailure.Checked = configIniFile.IniReadBool("Downloads", "ListTaskFailure");
            chkDownloadListTaskCanceled.Checked = configIniFile.IniReadBool("Downloads", "ListTaskCanceled");
            chkDownloadPreviewCovers.Checked = configIniFile.IniReadBool("Downloads", "PreviewCovers");

            // Emulators
            //txtDolphinPath.Text = configIniFile.IniReadString("Emulators", "DolphinPath", "");
            //rbDolphinD3D.Checked = configIniFile.IniReadBool("Emulators", "DolphinD3D");
            //rbDolphinOpenGL.Checked = configIniFile.IniReadBool("Emulators", "DolphinOpenGL");
            //rbDolphinHLE.Checked = configIniFile.IniReadBool("Emulators", "DolphinHLE");
            //rbDolphinLLE.Checked = configIniFile.IniReadBool("Emulators", "DolphinLLE");

            // Drives/DVD
            comboBoxDriversDVD.SelectedIndex = configIniFile.IniReadInt("DriversDVD", "DriveSpeedDVD");
        }

        // Botões
        private void BtnCoverDirectory_Click(object sender, EventArgs e)
        {
            ConfigFolderBrowserDialog();

            if (fbd1.ShowDialog() == DialogResult.OK)
            {
                textBoxDirectoryCoverCache.Text = fbd1.SelectedPath;
            }
            //coverDirectory = txtCoverDirectory.Text;
        }     

        private void BtnDirectoryCoverDisc_Click(object sender, EventArgs e)
        {
            ConfigFolderBrowserDialog();

            if (fbd1.ShowDialog() == DialogResult.OK)
            {
                textBoxDirectoryCoverDisc.Text = fbd1.SelectedPath;
            }
        }

        private void BtnDirectoryCover2D_Click(object sender, EventArgs e)
        {
            ConfigFolderBrowserDialog();

            if (fbd1.ShowDialog() == DialogResult.OK)
            {
                textBoxDirectoryCover2D.Text = fbd1.SelectedPath;
            }
        }

        private void BtnDirectoryCover3D_Click(object sender, EventArgs e)
        {
            ConfigFolderBrowserDialog();

            if (fbd1.ShowDialog() == DialogResult.OK)
            {
                textBoxDirectoryCover3D.Text = fbd1.SelectedPath;
            }
        }

        private void BtnDirectoryCoverFull_Click(object sender, EventArgs e)
        {
            ConfigFolderBrowserDialog();

            if (fbd1.ShowDialog() == DialogResult.OK)
            {
                textBoxDirectoryCoverFull.Text = fbd1.SelectedPath;
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSettingsSaveConfig_Click(object sender, EventArgs e)
        {
            SaveConfigFile();
        }
    }
}
