using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drink
{
    public partial class Form1 : Form
    {
        private HotChocolate h;
        private Juice j;
        private Pop p;

        public Form1()
        {
            InitializeComponent();
        }

        public void createHotChocolateObject()
        {
            h = new HotChocolate();
            
            // The commented code below is in case you wanted to dynamically add labels, etc.
            // However, it must be done before the Form_Load procedure, so 
            // it may be better to just make the controls invisible until you need them.

            //Label hLabel = new Label();
            //hLabel.Text="Chocolate Pct";
            //this.Controls.Add(hLabel);

            comboBox2.Enabled = false;

            lblData1.Text = "Chocolate Pct";
            txtData1.Visible = true;
            lblData1.Visible = true;

            lblData2.Text = "Temperature";
            txtData2.Visible = true;
            lblData2.Visible = true;




        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBox2.SelectedIndex)
            {
                case 0:  txtOutput.Text = "Hot Chocolate";
                         createHotChocolateObject();
                         break;
                case 1:  txtOutput.Text = "Juice";
                         break;
                case 2:  txtOutput.Text = "Pop";
                         break;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtData1.Visible = false;
            txtData2.Visible = false;
            lblData1.Visible = false;
            lblData2.Visible = false;

        }
    }
}
