namespace CarPrice
{
    partial class frmCarCalc
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
            this.components = new System.ComponentModel.Container();
            this.chkPremiumStereo = new System.Windows.Forms.CheckBox();
            this.chkClearCoat = new System.Windows.Forms.CheckBox();
            this.chkBackupCamera = new System.Windows.Forms.CheckBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.chkLeather = new System.Windows.Forms.CheckBox();
            this.rdoSM = new System.Windows.Forms.RadioButton();
            this.rdoMED = new System.Windows.Forms.RadioButton();
            this.rdoLRG = new System.Windows.Forms.RadioButton();
            this.txtBasePrice = new System.Windows.Forms.TextBox();
            this.lblBasePrice = new System.Windows.Forms.Label();
            this.lblNewPrice = new System.Windows.Forms.Label();
            this.txtNewPrice = new System.Windows.Forms.TextBox();
            this.lblPayment = new System.Windows.Forms.Label();
            this.txtPayment = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.grpEngineSize = new System.Windows.Forms.GroupBox();
            this.grpEngineSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // chkPremiumStereo
            // 
            this.chkPremiumStereo.AutoSize = true;
            this.chkPremiumStereo.Location = new System.Drawing.Point(73, 109);
            this.chkPremiumStereo.Name = "chkPremiumStereo";
            this.chkPremiumStereo.Size = new System.Drawing.Size(198, 21);
            this.chkPremiumStereo.TabIndex = 0;
            this.chkPremiumStereo.Text = "Premium Stereo (Add 350)";
            this.chkPremiumStereo.UseVisualStyleBackColor = true;
            this.chkPremiumStereo.CheckedChanged += new System.EventHandler(this.chkPremiumStereo_CheckedChanged);
            // 
            // chkClearCoat
            // 
            this.chkClearCoat.AutoSize = true;
            this.chkClearCoat.Location = new System.Drawing.Point(73, 137);
            this.chkClearCoat.Name = "chkClearCoat";
            this.chkClearCoat.Size = new System.Drawing.Size(191, 21);
            this.chkClearCoat.TabIndex = 1;
            this.chkClearCoat.Text = "Clear Coat (Add 1200.00)";
            this.chkClearCoat.UseVisualStyleBackColor = true;
            this.chkClearCoat.CheckedChanged += new System.EventHandler(this.chkClearCoat_CheckedChanged);
            // 
            // chkBackupCamera
            // 
            this.chkBackupCamera.AutoSize = true;
            this.chkBackupCamera.Location = new System.Drawing.Point(73, 165);
            this.chkBackupCamera.Name = "chkBackupCamera";
            this.chkBackupCamera.Size = new System.Drawing.Size(197, 21);
            this.chkBackupCamera.TabIndex = 2;
            this.chkBackupCamera.Text = "Backup Camera (Add 800)";
            this.chkBackupCamera.UseVisualStyleBackColor = true;
            this.chkBackupCamera.CheckedChanged += new System.EventHandler(this.chkBackupCamera_CheckedChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(67, 4);
            // 
            // chkLeather
            // 
            this.chkLeather.AutoSize = true;
            this.chkLeather.Location = new System.Drawing.Point(73, 192);
            this.chkLeather.Name = "chkLeather";
            this.chkLeather.Size = new System.Drawing.Size(174, 21);
            this.chkLeather.TabIndex = 4;
            this.chkLeather.Text = "Leather (Add 1800.00)";
            this.chkLeather.UseVisualStyleBackColor = true;
            // 
            // rdoSM
            // 
            this.rdoSM.AutoSize = true;
            this.rdoSM.Location = new System.Drawing.Point(46, 21);
            this.rdoSM.Name = "rdoSM";
            this.rdoSM.Size = new System.Drawing.Size(132, 21);
            this.rdoSM.TabIndex = 5;
            this.rdoSM.TabStop = true;
            this.rdoSM.Text = "1.8 Liter (Add 0)";
            this.rdoSM.UseVisualStyleBackColor = true;
            this.rdoSM.CheckedChanged += new System.EventHandler(this.rdoSM_CheckedChanged);
            // 
            // rdoMED
            // 
            this.rdoMED.AutoSize = true;
            this.rdoMED.Location = new System.Drawing.Point(46, 48);
            this.rdoMED.Name = "rdoMED";
            this.rdoMED.Size = new System.Drawing.Size(156, 21);
            this.rdoMED.TabIndex = 6;
            this.rdoMED.TabStop = true;
            this.rdoMED.Text = "2.2 Liter (Add 1500)";
            this.rdoMED.UseVisualStyleBackColor = true;
            this.rdoMED.CheckedChanged += new System.EventHandler(this.rdoMED_CheckedChanged);
            // 
            // rdoLRG
            // 
            this.rdoLRG.AutoSize = true;
            this.rdoLRG.Location = new System.Drawing.Point(46, 73);
            this.rdoLRG.Name = "rdoLRG";
            this.rdoLRG.Size = new System.Drawing.Size(156, 21);
            this.rdoLRG.TabIndex = 7;
            this.rdoLRG.TabStop = true;
            this.rdoLRG.Text = "3.0 Liter (Add 2000)";
            this.rdoLRG.UseVisualStyleBackColor = true;
            this.rdoLRG.CheckedChanged += new System.EventHandler(this.rdoLRG_CheckedChanged);
            // 
            // txtBasePrice
            // 
            this.txtBasePrice.Location = new System.Drawing.Point(154, 8);
            this.txtBasePrice.Name = "txtBasePrice";
            this.txtBasePrice.Size = new System.Drawing.Size(100, 22);
            this.txtBasePrice.TabIndex = 8;
            // 
            // lblBasePrice
            // 
            this.lblBasePrice.AutoSize = true;
            this.lblBasePrice.Location = new System.Drawing.Point(50, 9);
            this.lblBasePrice.Name = "lblBasePrice";
            this.lblBasePrice.Size = new System.Drawing.Size(76, 17);
            this.lblBasePrice.TabIndex = 9;
            this.lblBasePrice.Text = "Base Price";
            // 
            // lblNewPrice
            // 
            this.lblNewPrice.AutoSize = true;
            this.lblNewPrice.Location = new System.Drawing.Point(357, 211);
            this.lblNewPrice.Name = "lblNewPrice";
            this.lblNewPrice.Size = new System.Drawing.Size(71, 17);
            this.lblNewPrice.TabIndex = 11;
            this.lblNewPrice.Text = "New Price";
            // 
            // txtNewPrice
            // 
            this.txtNewPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewPrice.Location = new System.Drawing.Point(349, 241);
            this.txtNewPrice.Name = "txtNewPrice";
            this.txtNewPrice.ReadOnly = true;
            this.txtNewPrice.Size = new System.Drawing.Size(181, 53);
            this.txtNewPrice.TabIndex = 10;
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Location = new System.Drawing.Point(365, 110);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(63, 17);
            this.lblPayment.TabIndex = 13;
            this.lblPayment.Text = "Payment";
            // 
            // txtPayment
            // 
            this.txtPayment.Location = new System.Drawing.Point(484, 110);
            this.txtPayment.Name = "txtPayment";
            this.txtPayment.Size = new System.Drawing.Size(100, 22);
            this.txtPayment.TabIndex = 12;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "0-500 - Ineligible",
            "500-600 - 12%",
            "600-650 - 6%",
            "650-720 - 4%",
            "Over 720 - 1.99%"});
            this.comboBox1.Location = new System.Drawing.Point(349, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.Text = "Credit Score";
            // 
            // grpEngineSize
            // 
            this.grpEngineSize.Controls.Add(this.rdoSM);
            this.grpEngineSize.Controls.Add(this.rdoMED);
            this.grpEngineSize.Controls.Add(this.rdoLRG);
            this.grpEngineSize.Location = new System.Drawing.Point(70, 234);
            this.grpEngineSize.Name = "grpEngineSize";
            this.grpEngineSize.Size = new System.Drawing.Size(228, 123);
            this.grpEngineSize.TabIndex = 15;
            this.grpEngineSize.TabStop = false;
            this.grpEngineSize.Text = "Engine Size";
            // 
            // frmCarCalc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 446);
            this.Controls.Add(this.grpEngineSize);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.txtPayment);
            this.Controls.Add(this.lblNewPrice);
            this.Controls.Add(this.txtNewPrice);
            this.Controls.Add(this.lblBasePrice);
            this.Controls.Add(this.txtBasePrice);
            this.Controls.Add(this.chkLeather);
            this.Controls.Add(this.chkBackupCamera);
            this.Controls.Add(this.chkClearCoat);
            this.Controls.Add(this.chkPremiumStereo);
            this.Name = "frmCarCalc";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmCarCalc_Load);
            this.grpEngineSize.ResumeLayout(false);
            this.grpEngineSize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkPremiumStereo;
        private System.Windows.Forms.CheckBox chkClearCoat;
        private System.Windows.Forms.CheckBox chkBackupCamera;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.CheckBox chkLeather;
        private System.Windows.Forms.RadioButton rdoSM;
        private System.Windows.Forms.RadioButton rdoMED;
        private System.Windows.Forms.RadioButton rdoLRG;
        private System.Windows.Forms.TextBox txtBasePrice;
        private System.Windows.Forms.Label lblBasePrice;
        private System.Windows.Forms.Label lblNewPrice;
        private System.Windows.Forms.TextBox txtNewPrice;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.TextBox txtPayment;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox grpEngineSize;
    }
}

