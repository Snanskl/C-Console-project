using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kid_s_Fair
{
    internal class Album
    {
        private string albumName;
        private string artistName;
        private int numOfTracks;

        //A method that "collect" all the other method and will be invoke in Main method
        public void Start()
        { 
            ReadingInput_Album();
            FinalOutput_Album();
        }

        private void ReadingInput_Album()
        {
            Console.WriteLine("Starting the Album Program!\n"); //Using escape sequence "new line" to create space 
            
            Console.Write("What is the name of your favorit music album? ");
            albumName = Console.ReadLine();

            Console.Write($"What is the name of the Artist or Band for {albumName}? ");
            artistName = Console.ReadLine();

            Console.Write($"How many tracks does {albumName} have? ");
            numOfTracks = int.Parse(Console.ReadLine()); // using int.parse conversion to turn string to integer
        }
        private void FinalOutput_Album()
        {
            Console.WriteLine($"\nAlbum Name: {albumName}");
            Console.WriteLine($"Artist/Band: {artistName}");
            Console.WriteLine($"Number of Tracks: {numOfTracks}");
            Console.WriteLine("Enjoy listening!\n");
        }
    }
}
