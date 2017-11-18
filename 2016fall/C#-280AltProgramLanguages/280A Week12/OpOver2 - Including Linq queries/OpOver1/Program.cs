using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpOver1
{
    // you can put another class inside this file but use a separate file for this lab
    class Movie
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            // this function addresses item 2. from the assignment sheet
            // the following call works, but I'm commenting it to test other parts
            // showOverloadingOperators();

            // this segment involves 
            // creating of a array of objects
            // reading the records from a file into the array of objects

            Song[] songs = new Song[40];

            // the readFile() call works, but I am commenting it to test other parts of the code
            readFile(songs);  // read the text file, convert lines into individual strings, load the array songs
            // the following code is for extra credit.  The second call, to reportArrayQueried(), uses Linq and lambda expressions

            Console.WriteLine("UnQueried:");
            reportArray(songs);
            Console.WriteLine("");
            Console.WriteLine("Queried < 200 song length:");
            reportArrayQueried1(songs);
            Console.WriteLine("");
            Console.WriteLine("Queried Genre is Blues:");
            reportArrayQueried2(songs);
            Console.WriteLine("");


            // call this function to just show how one line is split
            // showSplitLine("one\ttwo three:four,five six seven");

            // test just one string, which is not read from the file
            //string [] strings = new string[4];

            //string st = "Shaggy Dog,Lightning Hopkins,b,150";
            //splitLine(st, ref strings);

            //foreach (string s in strings)
            {
              //  System.Console.WriteLine(s);
            }

            //Song blues = new Song("Shaggy Dog", "Lightning Hopkins", 'b', 150);
            //blues.detailLine();
            
 /*
            // take each piece of the string and convert it to another type
            string artist   =       strings[0];
            string name     =       strings[1];
            string genreS   = strings[2];
            char genreC = genreS[0]; // treating a string as an array of char
            int length =Int32.Parse(strings[3]);
            
            // creates an object from each piece of the string
            Song aSong = new Song(artist, name, genreC, length);
            aSong.showSong();
   */
        }

        static void reportArray(Song [] songs)
        {
            foreach (Song song in songs)
            {
                song.detailLine();
            }
        }

        static void reportArrayQueried1(Song[] songs)
        {
           
            var shortSongs =
        from song in songs
        where song.LengthInSeconds < 200
        select (song);


            foreach (Song song in shortSongs)
            {
                song.detailLine();
            }
        }

        static void reportArrayQueried2(Song[] songs)
        {
        var blues = songs
        .Where( song    => song.Genre == 'b')
        .Select (song => song.Artist);

            foreach (String artist in blues)
            {
                Console.WriteLine(artist);
            }
        }

        static void showOverloadingOperators()
        {
            Song alternative = new Song("Madness", "Muse", 'r', 200);
            Song blues = new Song("Shaggy Dog", "Lightning Hopkins", 'b', 150);
            Song altBlues = new Song();

            altBlues = alternative + blues;

            altBlues.showSong();
            altBlues++;
            altBlues.showSong();
            
        }

        static void readFile(Song[] songs)
        {
            int counter = 0;
            string line;

            // Read the file and display it line by line.
            System.IO.StreamReader file =
               new System.IO.StreamReader("c:/temp/songs.csv");

            string[] words = new string[4];

            while ((line = file.ReadLine()) != null)
            {
                // show the lines as they are read from file
                //Console.WriteLine(line);
                splitLine(line, ref words);
                songs[counter] = new Song(words[0], words[1], Char.Parse(words[2]), Int32.Parse(words[3]));
                // showSplitLine(line);
                counter++;
                
            }
            file.Close();
        }

        static void showSplitLine(string text)
        {
            //char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
            
            char[] delimiterChars = {','};

            System.Console.WriteLine("Original text: '{0}'", text);

            string[] words = text.Split(delimiterChars);
            System.Console.WriteLine("{0} words in text:", words.Length);

            foreach (string s in words)
            {
                System.Console.WriteLine(s);
            }
        }

        static void splitLine(string text, ref string [] words)
        {
            char[] delimiterChars = { ',' };
            words = text.Split(delimiterChars);
        }
    }
}
