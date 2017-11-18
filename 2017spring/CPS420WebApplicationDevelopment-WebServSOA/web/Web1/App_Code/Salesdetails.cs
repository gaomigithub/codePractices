using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class Salesdetails
{
    public int sales { get; set; }
    public int pages { get; set; }
    public string ID { get; set; }

    public static IEnumerable<Salesdetails> getsalesdetails()
    {
        Salesdetails[] sd =
        {
         new Salesdetails { ID = "001", pages=678, sales = 110000},
         new Salesdetails { ID = "002", pages=789, sales = 60000},
         new Salesdetails { ID = "003", pages=456, sales = 40000},
         new Salesdetails { ID = "004", pages=900, sales = 80000},
         new Salesdetails { ID = "005", pages=456, sales = 90000},
         new Salesdetails { ID = "006", pages=870, sales = 50000},
         new Salesdetails { ID = "007", pages=675, sales = 40000},
      };

        return sd.OfType<Salesdetails>();
    }
}
