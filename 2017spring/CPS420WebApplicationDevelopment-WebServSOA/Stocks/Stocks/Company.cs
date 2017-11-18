using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Stocks
{
    public class Company
    {
        private string companyName;
        private string stockSymbol;
        private double stockPrice;
        private double marketCap;
        private int numberEmployees;
        private string hqCity;

        public Company() { }
        public Company(string cn, string ss, double sp, double mc, int ne, string hq)
        {
            companyName = cn;
            stockSymbol = ss;
            stockPrice = sp;
            marketCap = mc;
            numberEmployees = ne;
            hqCity = hq;
        }

        public string CompanyName
        {
            get { return companyName; }
            set { companyName= value; }
        }

        public string StockSymbol
        {
            get { return stockSymbol; }
            set { stockSymbol = value; }
        }

        public double StockPrice
        {
            get { return stockPrice; }
            set { stockPrice = value; }
        }

        public double MarketCap
        {
            get { return marketCap; }
            set { marketCap = value; }
        }

        public int NumberEmplyees
        {
            get { return numberEmployees; }
            set { numberEmployees = value; }
        }

        public string HqCity
        {
            get { return hqCity; }
            set { hqCity = value; }
        }

    }
}