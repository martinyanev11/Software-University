using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Tiles_Master
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] inputWhiteTiles = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] inputGreyTiles = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Stack<int> whiteTilesStack = new Stack<int>(inputWhiteTiles);
            Queue<int> greyTilesQueue = new Queue<int>(inputGreyTiles);

            Dictionary<string, List<int>> kitchenAreas = new Dictionary<string, List<int>> 
            {
                { "Floor", new List<int>() },
                { "Sink", new List<int>() },
                { "Oven", new List<int>() },
                { "Countertop", new List<int>() },
                { "Wall", new List<int>() },
            };

            Dictionary<int, string> tileAreaDictionary = new Dictionary<int, string>
            {
                { 40 , "Sink" },
                { 50 , "Oven" },
                { 60 , "Countertop" },
                { 70 , "Wall" }
            };

            while (whiteTilesStack.Count > 0 && greyTilesQueue.Count > 0)
            {
                int whiteTile = whiteTilesStack.Pop();
                int greyTile = greyTilesQueue.Dequeue();

                if (whiteTile == greyTile)
                {
                    int newTileArea = whiteTile + greyTile;

                    if (tileAreaDictionary.ContainsKey(newTileArea))
                    {
                        string areaNameToAddTileInto = tileAreaDictionary[newTileArea];
                        kitchenAreas[areaNameToAddTileInto].Add(newTileArea);
                    }
                    else
                    {
                        kitchenAreas["Floor"].Add(newTileArea);
                    }
                }
                else
                {
                    whiteTile /= 2;
                    whiteTilesStack.Push(whiteTile);

                    greyTilesQueue.Enqueue(greyTile);
                }
            }

            if (whiteTilesStack.Count == 0)
            {
                Console.WriteLine("White tiles left: none");
            }
            else
            {
                Console.WriteLine($"White tiles left: {string.Join(", ", whiteTilesStack)}");
            }

            if (greyTilesQueue.Count == 0)
            {
                Console.WriteLine("Grey tiles left: none");
            }
            else
            {
                Console.WriteLine($"Grey tiles left: {string.Join(", ", greyTilesQueue)}");
            }

            Dictionary<string, List<int>> orderedDictionary = 
                new Dictionary<string, List<int>>(kitchenAreas
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key));

            foreach (var area in orderedDictionary)
            {
                if (area.Value.Count > 0)
                {
                    Console.WriteLine($"{area.Key}: {area.Value.Count}");
                }
            }
        }
    }
}
