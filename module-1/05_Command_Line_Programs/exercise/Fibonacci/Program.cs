using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please enter a number: ");
            int stopPoint = int.Parse(Console.ReadLine());
            int current = 0;
            int result = 1;

            if (stopPoint == 0 || stopPoint < 0)
            {
                Console.WriteLine("0, 1");
            }
            else if (stopPoint == 1)
            {
                Console.WriteLine("0, 1, 1");
            }
            else
            {
                Console.Write("0 ");
                while (current <= stopPoint) 
                {
                    int tempValue = current;
                    current = result;
                    result = tempValue + result;
                    if (current <= stopPoint)
                    {
                        Console.Write(current + " ");
                    }
                    else
                    {
                        break;
                    }
                }
            }

        }
    }
}
