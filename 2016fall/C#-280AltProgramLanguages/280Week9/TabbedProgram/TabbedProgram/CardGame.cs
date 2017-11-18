using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabbedProgram
{
    class CardGame : IGame
    {
        String[] deck = {"2D", "3D", "4D", "5D", "6D", 
							"7D", "8D","9D","TD","JD","QD","KD","AD",
		"2H", "3H", "4H", "5H", "6H", 
							"7H", "8H","9H","TH","JH","QH","KH","AH",
		"2C", "3C", "4C", "5C", "6C", 
							"7C", "8C","9C","TC","JC","QC","KC","AC",
		"2S", "3S", "4S", "5S", "6S", 
							"7S", "8S","9S","TS","JS","QS","KS","AS"};
		
        public void play() { }

        public String getDeck()
        {
            String s="";
            for (int i=0; i<52; ++i)
            {
                s = s +" "+ deck[i];
            }
            return s;
        }
        public int getRandom() 
        {
            Random r = new Random();
            return r.Next(52); 
            
        }

        public void shuffleDeck()
        {
            Random r = new Random();
            String temp;
            int c1, c2;
            for (int s=0; s<100; ++s)
		    {
		    // randomly generate 2 numbers between 0 and 51
		    c1 = r.Next(52);
            c2 = r.Next(52);
             // swap algorithm
		    temp=deck[c1];
		    deck[c1]=deck[c2];
		    deck[c2]=temp;
		    }
        }
    }
}
