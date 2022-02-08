using System;
using System.IO;

namespace WordSearch
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //1. Ask the user for the file path
            Console.WriteLine("Enter the file path to search: ");
            string filePath = @"C:\Temp\alices_adventures_in_wonderland.txt"; //This would normally have the value of the user's chosen file path

            //2. Ask the user for the search string
            Console.WriteLine("What is the search word you are looking for?: ");
            string searchWord = Console.ReadLine();

            bool isCaseSensitive = true;


            Console.WriteLine("Should the search be case sensitive? (Y/N): ");
            if (Console.ReadLine() == "N")
            {
                isCaseSensitive = false;
                searchWord = searchWord.ToLower();
            }
            



            //3. Open the file

            //4. Loop through each line in the file
            int lineNumber = 1;
            try
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    Console.WriteLine("Here are the lines containing your search word: ");
                    if (isCaseSensitive == false)
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            line = line.ToLower();
                            if (line.Contains(searchWord))
                            {
                                Console.WriteLine(lineNumber.ToString() + ": " + line);
                            }
                            lineNumber++;
                        }

                    }
                    else
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            if (line.Contains(searchWord))
                            {
                                Console.WriteLine(lineNumber.ToString() + ": " + line);
                            }
                            lineNumber++;
                        }
                    }

                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured while reading the file.");
                Console.WriteLine(e.Message);
            }
            //5. If the line contains the search string, print it out along with its line number
        }
    }
}
