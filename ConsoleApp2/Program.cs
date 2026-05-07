using System;
using System.Runtime.ExceptionServices;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from ConsoleApp2!");
            //Method1Inputs(args);
            Method2AritmeticOperators(40);
            Method3Assigment(args);
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

        static void Method2AritmeticOperators(int args)
        {
            Console.WriteLine("Method 2");
            int sum1 = 100 + args;
            int sum2 = sum1 + 60;
            int sum3 = sum2 + 1;
            int diff = sum3 - 100;
            int multi = diff * 2;
            int div = multi / 2;
            int mod = div % 3;
            int incrementation = sum1++;
            int decrementation = sum2--;
            Console.WriteLine(sum1 + "\n" + sum2 + "\n" + sum3 + "\n" + diff + "\n" + multi + "\n" + div + "\n" + mod + "\n" + incrementation + "\n" + decrementation);
            Console.WriteLine("End of Method 2");
        }

        static void Method3Assigment(string[] args)
        {
            Console.WriteLine("Method 3");
            int x = 10;
            int y = 10;
            int c = 10;
            x += 5;
            Console.WriteLine("x: " + x);
            Console.WriteLine("y: " + y);
            int first = x -= 8;
            Console.WriteLine("first: " + first);
            int second = y *= 2;
            Console.WriteLine("second: " + second);
            int third = y /= 2;
            Console.WriteLine("third: " + third);
            int fourth = c *= 3;
            Console.WriteLine("fourth: " + fourth);

            int z = 5;
            z %= 3; // Module 5/3 = 1,666, so in 5 exist 1 module of 3, and rest is equal 2;
            Console.WriteLine($"Module {z}, due to 5/3 = 1.666, rest is 2");

            int zz = 5;
            zz &= 3; // Bitwise AND 5 & 3 = 1, because in binary 5 is 101 and 3 is 011, so only the last bit is 1 in both numbers
            Console.WriteLine($"Bitwise AND {zz}, due to 5 & 3 = 1, because in binary 5 is 101 and 3 is 011, so only the last bit is 1 in both numbers");

            int zzz = 5;
            zzz |= 3; // Bitwise OR 5 | 3 = 7, because in binary 5 is 101 and 3 is 011, so all bits are 1 in both numbers
            Console.WriteLine($"Bitwise OR {zzz}, due to 5 | 3 = 7, because in binary 5 is 101 and 3 is 011, so all bits are 1 in both numbers");

            int yy = 5;
            yy ^= 3; // Bitwise XOR 5 ^ 3 = 6, because in binary 5 is 101 and 3 is 011, so only the last bit is different in both numbers
            Console.WriteLine($"Bitwise XOR {yy}, due to 5 ^ 3 = 6, because in binary 5 is 101 and 3 is 011, so only the last bit is different in both numbers");

            int xx = 5;
            xx >>= 1; // Bitwise Right Shift 5 >> 1 = 2, because in binary 5 is 101, so shifting right by 1 bit gives us 10, which is 2 in decimal
            Console.WriteLine($"Bitwise Right Shift {xx}, due to 5 >> 1 = 2, because in binary 5 is 101, so shifting right by 1 bit gives us 10, which is 2 in decimal");

            int xxx = 5;
            xxx <<= 1; // Bitwise Left Shift 5 << 1 = 10, because in binary 5 is 101, so shifting left by 1 bit gives us 1010, which is 10 in decimal
            Console.WriteLine($"Bitwise Left Shift {xxx}, due to 5 << 1 = 10, because in binary 5 is 101, so shifting left by 1 bit gives us 1010, which is 10 in decimal");
            Console.WriteLine("End of Method 3");

        }
    }
}
