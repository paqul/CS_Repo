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
            Method2Name();
            Console.WriteLine(3 + 3 * 2);
            Console.ReadKey();
            Console.Write("End of the main");
            Console.ReadKey();
        }

        static void Method1Types()
        {
            Console.WriteLine("Method 1");
            string name = "Greg ";
            string lastName = "Smith";
            int myIntNum = 127;
            double myDoubleNum = 3.14D;
            float myFloatNum = 3.14F;
            long myLongNum = 999999999999999999L;
            myIntNum = 12;
            char myCharacter = 'A';
            bool myBool = true;

            Console.WriteLine(name + lastName);
            Console.WriteLine(myIntNum);
            Console.WriteLine(myDoubleNum);
            Console.WriteLine(myFloatNum);
            Console.WriteLine(myLongNum);
            Console.WriteLine(myCharacter);
            Console.WriteLine(myBool);
            Console.WriteLine("End of Method 1");
        }

        static void Method2Name()
        {
            Console.WriteLine("Method 2");
            int myIntNum = 12;
            int x, y, z;
            x = y = z = 10;
            Console.WriteLine(x+y+z+myIntNum);
            Console.WriteLine("End of Method 2");
        }
    }
}