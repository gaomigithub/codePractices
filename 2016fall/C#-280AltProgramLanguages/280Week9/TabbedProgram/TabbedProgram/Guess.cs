using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabbedProgram
{
    class Guess
    {

        /// Setting mouse click from string to int
        public int ChangeStrToInt(string str)
        {
            int n = 0;
            //determine str or not
            switch (str)
            {
                case "Scissors":
                    n = 1;
                    break;
                case "Rock":
                    n = 2;
                    break;
                case "Paper":
                    n = 3;
                    break;
                default:
                    throw new Exception("Unknown");
            }
            return n;
        }

        // the way of how computer 
        public int PC()
        {
            Random ran = new Random();
            //random.Next: take minimum, but not maximum, so take random value from 1 to 3
            int vPC = ran.Next(1, 4);


            return vPC;
        }


        /// Comparing the value between player's and computer's
        public string Judge(int Player, int PC)
        {
            // Scissors: 1  Rock: 2  Ppaer: 3
            // 2 way for win: one way is Player's value larger 1 than computer's; other one is small 2
            int tmp = Player - PC;
            string judgedResult = string.Empty;
            if (tmp == 1 || tmp == -2)
                judgedResult = "Win";
            
            else if (tmp == 0)
                judgedResult = "Draw";
            
            else
                judgedResult = "Lost";
            return judgedResult;
        }
    }
}
