using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabbedProgram 
{
    class Slots : IGame
    {
        public void play() 
        {
            
        }

        public int getRandom()
        {
            Random r = new Random();
            return r.Next(5);

        }
    }
}
