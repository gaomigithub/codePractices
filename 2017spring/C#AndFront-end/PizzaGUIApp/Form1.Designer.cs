namespace PizzaGUIApp
{
    partial class frmPizzaApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPizzaApp));
            this.lblHeading = new System.Windows.Forms.Label();
            this.cboSizes = new System.Windows.Forms.ComboBox();
            this.btnInvoice = new System.Windows.Forms.Button();
            this.lblInvoice = new System.Windows.Forms.Label();
            this.rdoThin = new System.Windows.Forms.RadioButton();
            this.rdoThick = new System.Windows.Forms.RadioButton();
            this.rdoStuffed = new System.Windows.Forms.RadioButton();
            this.grpCrustStyle = new System.Windows.Forms.GroupBox();
            this.chkSausage = new System.Windows.Forms.CheckBox();
            this.chkPeppers = new System.Windows.Forms.CheckBox();
            this.chkAnchovies = new System.Windows.Forms.CheckBox();
            this.chkMashroom = new System.Windows.Forms.CheckBox();
            this.chkOnions = new System.Windows.Forms.CheckBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblMenu = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.picPIzza = new System.Windows.Forms.PictureBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chkDelivery = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTip = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpCrustStyle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPIzza)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeading.Location = new System.Drawing.Point(298, 9);
            this.lblHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(233, 45);
            this.lblHeading.TabIndex = 1;
            this.lblHeading.Text = "Mi\'s Pizza Joint";
            this.lblHeading.Click += new System.EventHandler(this.lblHeading_Click);
            // 
            // cboSizes
            // 
            this.cboSizes.Font = new System.Drawing.Font("Lucida Console", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSizes.FormattingEnabled = true;
            this.cboSizes.Location = new System.Drawing.Point(596, 215);
            this.cboSizes.Margin = new System.Windows.Forms.Padding(2);
            this.cboSizes.Name = "cboSizes";
            this.cboSizes.Size = new System.Drawing.Size(218, 22);
            this.cboSizes.TabIndex = 4;
            // 
            // btnInvoice
            // 
            this.btnInvoice.Location = new System.Drawing.Point(598, 506);
            this.btnInvoice.Margin = new System.Windows.Forms.Padding(2);
            this.btnInvoice.Name = "btnInvoice";
            this.btnInvoice.Size = new System.Drawing.Size(76, 24);
            this.btnInvoice.TabIndex = 5;
            this.btnInvoice.Text = "Invoice";
            this.btnInvoice.UseVisualStyleBackColor = true;
            this.btnInvoice.Click += new System.EventHandler(this.btnInvoice_Click);
            // 
            // lblInvoice
            // 
            this.lblInvoice.AutoSize = true;
            this.lblInvoice.Font = new System.Drawing.Font("Lucida Console", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvoice.Location = new System.Drawing.Point(11, 258);
            this.lblInvoice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInvoice.Name = "lblInvoice";
            this.lblInvoice.Size = new System.Drawing.Size(82, 11);
            this.lblInvoice.TabIndex = 6;
            this.lblInvoice.Text = "None taken.";
            // 
            // rdoThin
            // 
            this.rdoThin.AutoSize = true;
            this.rdoThin.Location = new System.Drawing.Point(23, 16);
            this.rdoThin.Margin = new System.Windows.Forms.Padding(2);
            this.rdoThin.Name = "rdoThin";
            this.rdoThin.Size = new System.Drawing.Size(47, 16);
            this.rdoThin.TabIndex = 7;
            this.rdoThin.TabStop = true;
            this.rdoThin.Text = "Thin";
            this.rdoThin.UseVisualStyleBackColor = true;
            // 
            // rdoThick
            // 
            this.rdoThick.AutoSize = true;
            this.rdoThick.Location = new System.Drawing.Point(23, 36);
            this.rdoThick.Margin = new System.Windows.Forms.Padding(2);
            this.rdoThick.Name = "rdoThick";
            this.rdoThick.Size = new System.Drawing.Size(53, 16);
            this.rdoThick.TabIndex = 8;
            this.rdoThick.TabStop = true;
            this.rdoThick.Text = "Thick";
            this.rdoThick.UseVisualStyleBackColor = true;
            // 
            // rdoStuffed
            // 
            this.rdoStuffed.AutoSize = true;
            this.rdoStuffed.Location = new System.Drawing.Point(23, 56);
            this.rdoStuffed.Margin = new System.Windows.Forms.Padding(2);
            this.rdoStuffed.Name = "rdoStuffed";
            this.rdoStuffed.Size = new System.Drawing.Size(65, 16);
            this.rdoStuffed.TabIndex = 9;
            this.rdoStuffed.TabStop = true;
            this.rdoStuffed.Text = "Stuffed";
            this.rdoStuffed.UseVisualStyleBackColor = true;
            // 
            // grpCrustStyle
            // 
            this.grpCrustStyle.Controls.Add(this.rdoThin);
            this.grpCrustStyle.Controls.Add(this.rdoStuffed);
            this.grpCrustStyle.Controls.Add(this.rdoThick);
            this.grpCrustStyle.Location = new System.Drawing.Point(684, 333);
            this.grpCrustStyle.Margin = new System.Windows.Forms.Padding(2);
            this.grpCrustStyle.Name = "grpCrustStyle";
            this.grpCrustStyle.Padding = new System.Windows.Forms.Padding(2);
            this.grpCrustStyle.Size = new System.Drawing.Size(112, 83);
            this.grpCrustStyle.TabIndex = 10;
            this.grpCrustStyle.TabStop = false;
            this.grpCrustStyle.Text = "Crust Style";
            // 
            // chkSausage
            // 
            this.chkSausage.AutoSize = true;
            this.chkSausage.Location = new System.Drawing.Point(596, 319);
            this.chkSausage.Margin = new System.Windows.Forms.Padding(2);
            this.chkSausage.Name = "chkSausage";
            this.chkSausage.Size = new System.Drawing.Size(66, 16);
            this.chkSausage.TabIndex = 11;
            this.chkSausage.Text = "Sausage";
            this.chkSausage.UseVisualStyleBackColor = true;
            // 
            // chkPeppers
            // 
            this.chkPeppers.AutoSize = true;
            this.chkPeppers.Location = new System.Drawing.Point(596, 339);
            this.chkPeppers.Margin = new System.Windows.Forms.Padding(2);
            this.chkPeppers.Name = "chkPeppers";
            this.chkPeppers.Size = new System.Drawing.Size(66, 16);
            this.chkPeppers.TabIndex = 12;
            this.chkPeppers.Text = "Peppers";
            this.chkPeppers.UseVisualStyleBackColor = true;
            // 
            // chkAnchovies
            // 
            this.chkAnchovies.AutoSize = true;
            this.chkAnchovies.Location = new System.Drawing.Point(596, 379);
            this.chkAnchovies.Margin = new System.Windows.Forms.Padding(2);
            this.chkAnchovies.Name = "chkAnchovies";
            this.chkAnchovies.Size = new System.Drawing.Size(78, 16);
            this.chkAnchovies.TabIndex = 13;
            this.chkAnchovies.Text = "Anchovies";
            this.chkAnchovies.UseVisualStyleBackColor = true;
            this.chkAnchovies.CheckedChanged += new System.EventHandler(this.chkAnchovies_CheckedChanged);
            // 
            // chkMashroom
            // 
            this.chkMashroom.AutoSize = true;
            this.chkMashroom.Location = new System.Drawing.Point(596, 400);
            this.chkMashroom.Margin = new System.Windows.Forms.Padding(2);
            this.chkMashroom.Name = "chkMashroom";
            this.chkMashroom.Size = new System.Drawing.Size(72, 16);
            this.chkMashroom.TabIndex = 14;
            this.chkMashroom.Text = "Mashroom";
            this.chkMashroom.UseVisualStyleBackColor = true;
            // 
            // chkOnions
            // 
            this.chkOnions.AutoSize = true;
            this.chkOnions.Location = new System.Drawing.Point(596, 359);
            this.chkOnions.Margin = new System.Windows.Forms.Padding(2);
            this.chkOnions.Name = "chkOnions";
            this.chkOnions.Size = new System.Drawing.Size(60, 16);
            this.chkOnions.TabIndex = 15;
            this.chkOnions.Text = "Onions";
            this.chkOnions.UseVisualStyleBackColor = true;
            this.chkOnions.CheckedChanged += new System.EventHandler(this.chkOnions_CheckedChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(724, 506);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(74, 24);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblMenu
            // 
            this.lblMenu.AutoSize = true;
            this.lblMenu.Font = new System.Drawing.Font("Lucida Console", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMenu.Location = new System.Drawing.Point(470, 54);
            this.lblMenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMenu.Name = "lblMenu";
            this.lblMenu.Size = new System.Drawing.Size(61, 15);
            this.lblMenu.TabIndex = 3;
            this.lblMenu.Text = "label1";
            this.lblMenu.Click += new System.EventHandler(this.lblMenu_Click_1);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // picPIzza
            // 
            this.picPIzza.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picPIzza.Image = ((System.Drawing.Image)(resources.GetObject("picPIzza.Image")));
            this.picPIzza.Location = new System.Drawing.Point(-37, 30);
            this.picPIzza.Margin = new System.Windows.Forms.Padding(2);
            this.picPIzza.Name = "picPIzza";
            this.picPIzza.Size = new System.Drawing.Size(355, 158);
            this.picPIzza.TabIndex = 0;
            this.picPIzza.TabStop = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(12, 444);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(100, 21);
            this.txtTotal.TabIndex = 17;
            this.txtTotal.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(12, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "Your Pizza Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(12, 415);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 12);
            this.label2.TabIndex = 19;
            this.label2.Text = "Your Total";
            // 
            // chkDelivery
            // 
            this.chkDelivery.AutoSize = true;
            this.chkDelivery.Location = new System.Drawing.Point(596, 475);
            this.chkDelivery.Name = "chkDelivery";
            this.chkDelivery.Size = new System.Drawing.Size(144, 16);
            this.chkDelivery.TabIndex = 20;
            this.chkDelivery.Text = "Need Delivery ( $2 )";
            this.chkDelivery.UseVisualStyleBackColor = true;
            this.chkDelivery.CheckedChanged += new System.EventHandler(this.chkDelivery_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(594, 427);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 12);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tip";
            // 
            // txtTip
            // 
            this.txtTip.Location = new System.Drawing.Point(596, 444);
            this.txtTip.Name = "txtTip";
            this.txtTip.Size = new System.Drawing.Size(100, 21);
            this.txtTip.TabIndex = 22;
            this.txtTip.TextChanged += new System.EventHandler(this.txtTotal_TextChanged);
            this.txtTip.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTip_KeyPress);
            // 
            // frmPizzaApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(831, 566);
            this.Controls.Add(this.txtTip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chkDelivery);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.chkOnions);
            this.Controls.Add(this.chkMashroom);
            this.Controls.Add(this.chkAnchovies);
            this.Controls.Add(this.chkPeppers);
            this.Controls.Add(this.chkSausage);
            this.Controls.Add(this.grpCrustStyle);
            this.Controls.Add(this.lblInvoice);
            this.Controls.Add(this.btnInvoice);
            this.Controls.Add(this.cboSizes);
            this.Controls.Add(this.lblMenu);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.picPIzza);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmPizzaApp";
            this.Text = "Pizza Application";
            this.Load += new System.EventHandler(this.frmPizzaApp_Load);
            this.grpCrustStyle.ResumeLayout(false);
            this.grpCrustStyle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPIzza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.ComboBox cboSizes;
        private System.Windows.Forms.Button btnInvoice;
        private System.Windows.Forms.Label lblInvoice;
        private System.Windows.Forms.RadioButton rdoThin;
        private System.Windows.Forms.RadioButton rdoThick;
        private System.Windows.Forms.RadioButton rdoStuffed;
        private System.Windows.Forms.GroupBox grpCrustStyle;
        private System.Windows.Forms.CheckBox chkSausage;
        private System.Windows.Forms.CheckBox chkPeppers;
        private System.Windows.Forms.CheckBox chkAnchovies;
        private System.Windows.Forms.CheckBox chkMashroom;
        private System.Windows.Forms.CheckBox chkOnions;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblMenu;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox picPIzza;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkDelivery;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTip;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}

