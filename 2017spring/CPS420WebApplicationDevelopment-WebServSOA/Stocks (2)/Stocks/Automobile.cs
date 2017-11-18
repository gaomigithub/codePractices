using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//using System.Runtime.Serialization.Formatters.Binary;
//using System.Runtime.Serialization.Formatters.Soap;
//using System.Runtime.Serialization;

namespace Stocks
{
//    [Serializable]
    public class Automobile   //: ISerializable
    {
        private string automobileName;
        private string stockSymbol;
        private double stockPrice;
        private double marketCap;
        private int numberEmployees;
        private string hqCity;

        public Automobile() { }
        public Automobile(string cn, string ss, double sp, double mc, int ne, string hq)
        {
            automobileName = cn;
            stockSymbol = ss;
            stockPrice = sp;
            marketCap = mc;
            numberEmployees = ne;
            hqCity = hq;
        }

        public Automobile newAutomobile(string cn, string ss, double sp, double mc, int ne, string hq)
        {
            Automobile c = new Automobile();
            AutomobileName = cn;
            StockSymbol=ss;
            StockPrice=sp;
            MarketCap=mc;
            NumberEmployees=ne;
            HqCity=hq; 
            return c;
        }

        public string AutomobileName
        {
            get { return automobileName; }
            set { automobileName = value; }
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

        public int NumberEmployees
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