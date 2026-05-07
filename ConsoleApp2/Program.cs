using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from ConsoleApp2!");
            Console.WriteLine("Enter Something: ");
            string something = Console.ReadLine();
            Console.WriteLine("Something is: " + something);
            Console.WriteLine("\nEnter a number: ");
            string numberStr = Console.ReadLine();
            int number = Convert.ToInt32(numberStr);
            Console.WriteLine("Number is: " + number);
        }
    }
}
