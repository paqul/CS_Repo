using System;


namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Console App3!");
            Method1Maths(5, 10);
            Method2Strings();
            Console.ReadKey();
        }

        static void Method1Maths(int a, int b)
        {
            Console.WriteLine("Maths!");
            Console.WriteLine("Maximum: " + Math.Max(a, b));
            Console.WriteLine("Minimum: " + Math.Min(a, b));
            Console.WriteLine("Squarete of 36: " + Math.Sqrt(36));
        }

        static void Method2Strings()
        {
            Console.WriteLine("Strings!");
            string text = "Some text to work with it";
            Console.WriteLine(text);
            Console.WriteLine("And this is length of the text: " + text.Length + "\n");

        }
    }
}