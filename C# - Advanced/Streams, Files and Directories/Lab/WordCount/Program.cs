namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\words.txt";
            string textPath = @"..\..\..\text.txt";
            string outputPath = @"..\..\..\output.txt";

            CalculateWordCounts(wordPath, textPath, outputPath);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath)
        {
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            StreamReader reader = new StreamReader(wordsFilePath);
            using (reader)
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] wordsToLookFor = line.Split();
                    for (int i = 0; i < wordsToLookFor.Length; i++)
                    {
                        if (!dictionary.ContainsKey(wordsToLookFor[i]))
                        {
                            dictionary.Add(wordsToLookFor[i], 0);
                        }
                    }
                }
            }

            reader = new StreamReader(textFilePath);
            using (reader)
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] lineArray = line.Split(); // No clue how to split the line
                }
            }
        }
    }
}
