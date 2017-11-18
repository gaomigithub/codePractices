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


namespace FileIO
{
    public partial class frmFileIO : Form
    {
        public String[] lines;

        public frmFileIO()
        {
            InitializeComponent();
        }
        OpenFileDialog ofd = new OpenFileDialog();
        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            ofd.Filter = "TXT (*.txt)|*.txt |DAT (*.dat)|*.dat|All Files (*.*)|*.*";
            ofd.Title = "Open a Text File";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
               

                txtFilename.Text = ofd.FileName;
                txtSafeFilename.Text = ofd.SafeFileName;

                StreamReader inFile = new StreamReader(File.OpenRead(ofd.FileName));
                
                txtArea.Text = inFile.ReadToEnd();
                inFile.Dispose();  //destroys instance of file object

            }

        }

        private void frmFileIO_Load(object sender, EventArgs e)
        {

        }

        private void btnSaveFile_Click(object sender, EventArgs e)
        {
            String s = txtArea.Text;
           
            lines = s.Split(new char[] { '\n' });

            String fn = txtSaveFilename.Text; 
            
            System.IO.File.WriteAllLines(@fn, lines);

            MessageBox.Show("File Written: "+fn, "File Written", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void txtSaveFilename_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
