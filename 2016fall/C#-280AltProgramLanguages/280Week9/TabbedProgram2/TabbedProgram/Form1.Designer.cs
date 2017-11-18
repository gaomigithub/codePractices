namespace TabbedProgram
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.picFace = new System.Windows.Forms.PictureBox();
            this.btnChangeFace = new System.Windows.Forms.Button();
            this.btnSpin = new System.Windows.Forms.Button();
            this.txtSpinNum = new System.Windows.Forms.TextBox();
            this.txtDeckBefore = new System.Windows.Forms.TextBox();
            this.txtDeckAfter = new System.Windows.Forms.TextBox();
            this.btnShuffle = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(42, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(549, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnShuffle);
            this.tabPage2.Controls.Add(this.txtDeckAfter);
            this.tabPage2.Controls.Add(this.txtDeckBefore);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(541, 421);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Poker";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(541, 421);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Roulette";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(541, 421);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Croquet";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button1);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(541, 421);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Archery";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(128, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtSpinNum);
            this.tabPage1.Controls.Add(this.btnSpin);
            this.tabPage1.Controls.Add(this.btnChangeFace);
            this.tabPage1.Controls.Add(this.picFace);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(541, 421);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Slots";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // picFace
            // 
            this.picFace.Location = new System.Drawing.Point(98, 24);
            this.picFace.Name = "picFace";
            this.picFace.Size = new System.Drawing.Size(322, 299);
            this.picFace.TabIndex = 0;
            this.picFace.TabStop = false;
            // 
            // btnChangeFace
            // 
            this.btnChangeFace.Location = new System.Drawing.Point(98, 349);
            this.btnChangeFace.Name = "btnChangeFace";
            this.btnChangeFace.Size = new System.Drawing.Size(111, 47);
            this.btnChangeFace.TabIndex = 1;
            this.btnChangeFace.Text = "Change Face";
            this.btnChangeFace.UseVisualStyleBackColor = true;
            this.btnChangeFace.Click += new System.EventHandler(this.btnChangeFace_Click);
            // 
            // btnSpin
            // 
            this.btnSpin.Location = new System.Drawing.Point(281, 349);
            this.btnSpin.Name = "btnSpin";
            this.btnSpin.Size = new System.Drawing.Size(111, 47);
            this.btnSpin.TabIndex = 2;
            this.btnSpin.Text = "Spin";
            this.btnSpin.UseVisualStyleBackColor = true;
            this.btnSpin.Click += new System.EventHandler(this.btnSpin_Click);
            // 
            // txtSpinNum
            // 
            this.txtSpinNum.Location = new System.Drawing.Point(433, 349);
            this.txtSpinNum.Name = "txtSpinNum";
            this.txtSpinNum.Size = new System.Drawing.Size(34, 22);
            this.txtSpinNum.TabIndex = 3;
            // 
            // txtDeckBefore
            // 
            this.txtDeckBefore.Location = new System.Drawing.Point(40, 52);
            this.txtDeckBefore.Multiline = true;
            this.txtDeckBefore.Name = "txtDeckBefore";
            this.txtDeckBefore.Size = new System.Drawing.Size(150, 288);
            this.txtDeckBefore.TabIndex = 0;
            // 
            // txtDeckAfter
            // 
            this.txtDeckAfter.Location = new System.Drawing.Point(230, 52);
            this.txtDeckAfter.Multiline = true;
            this.txtDeckAfter.Name = "txtDeckAfter";
            this.txtDeckAfter.Size = new System.Drawing.Size(155, 288);
            this.txtDeckAfter.TabIndex = 1;
            // 
            // btnShuffle
            // 
            this.btnShuffle.Location = new System.Drawing.Point(412, 135);
            this.btnShuffle.Name = "btnShuffle";
            this.btnShuffle.Size = new System.Drawing.Size(101, 47);
            this.btnShuffle.TabIndex = 2;
            this.btnShuffle.Text = "Shuffle";
            this.btnShuffle.UseVisualStyleBackColor = true;
            this.btnShuffle.Click += new System.EventHandler(this.btnShuffle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 516);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFace)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnChangeFace;
        private System.Windows.Forms.PictureBox picFace;
        private System.Windows.Forms.Button btnSpin;
        private System.Windows.Forms.TextBox txtSpinNum;
        private System.Windows.Forms.TextBox txtDeckAfter;
        private System.Windows.Forms.TextBox txtDeckBefore;
        private System.Windows.Forms.Button btnShuffle;
    }
}

