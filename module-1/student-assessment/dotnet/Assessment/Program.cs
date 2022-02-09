using Assessment.Models;
using System;

namespace Assessment
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an object and call methods on it
            // (manual testing) from this class.

            WorkOrder firstClient = new WorkOrder("Bill", 50, 20);

            Console.WriteLine(firstClient.ActualTotal(true, true));
           
    }
    }
}
