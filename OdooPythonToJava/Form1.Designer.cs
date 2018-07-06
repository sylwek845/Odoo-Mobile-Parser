namespace OdooPythonToJava
{
    partial class Form1
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
            this.txtCVS = new System.Windows.Forms.TextBox();
            this.btnPaste = new System.Windows.Forms.Button();
            this.txtJava = new System.Windows.Forms.TextBox();
            this.btnParse = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.txtFolderName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.txtProjectPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ofd1 = new System.Windows.Forms.OpenFileDialog();
            this.txtPackageName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSProvider = new System.Windows.Forms.Button();
            this.btnSService = new System.Windows.Forms.Button();
            this.btnSManifest = new System.Windows.Forms.Button();
            this.btnSOModel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSAdapter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCVS
            // 
            this.txtCVS.Location = new System.Drawing.Point(26, 40);
            this.txtCVS.Name = "txtCVS";
            this.txtCVS.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtCVS.Size = new System.Drawing.Size(737, 20);
            this.txtCVS.TabIndex = 1;
            this.txtCVS.Click += new System.EventHandler(this.TxtPython_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.Location = new System.Drawing.Point(769, 40);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(75, 20);
            this.btnPaste.TabIndex = 2;
            this.btnPaste.Text = "Paste";
            this.btnPaste.UseVisualStyleBackColor = true;
            this.btnPaste.Click += new System.EventHandler(this.BtnPaste_Click);
            // 
            // txtJava
            // 
            this.txtJava.Location = new System.Drawing.Point(26, 75);
            this.txtJava.Multiline = true;
            this.txtJava.Name = "txtJava";
            this.txtJava.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtJava.Size = new System.Drawing.Size(818, 237);
            this.txtJava.TabIndex = 4;
            // 
            // btnParse
            // 
            this.btnParse.Enabled = false;
            this.btnParse.Location = new System.Drawing.Point(1057, 221);
            this.btnParse.Name = "btnParse";
            this.btnParse.Size = new System.Drawing.Size(103, 33);
            this.btnParse.TabIndex = 5;
            this.btnParse.Text = "Parse";
            this.btnParse.UseVisualStyleBackColor = true;
            this.btnParse.Click += new System.EventHandler(this.BtnParse_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(769, 285);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 27);
            this.btnCopy.TabIndex = 6;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
            // 
            // txtFolderName
            // 
            this.txtFolderName.Location = new System.Drawing.Point(882, 91);
            this.txtFolderName.Name = "txtFolderName";
            this.txtFolderName.Size = new System.Drawing.Size(278, 20);
            this.txtFolderName.TabIndex = 7;
            this.txtFolderName.Click += new System.EventHandler(this.TxtFolderName_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(879, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Parent Folder Name. eg HR";
            // 
            // txtProjectPath
            // 
            this.txtProjectPath.Location = new System.Drawing.Point(882, 40);
            this.txtProjectPath.Name = "txtProjectPath";
            this.txtProjectPath.ReadOnly = true;
            this.txtProjectPath.Size = new System.Drawing.Size(278, 20);
            this.txtProjectPath.TabIndex = 9;
            this.txtProjectPath.Text = "C:\\Users\\Sylwek\\StudioProjects\\Odoo-Mobile";
            this.txtProjectPath.Click += new System.EventHandler(this.TextBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(879, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Project Path";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Module CVS Path";
            // 
            // ofd1
            // 
            this.ofd1.FileName = "openFileDialog1";
            this.ofd1.Filter = "CSV files|*.csv";
            // 
            // txtPackageName
            // 
            this.txtPackageName.Location = new System.Drawing.Point(882, 129);
            this.txtPackageName.Name = "txtPackageName";
            this.txtPackageName.ReadOnly = true;
            this.txtPackageName.Size = new System.Drawing.Size(278, 20);
            this.txtPackageName.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(879, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Project Package Name";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1057, 168);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(103, 33);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSProvider
            // 
            this.btnSProvider.Location = new System.Drawing.Point(882, 226);
            this.btnSProvider.Name = "btnSProvider";
            this.btnSProvider.Size = new System.Drawing.Size(114, 23);
            this.btnSProvider.TabIndex = 15;
            this.btnSProvider.Text = "Show Provider";
            this.btnSProvider.UseVisualStyleBackColor = true;
            this.btnSProvider.Click += new System.EventHandler(this.btnSProvider_Click);
            // 
            // btnSService
            // 
            this.btnSService.Location = new System.Drawing.Point(882, 197);
            this.btnSService.Name = "btnSService";
            this.btnSService.Size = new System.Drawing.Size(114, 23);
            this.btnSService.TabIndex = 16;
            this.btnSService.Text = "Show Service";
            this.btnSService.UseVisualStyleBackColor = true;
            this.btnSService.Click += new System.EventHandler(this.btnSService_Click);
            // 
            // btnSManifest
            // 
            this.btnSManifest.Location = new System.Drawing.Point(882, 255);
            this.btnSManifest.Name = "btnSManifest";
            this.btnSManifest.Size = new System.Drawing.Size(114, 23);
            this.btnSManifest.TabIndex = 17;
            this.btnSManifest.Text = "Show Manifest Data";
            this.btnSManifest.UseVisualStyleBackColor = true;
            this.btnSManifest.Click += new System.EventHandler(this.btnSManifest_Click);
            // 
            // btnSOModel
            // 
            this.btnSOModel.Location = new System.Drawing.Point(882, 168);
            this.btnSOModel.Name = "btnSOModel";
            this.btnSOModel.Size = new System.Drawing.Size(114, 23);
            this.btnSOModel.TabIndex = 18;
            this.btnSOModel.Text = "Show oModel";
            this.btnSOModel.UseVisualStyleBackColor = true;
            this.btnSOModel.Click += new System.EventHandler(this.btnSOModel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(1057, 275);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 33);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save Files";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSAdapter
            // 
            this.btnSAdapter.Location = new System.Drawing.Point(882, 285);
            this.btnSAdapter.Name = "btnSAdapter";
            this.btnSAdapter.Size = new System.Drawing.Size(114, 23);
            this.btnSAdapter.TabIndex = 20;
            this.btnSAdapter.Text = "Show XML Adapter";
            this.btnSAdapter.UseVisualStyleBackColor = true;
            this.btnSAdapter.Click += new System.EventHandler(this.btnSAdapter_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1191, 340);
            this.Controls.Add(this.btnSAdapter);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSOModel);
            this.Controls.Add(this.btnSManifest);
            this.Controls.Add(this.btnSService);
            this.Controls.Add(this.btnSProvider);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPackageName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProjectPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFolderName);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnParse);
            this.Controls.Add(this.txtJava);
            this.Controls.Add(this.btnPaste);
            this.Controls.Add(this.txtCVS);
            this.Name = "Form1";
            this.Text = "Odoo Mobile Parser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtCVS;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.TextBox txtJava;
        private System.Windows.Forms.Button btnParse;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.TextBox txtFolderName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog fbd;
        private System.Windows.Forms.TextBox txtProjectPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog ofd1;
        private System.Windows.Forms.TextBox txtPackageName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnSProvider;
        private System.Windows.Forms.Button btnSService;
        private System.Windows.Forms.Button btnSManifest;
        private System.Windows.Forms.Button btnSOModel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSAdapter;
    }
}

