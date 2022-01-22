using System;

namespace PetSplit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter several words seperated by spaces: ");
            //primpt the user to enter several words seperated by spaces

            //read in the string
            string userInput = Console.ReadLine();
            //split the string to an array
            string[] words = userInput.Split(" ");
            //loop through the array and display the results, on eline at a time.
            Console.WriteLine();
            Console.WriteLine("Here are the words entered: ");
        
            
            for (int i = 0; i < words.Length; i++)
            {
                Console.WriteLine(words[i]);
            }
            Console.WriteLine("Thank you for using our program.");
        }

    }
}
