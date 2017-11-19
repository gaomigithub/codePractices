using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace SmartPhone
{
    public partial class frmSmartPhone : Form
    {
        public frmSmartPhone()
        {
            InitializeComponent();
        }

        private ArrayList phones = new ArrayList();
            
        private void Form1_Load(object sender, EventArgs e)
        {
            SmartPhone iPhone = new SmartPhone();
            
            SmartPhone android = new SmartPhone("Motorola","AT&T");
            android.Price = 299;
            android.DataPlan = true;
            android.Color = 'R';
            android.FlashMemory = 4;
            android.CustNum = 333;
            SmartPhone windows = new SmartPhone(16,599.00,true,'B');
            windows.Brand = "Nokia";
            windows.Carrier = "T-Mobile";
            windows.CustNum = 222;

            SmartPhone blackberry = new SmartPhone("Blackberry", 1, 399, true, 'B', "RIM",111);
            blackberry.CustNum = 111;

            phones.Add(android);
            phones.Add(windows);
            phones.Add(blackberry);
            phones.Add(new SmartPhone("Blackberry", 2, 199, true, 'R', "RIM",444));

            // txtOutput.Text = android.getBrand();  // calls the accessor method (get) - old fashioned way
            txtOutput.Text = android.Brand;
            txtOutput.Text = txtOutput.Text+windows.Carrier;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnShowRecords_Click(object sender, EventArgs e)
        {
            showRecords(); 
        }

        private void showRecords()
        {
            String s = "";
            SmartPhone p = new SmartPhone();
            for (int i = 0; i < phones.Count; ++i)
            {
                p = (SmartPhone)phones[i];
                s += p.getFormattedData() + "\r\n";

            }
            txtOutput.Text = s;
        }

        private void btnAddRecord_Click(object sender, EventArgs e)
        {
            SmartPhone s = new SmartPhone();
            s.Brand = txtBrand.Text;
            s.Carrier = txtCarrier.Text;
            s.FlashMemory = Int32.Parse(txtFlashMemory.Text);
            s.Price = Double.Parse(txtPrice.Text);
            s.DataPlan = Boolean.Parse(txtDataPlan.Text);
            s.Color = Char.Parse(txtColor.Text);
                /*
                brand 
                carrier
                flashMemory.ToString()
                price.ToString()
                (dataPlan?"Yes":"No")
                color;
                */
            phones.Add(s);
            clearTextBoxes();
            showRecords();
        }

        private void clearTextBoxes()
        {
            txtBrand.Text = "";
            txtCarrier.Text = "";
            txtColor.Text = "";
            txtDataPlan.Text = "";
            txtFlashMemory.Text = "";
            txtPrice.Text = "";

        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            bool recordFound = false;
            int recNum = -1;
            int r = Int32.Parse(txtRecordToDelete.Text);
            SmartPhone p = new SmartPhone();
            for (int i = 0; i < phones.Count; ++i)
            {
                p = (SmartPhone)phones[i];
                if (p.CustNum==r)
                {
                    recNum = i;
                    recordFound = true;
                }
            }
            phones.RemoveAt(recNum);
            showRecords();
        }
    }
}
