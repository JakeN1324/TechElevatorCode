using System;
using System.Collections.Generic;
using System.IO;

namespace Lecture.Aids
{
    public static class WritingTextFiles
    {
        /*
        * This method below provides sample code for printing out a message to a text file.
        */
        public static void WritingAFile()
        {
            List<string> info = new List<string>();
            info.Add(DateTime.Now.ToString());
            info.Add("adfasdfasdfga");
            info.Add("fasdghrersdfgf");
            info.Add("asdfghjrrrfff");

            string path = "c:\\NicePlace\\OutputFile.txt";
            try
            {
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    foreach (string item in info)
                    {
                        sw.WriteLine(item);
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("An exception occured: " + ex.Message);
            }

            // After the using statement ends, file has now been written
            // and closed for further writing
        }
    }
}
