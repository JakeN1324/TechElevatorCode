using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a series of decimal integer values (separated by spaces): ");
            string userInput = Console.ReadLine();
            string[] numbersArray = userInput.Split(" ");
            int remainder;
            

            for (int i = 0; i < numbersArray.Length; i++)
            {
                int tempValue = int.Parse(numbersArray[i]);
                string binaryResult = string.Empty;

                while (tempValue > 0)
                {
                    remainder = tempValue % 2;
                    tempValue /= 2;
                    binaryResult = remainder.ToString() + binaryResult;
                }
                Console.WriteLine(numbersArray[i] + " in binary is " + binaryResult);
            } 
        }
    }
}
