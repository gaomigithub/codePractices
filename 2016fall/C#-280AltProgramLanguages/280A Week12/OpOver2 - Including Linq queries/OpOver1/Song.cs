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

        public char Genre
        {
            get { return genre; }
            set { genre = value; }
        }

        public string Artist
        {
            get { return artist; }
            set { artist = value; }
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        // Like a showValues() method, make it more descriptive
        public void showSong()
        {
            Console.WriteLine("Title: "+title);
            Console.WriteLine("Artist: "+artist);
            Console.WriteLine("Genre: "+genre);
            Console.WriteLine("Song Length: "+lengthInSeconds);
        }

        public void detailLine()
        {
            Console.WriteLine("{0,22}{1,25}{2,5}{3,5}", title, artist, genre, lengthInSeconds);
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
