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
            Method3Math();
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

        static void Method3Math()
        {
            float a = 4.95f;
            double b = 9.21;
            Console.WriteLine("Maths again!");
            Console.WriteLine("Pi: " + Math.PI);
            Console.WriteLine("E: " + Math.E);
            Console.WriteLine("float 4,95: " + Math.Round(a));
            Console.WriteLine("double 9,21: " + Math.Round(b));
            Console.WriteLine("Absolute of -5: " + Math.Abs(-5));
            Console.WriteLine("Absolute of 20: " + Math.Abs(20));

        }
    }
}