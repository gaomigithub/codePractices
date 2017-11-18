using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabbedProgram
{
    class Toss
    {
        public string headOrTail = "", userGuess = "";

        public string HeadsorTails()
        {

            Random headsOrTails = new Random();
            int headsTails = headsOrTails.Next(1, 3);
            if (headsTails.Equals(1))
            {
                
                headOrTail = "Heads";
            }
            else
            {
               // pic = Properties.Resources.Tails;
                headOrTail = "Tails";
            }

            return headOrTail;

        }
    }
}
