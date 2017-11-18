namespace FileIO
{
    partial class frmFileIO
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
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.txtFilename = new System.Windows.Forms.TextBox();
            this.txtSafeFilename = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.lblSafeFileName = new System.Windows.Forms.Label();
            this.txtSaveFilename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(32, 21);
            this.btnOpenFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(118, 50);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Show Open File Dialog";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // txtFilename
            // 
            this.txtFilename.Location = new System.Drawing.Point(250, 38);
            this.txtFilename.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFilename.Name = "txtFilename";
            this.txtFilename.ReadOnly = true;
            this.txtFilename.Size = new System.Drawing.Size(216, 21);
            this.txtFilename.TabIndex = 1;
            // 
            // txtSafeFilename
            // 
            this.txtSafeFilename.Location = new System.Drawing.Point(250, 72);
            this.txtSafeFilename.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSafeFilename.Name = "txtSafeFilename";
            this.txtSafeFilename.ReadOnly = true;
            this.txtSafeFilename.Size = new System.Drawing.Size(132, 21);
            this.txtSafeFilename.TabIndex = 2;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(32, 135);
            this.txtArea.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtArea.Multiline = true;
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(314, 126);
            this.txtArea.TabIndex = 3;
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(32, 292);
            this.btnSaveFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(92, 22);
            this.btnSaveFile.TabIndex = 4;
            this.btnSaveFile.Text = "Save File To:";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // lblSafeFileName
            // 
            this.lblSafeFileName.AutoSize = true;
            this.lblSafeFileName.Location = new System.Drawing.Point(248, 57);
            this.lblSafeFileName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSafeFileName.Name = "lblSafeFileName";
            this.lblSafeFileName.Size = new System.Drawing.Size(89, 12);
            this.lblSafeFileName.TabIndex = 5;
            this.lblSafeFileName.Text = "Safe Filename:";
            // 
            // txtSaveFilename
            // 
            this.txtSaveFilename.Location = new System.Drawing.Point(140, 292);
            this.txtSaveFilename.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSaveFilename.Name = "txtSaveFilename";
            this.txtSaveFilename.Size = new System.Drawing.Size(297, 21);
            this.txtSaveFilename.TabIndex = 6;
            this.txtSaveFilename.Text = "c:/textfiles/";
            this.txtSaveFilename.TextChanged += new System.EventHandler(this.txtSaveFilename_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(248, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "Fully Qualified Filename:";
            // 
            // frmFileIO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 336);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSaveFilename);
            this.Controls.Add(this.lblSafeFileName);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtSafeFilename);
            this.Controls.Add(this.txtFilename);
            this.Controls.Add(this.btnOpenFile);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmFileIO";
            this.Text = "File IO";
            this.Load += new System.EventHandler(this.frmFileIO_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.TextBox txtFilename;
        private System.Windows.Forms.TextBox txtSafeFilename;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.Label lblSafeFileName;
        private System.Windows.Forms.TextBox txtSaveFilename;
        private System.Windows.Forms.Label label1;

    }
}

