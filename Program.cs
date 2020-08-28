using System;
using System.Collections.Generic;
using System.Linq;

namespace AnythingButCreed
{
    class Program
    {
        static void Main(string[] args)
        {
            var goodSongs = new List<Song>();

            var allSongs = new List<Song>()
            {
            new Song("N3wport", "Gasoline"),
            new Song("Creed", "Are You Ready"),
            new Song("Creed", "With Arms Wide Open"),
            new Song("Katy Perry", "Rise"),
            new Song("Creed", "What If"),
            new Song("Liv Ash", "A Storm Is Comin"),
            new Song("Seether", "Fake It"),
            new Song("Depeche Mode", "Enjoy The Silence"),
            new Song("Depeche Mode", "Slow"),
            new Song("Willyecho", "Welcome To The Fire"),
            new Song("The Score", "In My Bones"),
            new Song("Sam Tinnesz", "Fight On"),

        };
            var creedSongs = allSongs.Where(s => s.Artist == "Creed");
            foreach (var song in creedSongs)
            {
                Console.WriteLine($"Creed Songs:  {song.Name }");
            }
            goodSongs.AddRange(allSongs.Except(creedSongs));

            foreach ( var song in goodSongs)
            {
                Console.WriteLine($"\n Good Songs: \n {song.Artist} - {song.Name}");
            }
        }
    }
}
