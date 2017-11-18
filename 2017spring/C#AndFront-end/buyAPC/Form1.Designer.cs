namespace buyAPC
{
    partial class frmPCWarehouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPCWarehouse));
            this.lblHeading = new System.Windows.Forms.Label();
            this.cmbCPUType = new System.Windows.Forms.ComboBox();
            this.cmbStorage = new System.Windows.Forms.ComboBox();
            this.chkCDROM = new System.Windows.Forms.CheckBox();
            this.chkHDMI = new System.Windows.Forms.CheckBox();
            this.chkDVD = new System.Windows.Forms.CheckBox();
            this.chkESATA = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMenu = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.lblStorageHeading = new System.Windows.Forms.Label();
            this.lblMenu = new System.Windows.Forms.Label();
            this.lblInvoice = new System.Windows.Forms.Label();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Location = new System.Drawing.Point(146, 13);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(143, 17);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Dan\'s PC Warehouse";
            // 
            // cmbCPUType
            // 
            this.cmbCPUType.FormattingEnabled = true;
            this.cmbCPUType.Items.AddRange(new object[] {
            "AMD",
            "Intel",
            "ARM",
            "Snapdragon",
            "RISC"});
            this.cmbCPUType.Location = new System.Drawing.Point(107, 206);
            this.cmbCPUType.Name = "cmbCPUType";
            this.cmbCPUType.Size = new System.Drawing.Size(121, 24);
            this.cmbCPUType.TabIndex = 1;
            this.cmbCPUType.Text = "CPU";
            // 
            // cmbStorage
            // 
            this.cmbStorage.FormattingEnabled = true;
            this.cmbStorage.Location = new System.Drawing.Point(36, 82);
            this.cmbStorage.Name = "cmbStorage";
            this.cmbStorage.Size = new System.Drawing.Size(121, 24);
            this.cmbStorage.TabIndex = 2;
            // 
            // chkCDROM
            // 
            this.chkCDROM.AutoSize = true;
            this.chkCDROM.Location = new System.Drawing.Point(449, 206);
            this.chkCDROM.Name = "chkCDROM";
            this.chkCDROM.Size = new System.Drawing.Size(81, 21);
            this.chkCDROM.TabIndex = 3;
            this.chkCDROM.Text = "CDROM";
            this.chkCDROM.UseVisualStyleBackColor = true;
            // 
            // chkHDMI
            // 
            this.chkHDMI.AutoSize = true;
            this.chkHDMI.Location = new System.Drawing.Point(449, 233);
            this.chkHDMI.Name = "chkHDMI";
            this.chkHDMI.Size = new System.Drawing.Size(64, 21);
            this.chkHDMI.TabIndex = 4;
            this.chkHDMI.Text = "HDMI";
            this.chkHDMI.UseVisualStyleBackColor = true;
            // 
            // chkDVD
            // 
            this.chkDVD.AutoSize = true;
            this.chkDVD.Location = new System.Drawing.Point(449, 260);
            this.chkDVD.Name = "chkDVD";
            this.chkDVD.Size = new System.Drawing.Size(59, 21);
            this.chkDVD.TabIndex = 5;
            this.chkDVD.Text = "DVD";
            this.chkDVD.UseVisualStyleBackColor = true;
            // 
            // chkESATA
            // 
            this.chkESATA.AutoSize = true;
            this.chkESATA.Location = new System.Drawing.Point(449, 287);
            this.chkESATA.Name = "chkESATA";
            this.chkESATA.Size = new System.Drawing.Size(75, 21);
            this.chkESATA.TabIndex = 6;
            this.chkESATA.Text = "ESATA";
            this.chkESATA.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(23, 27);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(94, 21);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Full Tower";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(23, 54);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(97, 21);
            this.radioButton2.TabIndex = 8;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Mini Tower";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(21, 81);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(77, 21);
            this.radioButton3.TabIndex = 9;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Slimline";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Location = new System.Drawing.Point(255, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 115);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Form Factor";
            // 
            // txtMenu
            // 
            this.txtMenu.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMenu.Location = new System.Drawing.Point(172, 82);
            this.txtMenu.Multiline = true;
            this.txtMenu.Name = "txtMenu";
            this.txtMenu.ReadOnly = true;
            this.txtMenu.Size = new System.Drawing.Size(203, 101);
            this.txtMenu.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(541, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 49);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblStorageHeading
            // 
            this.lblStorageHeading.AutoSize = true;
            this.lblStorageHeading.Location = new System.Drawing.Point(36, 55);
            this.lblStorageHeading.Name = "lblStorageHeading";
            this.lblStorageHeading.Size = new System.Drawing.Size(94, 17);
            this.lblStorageHeading.TabIndex = 13;
            this.lblStorageHeading.Text = "Storage Type";
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(400, 82);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(55, 14);
            this.lblMenu.TabIndex = 14;
            this.lblMenu.Text = "label1";
            // 
            // lblInvoice
            // 
            this.lblInvoice.AutoSize = true;
            this.lblInvoice.ForeColor = System.Drawing.Color.Black;
            this.lblInvoice.Location = new System.Drawing.Point(172, 390);
            this.lblInvoice.Name = "lblInvoice";
            this.lblInvoice.Size = new System.Drawing.Size(46, 17);
            this.lblInvoice.TabIndex = 15;
            this.lblInvoice.Text = "label1";
            // 
            // btnInvoice
            // 
            this.btnInvoice.CausesValidation = false;
            this.btnInvoice.Location = new System.Drawing.Point(152, 449);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(75, 23);
            this.btnInvoice.TabIndex = 16;
            this.btnInvoice.Text = "Invoice";
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // frmPCWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(675, 537);
            this.Controls.Add(this.btnInvoice);
            this.Controls.Add(this.lblInvoice);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.lblStorageHeading);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtMenu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkESATA);
            this.Controls.Add(this.chkDVD);
            this.Controls.Add(this.chkHDMI);
            this.Controls.Add(this.chkCDROM);
            this.Controls.Add(this.cmbStorage);
            this.Controls.Add(this.cmbCPUType);
            this.Controls.Add(this.lblHeading);
            this.Name = "frmPCWarehouse";
            this.Text = "Dan\'s PC Warehouse";
            this.Load += new System.EventHandler(this.frmPCWarehouse_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.ComboBox cmbCPUType;
        private System.Windows.Forms.ComboBox cmbStorage;
        private System.Windows.Forms.CheckBox chkCDROM;
        private System.Windows.Forms.CheckBox chkHDMI;
        private System.Windows.Forms.CheckBox chkDVD;
        private System.Windows.Forms.CheckBox chkESATA;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Label lblStorageHeading;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.Label lblInvoice;
        private System.Windows.Forms.Button btnInvoice;
    }
}

