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
        public Company co;
        public ArrayList companies = new ArrayList();
        public ArrayList coNames = new ArrayList();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                co = new Company("Microsoft", "MSFT", 51.80, 508000000000, 50000, "Redmond");
                companies.Add(co);
                co = new Company("Oracle", "ORCL", 51.80, 508000000000, 50000, "Redmond");
                companies.Add(co);
                co = new Company("Apple", "AAPL", 51.80, 508000000000, 50000, "Redmond");
                companies.Add(co);
                co = new Company("Exxon Mobile", "XOM", 51.80, 508000000000, 50000, "Redmond");
                companies.Add(co);
                co = new Company("Cisco", "CSCO", 51.80, 508000000000, 50000, "Redmond");
                companies.Add(co);
                co = new Company("Intel", "INTC", 51.80, 508000000000, 50000, "Redmond");
                companies.Add(co);

                for (int i = 0; i < companies.Count; ++i)
                {
                    co = (Company)companies[i];
                    coNames.Add(co.CompanyName);

                    //Response.Write();
                }
                lstCompanyName.DataSource = coNames;
                lstCompanyName.DataBind();
            }
        }

        protected void lstCompanyName_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index;
            index = lstCompanyName.SelectedIndex;
            Response.Write(index);
            co = (Company)coNames[index];
            
            txtCompanyName.Text = co.CompanyName;
            txtStockSymbol.Text = co.StockSymbol;
            txtStockPrice.Text = co.StockPrice.ToString();
            txtMarketCap.Text = co.MarketCap.ToString();
            txtNumEmployees.Text = co.NumberEmployees.ToString();
            txtHQ.Text = co.HqCity;
        }
    }
}