using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpOver1
{
    class Song
    {
        private String title;
        private String artist;
        private char genre;   // r=rock, c=classical, j=jazz, b=blues, h=hiphop
        private int lengthInSeconds;

        public Song()  // default constructor
        { }

        // multi argument constructor
        public Song(String t, String a, char g, int l)
        {
            title = t;
            artist = a;
            genre = g;
            lengthInSeconds = l;

            // add fifth member variable
        }

        // add properties for all member variables

        public int LengthInSeconds
        {
            get { return lengthInSeconds; }
            set { lengthInSeconds=value;  }
        }

        // Like a showValues() method, make it more descriptive
        public void showSong()
        {
            Console.WriteLine(title);
            Console.WriteLine(artist);
            Console.WriteLine(genre);
            Console.WriteLine(lengthInSeconds);
        }

        public static Song operator ++(Song s)
        {
            s.lengthInSeconds++;
            return s;
        }

        public static Song operator +(Song s1, Song s2)
        {
            Song song = new Song();
            // you define what + means for your objects
            // so you could just add the numeric variables
            // or add all values somehow (arithmetic add, and concatenation for strings)

            song.lengthInSeconds = s1.lengthInSeconds + s2.lengthInSeconds;
            return song;
        }
    }
}
