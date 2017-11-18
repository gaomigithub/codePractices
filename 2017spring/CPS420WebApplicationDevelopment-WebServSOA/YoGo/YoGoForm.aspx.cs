using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace YoGo
{

    public partial class YoGoForm : System.Web.UI.Page
    {
        // prices for Yogurt Shop
        // Small $2.00, Medium $3.25, Large $4.50
        //private static double[] prices = { 2.50, 3.25, 4.50 };

        public struct prc
        {
            //constructor
            public prc (String s, double p)
            {
                st = s;
                pr = p;
            }
            public String st;
            public double pr;
            public override string ToString()
            {
                return string.Format("{0}:{1:C}", st, pr);
                //return (st+": "+pr);
            }
        };

        string[] pricesString = new string[3];

        prc [] prices = 
            { new prc("Small" ,2.50), 
              new prc("Medium",3.25), 
              new prc("Large" , 4.50)
            };
           



        // Toppings $1.25 each

        // prices for type of dessert
        // Ice Cream - Add 1.00
        // Frozen Yogurt - Add .75
        // Sherbet - Add .50

        private static double[] dCharge = { 1.00, .75, .50 };

        private double taxRate = .075;

        protected void Page_Load(object sender, EventArgs e)
        {
        
            for (int i=0; i<pricesString.Length; ++i)
            {
                pricesString[i] = prices[i].ToString();
            }

            ddlSize.DataSource = pricesString;
            ddlSize.DataBind();

        }

        protected void cmdShowOrder_Click(object sender, EventArgs e)
        {
            String myOrder = "";

            if (chkCoating.Checked)
                myOrder = myOrder + "Coating ";
            if (chkSprinkles.Checked)
                myOrder = myOrder + "Sprinkles ";
            if (chkFruit.Checked)
                myOrder = myOrder + "Fruit ";
            if (chkWaffle.Checked)
                myOrder = myOrder + "Waffle ";

            txtMyOrder.Text = myOrder;

        }
    }
}