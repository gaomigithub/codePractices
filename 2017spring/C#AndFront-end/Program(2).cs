using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballPlayerHierarchy
{
    public class FootballPlayer
    {
        private string name;
        private double weight;
        private int heightInInches;
        private bool rookie;
        private string collegeAttended;
        private int birthYear;

        public FootballPlayer() { } // default constructor
        public FootballPlayer(string n, double w, int h, bool r, string c, int b)
        {
            name = n; weight = w; heightInInches = h; rookie = r; collegeAttended = c; birthYear = b;
        }

        public void showValues()
        {
            Console.WriteLine("{0,20}{1,18}", "Name:", name);
            Console.WriteLine("{0,20}{1,18}", "Weight:", weight);
            Console.WriteLine("{0,20}{1,18}", "Height:", Height);
            Console.WriteLine("{0,20}{1,18}", "Rookie:", (rookie ? "Yes" : "No"));
            Console.WriteLine("{0,20}{1,18}", "College:", College);
            Console.WriteLine("{0,20}{1,18}", "Birth Year:", BirthYear);
            Console.WriteLine("{0,20}{1,18}", "Age:", showAge());

        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public int Height
        {
            get { return heightInInches; }
            set { heightInInches = value; }
        }

        public bool Rookie
        {
            get { return rookie; }
            set { rookie = value; }
        }

        public string College
        {
            get { return collegeAttended; }
            set { collegeAttended = value; }
        }

        public int BirthYear
        {
            get { return birthYear; }
            set { birthYear = value; }
        }

        public int showAge()
        {
            DateTime dt = DateTime.Now;
            return dt.Year - BirthYear;
        }

    }

    public class NFLPlayer : FootballPlayer
    {
        public string team;
        public string position;

        public NFLPlayer() { }
        public NFLPlayer(string n, double w, int h, bool r, string c, int b, string t, string p)
            : base(n, w, h, r, c, b)
        {
            team = t;
            position = p;
        }

        public string Team
        {
            get { return team; }
            set { team = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        public void showValues()
        {
            base.showValues();
            Console.WriteLine("{0,20}{1,18}", "Team:", Team);
            Console.WriteLine("{0,20}{1,18}", "Position:", Position);
        }
    }

    public class OffensiveNFLPlayer : NFLPlayer
    {
        public bool quarterback;
        public int totalYards;

        public OffensiveNFLPlayer() { }
        public OffensiveNFLPlayer(string n, double w, int h, bool r, string c, int b, string t, string p, bool qb, int ty)
            : base(n, w, h, r, c, b, t, p)
        {
            quarterback = qb;
            totalYards = ty;
        }

        public bool QB
        {
            get { return quarterback; }
            set { quarterback = value; }
        }

        public int Yards
        {
            get { return totalYards; }
            set { totalYards = value; }
        }

        public void showValues()
        {
            base.showValues();
            Console.WriteLine("{0,20}{1,18}", "Quarterback?", QB);
            Console.WriteLine("{0,20}{1,18}", "Yards:", Yards);
        }
    }

    public class DefensiveNFLPlayer
    {
        public int sacks;
        public int interceptions;
    }

    class Program
    {
        static void Main(string[] args)
        {
            FootballPlayer peytonManning = new FootballPlayer("Peyton Manning", 230, 77, false, "Tennessee", 1976);

            Console.WriteLine("\nBase Class Object:");
            peytonManning.showValues();

            NFLPlayer barry = new NFLPlayer("Barry Sanders", 200, 68, false, "Oklahoma State", 1968, "Lions", "Running Back");

            Console.WriteLine("\nDerived Class Object:");
            barry.showValues();

            OffensiveNFLPlayer rookie = new OffensiveNFLPlayer("Jameis Winston", 227, 76, true, "Florida State", 1994, "Buccaneers", "Quarterback", true, 4042);
            Console.WriteLine("\nDerived Class Object:");
            rookie.showValues();
        }
    }
}