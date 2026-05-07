using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from ConsoleApp2!");
            Method1Inputs(args);
            Console.WriteLine("End of ConsoleApp2!");
            Console.ReadKey();

        }

        static void Method1Inputs(string[] args)
        {
            Console.WriteLine("Method 1");
            Console.WriteLine("Enter Something: ");
            string something = Console.ReadLine();
            Console.WriteLine("Something is: " + something);
            Console.WriteLine("\nEnter a number: ");
            string numberStr = Console.ReadLine();
            int number = Convert.ToInt32(numberStr);
            Console.WriteLine("Number is: " + number);
            Console.WriteLine("End of Method 1");
        }
    }
}
