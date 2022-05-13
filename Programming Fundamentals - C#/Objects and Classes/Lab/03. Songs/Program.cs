using System;
using System.Collections.Generic;

namespace _03._Songs
{
    class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                string command = Console.ReadLine();
                string[] cmdArgs = command.Split("_");

                string typeList = cmdArgs[0];
                string name = cmdArgs[1];
                string time = cmdArgs[2];

                Song song = new Song();

                song.TypeList = typeList;
                song.Name = name;
                song.Time = time;

                songs.Add(song);
            }

            string printCommand = Console.ReadLine();

            if (printCommand == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                for (int i = 0; i < songs.Count; i++)
                {
                    if (printCommand == songs[i].TypeList)
                    {
                        Console.WriteLine(songs[i].Name);
                    }
                }
            }
        }
    }
}
