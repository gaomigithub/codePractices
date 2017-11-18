using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace PizzaApp
{
    public partial class _Default : System.Web.UI.Page
    {
        private static double[] PRICE = { 7.50, 11.75, 14.85, 17.50 };

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private string collect()
        {
            string detail = "";
            switch (id_size.SelectedIndex)
            {
                case 0: detail += "Small($"+PRICE[0]+"), "; break;
                case 1: detail += "Medium($" + PRICE[1] + "), "; break;
                case 2: detail += "Large($" + PRICE[2] + "), "; break;
                case 3: detail += "Extra Large($" + PRICE[3] + "), "; break;
            }

            if(id_thin_crust.Checked || id_deep_fish.Checked || id_pan_pizza.Checked)
            {
                if (id_thin_crust.Checked) detail += "Thin Crust";
                else if (id_deep_fish.Checked) detail += "Deep Fish";
                else if (id_pan_pizza.Checked) detail += "Pan Pizza";

                string[] txt = { "Sausage", "Mushrooms", "Peppers", "Onions" };
                bool[] chk = { id_sausage.Checked, id_mushrooms.Checked, id_peppers.Checked, id_onions.Checked };
                int first = -1;
                for (int i = 0; i < chk.Length; i++)
                {
                    if (chk[i])
                    {
                        if (first == -1)
                        {
                            detail += " with " + txt[i];
                            first = i;
                        }
                        else
                        {
                            detail += " and " + txt[i];
                        }
                    }
                }

                detail += ", ";
            }

            detail += id_delivery.Checked ? "Delivery " : "Pick-Up ";
            return detail;
        }

        protected void on_updating_detail(object sender, EventArgs e)
        {
            id_detail.Text = collect();
        }

        protected void id_clear_Click(object sender, EventArgs e)
        {
            id_size.SelectedIndex = 0;

            id_thin_crust.Checked = false;
            id_pan_pizza.Checked = false;
            id_deep_fish.Checked = false;

            id_sausage.Checked = false;
            id_mushrooms.Checked = false;
            id_onions.Checked = false;
            id_peppers.Checked = false;

            id_tip.Text = "";
            id_delivery.Checked = false;
            id_detail.Text = "";
            id_invoice_text.Text = "";
        }

        protected void id_invoice_Click(object sender, EventArgs e)
        {
            double price = PRICE[id_size.SelectedIndex];
            double delivery = id_delivery.Checked ? 3.0 : 0.0;
            double tip = Convert.ToDouble(id_tip.Text);
            double total = price + delivery + tip;


            string text = "Pizza:       $" + price.ToString("f2") + "\r\n" +
                          "Delivery:    $" + delivery.ToString("f2") + "\r\n" +
                          "Tip:         $" + tip.ToString("f2") + "\r\n" +
                          "--------------\r\n" +
                          "Total:       $" + total.ToString("f2");

            id_invoice_text.Text = text;
        }
    }
}
