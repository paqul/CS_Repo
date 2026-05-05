using System;

namespace HellowWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Multi
             * line
             * comment
             */
            //Comments
            Console.WriteLine("Hello World");
            Method1Types();
            Console.WriteLine(3 + 3 * 2);
            Console.ReadKey();
            Console.Write("End of the main");
            Console.ReadKey();
        }

        static void Method1Types()
        {
            Console.WriteLine("Method 1");
            string name = "Greg";
            int myIntNum = 127;
            double myDoubleNum = 3.14;
            myIntNum = 12;

            Console.WriteLine(name);
            Console.WriteLine(myIntNum);
            Console.WriteLine(myDoubleNum);
            Console.WriteLine("End of Method 1");
        }   
    }
}