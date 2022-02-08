using System;
using System.IO;

namespace FindAndReplace
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is the search word?");
            string searchWord = Console.ReadLine();

            Console.WriteLine("What is the replacement word?");
            string replacementWord = Console.ReadLine();

            try
            {
                Console.WriteLine("What is the source file path?");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured while reading the file.");
                Console.WriteLine(e.Message);
            }
            string sourceFile = Console.ReadLine();

            try
            {
                Console.WriteLine("What is the destination file path?");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured while reading the file.");
                Console.WriteLine(e.Message);
            }
            string destinationFile = Console.ReadLine();

            using (StreamReader sr = new StreamReader(sourceFile))
            {
                using (StreamWriter sw = new StreamWriter(destinationFile))
                {
                    while(!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string newLine = line.Replace(searchWord, replacementWord);
                        sw.WriteLine(newLine);
                    }
                }
            }

        }
    }
}
