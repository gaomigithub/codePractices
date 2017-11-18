using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invenstmentGrowth
{
    class Program
    {
        public static void showGrowth()
        {
            double investmentPrice = 0.0;
            double pricePerUnit = 53.35;
            int quantity = 20;// (in units, ounces, bushels, etc.)
            int period;
            string description = "Microsoft Stock";
            int numPeriods = 10;// – days, months, quarters, years, etc.
            double growthRate = .05; // (this may end up negative)

            investmentPrice = pricePerUnit * quantity;
            Console.WriteLine("The initial value of your investment: " + investmentPrice);
            for (period = 1; period <= numPeriods; ++period)
            {
                // investmentPrice *= (1 + growthRate);
                investmentPrice = investmentPrice * (1 + growthRate);

                Console.WriteLine(period + " " + investmentPrice);
            }

            Console.WriteLine("Final Price: " + investmentPrice);
        }

        static void Main(string[] args)
        {
            showGrowth();
    
        }

            }
}
