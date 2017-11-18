using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaGUIApp
{
    public partial class frmPizzaApp : Form
    {
        private double[] prices = { 7.0, 9.0, 13.0, 17.0 };
        private double[] ingredients = { 1.25, 2.50, 3.25, 4.00 };
        private string[] sizes = { "Small", "Medium", "Large", "X-Large" };
        private double[] diameters = { 10.0, 12.0, 15.0, 20.0 };
        private int ingredientCount = 0;
        //private string crustStyle = "";

        public frmPizzaApp()
        {
            InitializeComponent();
        }

        private void frmPizzaApp_Load(object sender, EventArgs e)
        {
            initialLoad();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            showInvoice();

            showTotal(sizes);


        }

        public void initialLoad()
        {
            this.lblHeading.Text = "Mi's Pizza Joint";
            //  this.picPIzza.Image = Image.FromFile("../pizza.jpg");
            string str = "";
            string fmtStr;

            fmtStr = string.Format("{0,10}{1,10}{2,15}", "Sizes", "Prices", "Ingredients");
            str = str + fmtStr + "\r\n";

            for (int i = 0; i < prices.Length; ++i)
            {
                //   str = str + storageType[i] + prices[i].ToString() +"\r\n";
                fmtStr = string.Format("{0,10}{1,10:C2}{2,15:C2}", sizes[i], prices[i], ingredients[i]);
                str = str + fmtStr + "\r\n";

            }
            //txtMenu.Text = str;
            lblMenu.Text = str;
            String[] comboString = new String[4];

            for (int i = 0; i < 4; ++i)
            {
                fmtStr = string.Format("{0,-7}{1,10} diam.", sizes[i], diameters[i]);
                comboString[i] = fmtStr;
            }
            cboSizes.DataSource = comboString;


        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            chkAnchovies.Checked = false;
            chkMashroom.Checked = false;
            chkSausage.Checked = false;
            chkPeppers.Checked = false;
            chkOnions.Checked = false;
            lblInvoice.Text = "None taken.";
            ingredientCount = 0;
            txtTip.Text = "0";
            //crustStyle = "";

        }

        public void showInvoice()
        {
            
            String invoice = "";
            invoice += cboSizes.SelectedItem.ToString();

            if (rdoThin.Checked)
            {
                invoice += ("\r\n\r\nCrust Style Selected: " + rdoThin.Text);
            }
            else if (rdoThick.Checked)
            {
                invoice += ("\r\n\r\nCrust Style Selected: " + rdoThick.Text);
            }
            else if (rdoStuffed.Checked)
            {
                invoice += ("\r\n\r\nCrust Style Selected: " + rdoStuffed.Text);
            }
            else
            {
                invoice += ("\r\n\r\nNo Crust Style Selected");
            }

            if (chkAnchovies.Checked) ++ingredientCount;
            if (chkSausage.Checked) ++ingredientCount;
            if (chkMashroom.Checked) ++ingredientCount;
            if (chkPeppers.Checked) ++ingredientCount;
            if (chkOnions.Checked) ++ingredientCount;
            invoice += ("\r\n\r\nNumber of Ingredients Selected: " + ingredientCount);

            if (chkDelivery.Checked)
            {
                invoice += ("\r\n\r\nNeed Delivery");
            }
            else
            {
                invoice += ("\r\n\r\nNo Need Delivery");
            }

            invoice += ("\r\n\r\nTip Paid: " + txtTip.Text);


            // all invoice text finish
            lblInvoice.Text = invoice;

        }

        public void showTotal( string[] sizes ) {

            string[] s = sizes;

            double totalPrice = 0;

            double taxState = 0.085;

            double dIngredientCount = Convert.ToDouble(ingredientCount);

            if (cboSizes.SelectedItem.ToString() == "Small") {

                double pizzaPrice = 7.0;
                double ingredientsPrice = 1.25;

                double totalPizzaCost = pizzaPrice + ingredientsPrice * dIngredientCount;
                double taxAmount = totalPizzaCost * taxState;
                totalPrice = totalPizzaCost + taxAmount;

            }

            if (cboSizes.SelectedItem.ToString() == "Medium")
            {

                double pizzaPrice = 9.0;
                double ingredientsPrice = 2.50;

                double totalPizzaCost = pizzaPrice + ingredientsPrice * dIngredientCount;
                double taxAmount = totalPizzaCost * taxState;
                totalPrice = totalPizzaCost + taxAmount;

            }

            if (cboSizes.SelectedItem.ToString() == "Large")
            {

                double pizzaPrice = 13.0;
                double ingredientsPrice = 3.25;

                double totalPizzaCost = pizzaPrice + ingredientsPrice * dIngredientCount;
                double taxAmount = totalPizzaCost * taxState;
                totalPrice = totalPizzaCost + taxAmount;

            }

            if (cboSizes.SelectedItem.ToString() == "X-Large")
            {

                double pizzaPrice = 17.0;
                double ingredientsPrice = 4.00;

                double totalPizzaCost = pizzaPrice + ingredientsPrice * dIngredientCount;
                double taxAmount = totalPizzaCost * taxState;
                totalPrice = totalPizzaCost + taxAmount;

            }


            string sTotalPrice = Convert.ToString(totalPrice);

            txtTotal.Text = sTotalPrice;

        }

        public void output(string log)
        {

        }



        private void lblHeading_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lblMenu_Click_1(object sender, EventArgs e)
        {

        }

        private void chkOnions_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkAnchovies_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkDelivery_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTip_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }

        }
    }
}
