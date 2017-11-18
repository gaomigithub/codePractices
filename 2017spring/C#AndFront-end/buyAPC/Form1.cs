using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace buyAPC
{
    public partial class frmPCWarehouse : Form
    {
        string[] storageType = { "HDD", "SSD", "Cloud", "Diskless" };
        double[] prices = { 199.00, 299.00, 99.00, 0.0 };


        public frmPCWarehouse()
        {
            InitializeComponent();
        }

        private void frmPCWarehouse_Load(object sender, EventArgs e)
        {
            string str="";
            string fmtStr;


            for (int i = 0; i < storageType.Length; ++i )
            {
             //   str = str + storageType[i] + prices[i].ToString() +"\r\n";
                fmtStr = string.Format("{0,10}{1,10:C2}", storageType[i],prices[i]);
                str = str + fmtStr + "\r\n";

            }
            txtMenu.Text = str;
            lblMenu.Text = str;



                cmbStorage.DataSource = storageType;

            cmbCPUType.Items.Add("PC");
            cmbCPUType.Items.Add("Laptop");
            cmbCPUType.Items.Add("Tablet");
            cmbCPUType.Items.Add("Phone");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            showInvoice();

        }
        
        void showInvoice()
        {
            String st="";
            st = cmbCPUType.SelectedItem.ToString();
            lblInvoice.Text = st;

        }
    }
}
