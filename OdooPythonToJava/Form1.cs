using OdooPythonToJava.Files_Generators;
using OdooPythonToJava.Wrappers;
using OdooPythonToJava.Wrappers.Generators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OdooPythonToJava
{
    public partial class Form1 : Form
    {
        private string xmlAdapter, xmlManifest, SyncService, SyncProvider,OModel = "";
        ConfigData config = ConfigData.GetConfigData();
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            txtJava.Text = "";
            txtCVS.Text = "";
        }

        private void BtnPaste_Click(object sender, EventArgs e)
        {
            txtCVS.Text = Clipboard.GetText();
        }

        private void BtnCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtJava.Text);
        }

        private void BtnParse_Click(object sender, EventArgs e)
        {
            if(txtCVS.Text == String.Empty)
            {
                MessageBox.Show("CVS Path Cannot be Empty!");
            }
            else
            {            
            try
            {               
                OModel = new ModuleWrapper(txtCVS.Text, config).Parse();
                txtJava.Text = OModel;
                xmlAdapter = new XMLAdapterGenerator(config).Generate();
                SyncProvider = new SyncProviderGenerator(config).Generate();
                SyncService = new SyncServiceGenerator(config).Generate();
                xmlManifest = new ManifestSyncData(config).Generate();
                btnSave.Enabled = true;

            }
            catch (Exception) { btnParse.Enabled = false; }
            }
        }

       
        private void TextBox1_Click(object sender, EventArgs e)
        {
            OpenFolderDialog();
           
            

        }
        private void OpenFolderDialog()
        {
            DialogResult result = fbd.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
            {     
                txtProjectPath.Text = fbd.SelectedPath;
               
            }
        }

        private void btnSAdapter_Click(object sender, EventArgs e)
        {
            txtJava.Text = xmlAdapter;
        }

        private void btnSService_Click(object sender, EventArgs e)
        {
            txtJava.Text = SyncService;
        }

        private void btnSProvider_Click(object sender, EventArgs e)
        {
            txtJava.Text = SyncProvider;
        }

        private void btnSManifest_Click(object sender, EventArgs e)
        {
            txtJava.Text = xmlManifest;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFiles save = new SaveFiles(config);
            save.OModel = OModel;
            save.SyncProvider = SyncProvider;
            save.SyncService = SyncService;
            save.XmlAdapter = xmlAdapter;
            save.SaveData();
        }

        private void TxtPython_Click(object sender, EventArgs e)
        {
            DialogResult result = ofd1.ShowDialog();
            if(result == DialogResult.OK && !string.IsNullOrWhiteSpace(ofd1.FileName))
            {
                txtCVS.Text = ofd1.FileName;
            }
        }

        private void TxtFolderName_Click(object sender, EventArgs e)
        {
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtProjectPath.Text == String.Empty || txtFolderName.Text == String.Empty)
            {
                MessageBox.Show("Parent Folder and Project Path Cannot be Empty!");
            }
            else
            {
                try
                {
                    config.ParentFolder = txtProjectPath.Text;
                    config.TargetFolder = txtFolderName.Text;
                    ReadFolders readFolders = new ReadFolders(config);
                    readFolders.ReadPackageName();
                    txtPackageName.Text = config.PackageName;
                    config.Authority = config.PackageName + ".addons." + txtFolderName.Text;
                    config.IsAuthorityUpdated = false;
                    btnParse.Enabled = true;
                }
                catch (Exception)
                {

                }
            }
        }

        private void btnSOModel_Click(object sender, EventArgs e)
        {
            txtJava.Text = OModel;
        }
    }
}
