using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;

namespace Stocks
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private Automobile mo;
        private ArrayList automobiles = new ArrayList();
        private ArrayList moNames = new ArrayList();
        
        void Page_PreRender(object sender, EventArgs e)
        {
            // Save Companies as key in ViewState before the page is rendered.
            //ViewState.Add("Companies", companies);
            Session.Add("Automobiles", automobiles);

        }

        public ArrayList createAutomobiles()
        {
                ArrayList cos = new ArrayList();

                mo = new Automobile("Microsoft", "MSFT", 51.80, 508000000000, 50000, "Redmond");
                cos.Add(mo);
                mo = new Automobile("Oracle", "ORCL", 51.80, 508000000000, 50000, "Redmond");
                cos.Add(mo);
                mo = new Automobile("Apple", "AAPL", 51.80, 508000000000, 50000, "Redmond");
                cos.Add(mo);
                mo = new Automobile("Exxon Mobile", "XOM", 51.80, 508000000000, 50000, "Redmond");
                cos.Add(mo);
                mo = new Automobile("Cisco", "CSCO", 51.80, 508000000000, 50000, "Redmond");
                cos.Add(mo);
                mo = new Automobile("Intel", "INTC", 51.80, 508000000000, 50000, "Redmond");
                cos.Add(mo);
                return cos;
        }

      
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                if (Session["Automobiles"] != null)
                {
                    
                    automobiles = (ArrayList)Session["automobiles"];
                }
                else
                    automobiles = createAutomobiles();
                populateDropdownList();
           }
            btnSubmitAutomobile.Visible = false;
            btnNewAutomobile.Enabled = true;
        }

        protected void populateDropdownList()
        {
            for (int i = 0; i < automobiles.Count; ++i)
            {
                mo = (Automobile)automobiles[i];
                moNames.Add(mo.AutomobileName);
                
            }
            lstAutomobileName.DataSource = moNames;
            lstAutomobileName.DataBind();
            populateTextBoxes((Automobile)automobiles[0]);
        }

        protected void populateTextBoxes(Automobile mob)
        {
            txtAutomobileName.Text = mob.AutomobileName;
            txtStockSymbol.Text = mob.StockSymbol;
            txtStockPrice.Text = mob.StockPrice.ToString();
            txtMarketCap.Text = mob.MarketCap.ToString();
            txtNumEmployees.Text = mob.NumberEmployees.ToString();
            txtHQ.Text = mob.HqCity;
        }

        protected void lstAutomobileName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            automobiles = (ArrayList)Session["Automobiles"];
            int index;
            index = lstAutomobileName.SelectedIndex;

            mo = (Automobile)automobiles[index];
            populateTextBoxes(mo);
            btnNewAutomobile.Enabled = true;
        }

        protected void btnNewAutomobile_Click(object sender, EventArgs e)
        {
            txtAutomobileName.Text = "";
            txtStockSymbol.Text = "";
            txtStockPrice.Text = "0.0";
            txtMarketCap.Text = "0.0";
            txtNumEmployees.Text = "0";
            txtHQ.Text = "";
            automobiles = (ArrayList)Session["Automobiles"];
            btnNewAutomobile.Enabled = false;
            btnSubmitAutomobile.Visible = true;

        }

        protected void btnSubmitAutomobile_Click(object sender, EventArgs e)
        {
            automobiles = (ArrayList)Session["Automobiles"];
            string cn="", ss="", hq="";
            double sp=0.0, mc=0.0;
            int ne=0;

            cn = txtAutomobileName.Text;
            ss = txtStockSymbol.Text;
            sp = Double.Parse(txtStockPrice.Text);
            mc = Double.Parse(txtMarketCap.Text);
            ne = Int32.Parse(txtNumEmployees.Text);
            hq = txtHQ.Text;

            addAutomobile(cn, ss, sp, mc, ne, hq);
            Session["Automobiles"] = (ArrayList)automobiles;
            populateDropdownList();
            btnSubmitAutomobile.Enabled = false;
        }

        public void addAutomobile(string cn="", string ss="", double sp=0.0, double mc=0.0, int ne=0, string hq="")
        {
            Automobile c = new Automobile(cn, ss, sp, mc, ne, hq);
            automobiles.Add(c);
        }

    }
}