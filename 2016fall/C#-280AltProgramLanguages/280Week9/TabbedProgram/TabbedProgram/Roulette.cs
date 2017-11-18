using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabbedProgram
{
    class Roulette
    {
        public string color, userGuess;

        public int numbers()
        {
            Random ran = new Random();
            //random.Next: random value from 1 to 16
            int numbers = ran.Next(1, 16);
            return numbers;
        }

        public string colors() {
            Random ran = new Random();
            int colors = ran.Next(1, 2);
            if (colors.Equals(1))
            {

                color = "Red";
            }
            else
            {
                // pic = Properties.Resources.Tails;
                color = "Black";
            }

            return color;
        }
    }
}
