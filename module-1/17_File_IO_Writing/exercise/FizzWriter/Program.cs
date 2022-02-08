using System;
using System.Collections.Generic;
using System.IO;
namespace FizzWriter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
            Console.WriteLine("What is the destination file path?");

            }
            catch (IOException e)
            {
                Console.WriteLine("There was an error reading the file path.");
                Console.WriteLine(e.Message);
            }
            string destinationFile = Console.ReadLine();

            List<double> numberList = new List<double>();
            for (int i = 1; i < 301; i++)
            {
                numberList.Add(i);
            }
            
            using (StreamWriter sw = new StreamWriter(destinationFile))
            {
                foreach(double number in numberList)
                {
                    if (number % 3 == 0 && number % 5 == 0)
                    {
                        sw.WriteLine("FizzBuzz");
                    }
                    else if (number % 3 == 0)
                    {
                        sw.WriteLine("Fizz");
                    }
                    else if (number % 5 == 0)
                    {
                        sw.WriteLine("Buzz");
                    }
                    else
                    {
                        sw.WriteLine(number);
                    }
                }
            }
            


        }
    }
}
