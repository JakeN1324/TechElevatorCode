using System;

namespace TempConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a temperature value to convert:");
            int tempInput = Convert.ToInt32(Console.ReadLine());
            Console.Write("Is the temperature in (C)elsius or (F)ahrenheit");
            string cOrF = Console.ReadLine();

            if (cOrF == "C") 
            {
                int nowFahrenheit = (int)(tempInput * 1.8 + 32);
                Console.WriteLine("Your temperature in fahrenheit is " + nowFahrenheit);
            }
            else if (cOrF == "F")
            {
                int nowCelsius = (int)(((tempInput - 32) / 1.8));
                Console.WriteLine("Your temperature in fahrenheit is " + nowCelsius + " degrees");
            }
            
        }
    }
}
