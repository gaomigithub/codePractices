using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhone
{
    class SmartPhone
    {
        private int custNum;
        private String brand;
        private int flashMemory;
        private double price;
        private bool dataPlan;
        private char color;  // r is red, b is black, w is white, g is green
        private String carrier; // AT&T, Verizon, TMobile, Sprint

        public SmartPhone() { }  // default constructor (0 argument constructor)

        public SmartPhone(String b, String c) 
        {
            brand = b;
            carrier = c;
            //String s = "Hello";  // creates an object


        }

        public SmartPhone(String br, int fl, double pr, bool dp, char cl, String cr, int cn)
        {
            brand = br;
            flashMemory = fl;
            price = pr;
            dataPlan = dp;
            color = cl;
            carrier = cr;
            custNum = cn;

        }

        public SmartPhone(int fl, double pr, bool dp, char cl)
        {
            flashMemory = fl;
            price = pr;
            dataPlan = dp;
            color = cl;
        }

        // nonsense constructor 
        //public SmartPhone(double y, bool z, char a, int x)
        //{ }
        
        //property
        public String Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public int FlashMemory
        {
            get { return flashMemory; }
            set { flashMemory = value; }
        }

        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public bool DataPlan
        {
            get { return dataPlan; }
            set { dataPlan = value; }
        }

        public char Color
        {
            get { return color; }
            set { color = value; }
        }
        public String Carrier
        {
            get { return carrier; }
            set { carrier = value; }
        }

        public int CustNum
        {
            get { return custNum; }
            set { custNum = value; }
        }
        // like a Java accessor method (get method)
        public String getBrand()
        {
            return brand;
        }

        // like a Java mutator method (set method)
        public void setBrand(String b)
        {
            brand = b;
        }

        public string getRawData()
        {
            String s = "";
            s = custNum.ToString()
                + brand 
                + carrier
                + flashMemory.ToString()
                + price.ToString()
                + (dataPlan?"Yes":"No")
                + color;

                    // ?: is the ternary (3 operands) operator
                    // if (dataplan) st="Yes" else st="No"

           //brand flashMemory price dataPlan color carrier
            return s;
        }

        public string getFormattedData()
        {
            String s = "";
            s = 
            String.Format
            (
            "{6,5}{1,20}{0,20}{2,5}{3,8}{4,5}{5,3}",
            brand, carrier, flashMemory.ToString(),
            price.ToString(), (dataPlan ? "Yes" : "No"), color, custNum
            );
            
            return s;
        }
    }
}
