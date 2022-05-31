using System;
using System.IO;

namespace OddLines
{
    public class OddLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\Files\input.txt";
            string outputFilePath = @"..\..\..\Files\output.txt";

            ExtractOddLines(inputFilePath, outputFilePath);
        }

        public static void ExtractOddLines(string inputFilePath, string outputFilePath)
        {
            StreamReader reader = new StreamReader(inputFilePath);
            using (reader)
            {
                while (true)
                {
                    StreamWriter writer = new StreamWriter(outputFilePath);
                    using (writer)
                    {
                        int lineNumber = 0;
                        while (true)
                        {
                            string line = reader.ReadLine();
                            if (line == null)
                            {
                                break;
                            }
                            if (lineNumber % 2 == 1)
                            {
                                writer.WriteLine(line);
                            }
                            lineNumber++;
                        }
                    }
                    
                }
            }
        }

    }
}