using System;

namespace LinearConvert
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a length to convert: ");
            int initialLength = Convert.ToInt32(Console.ReadLine());
            Console.Write("Is the length in (m)eters or (f)eet?: ");
            string metersOrFeet = Console.ReadLine();

            if (metersOrFeet == "f")
            {
                int nowMeters = (int)(initialLength * 0.3048);
                Console.WriteLine(initialLength + "f is " + nowMeters + "m");
            }
            else if (metersOrFeet == "m")
            {
                int nowFeet = (int)(initialLength * 3.2808399);
                Console.WriteLine(initialLength + "m is " + nowFeet + "f");
            }
        }
    }
}
