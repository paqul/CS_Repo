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
            Method4Booleans();
            Method5IfElseStatement();
            Method6IfElseIfStatement();
            Method7ShortIfElseStatement(5);
            Method7ShortIfElseStatement(20);
            Method8SwitchStatement(5);
            Method8SwitchStatement(1);
            Method8SwitchStatement(7);
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
            string txt = "We are the so-called \"Vikings\" from the north.";
            string txt2 = "It\'s alright.";
            string txt3 = "The character \\ is called backslash.";
            Console.WriteLine(text);
            Console.WriteLine("And this is length of the text: " + text.Length + "\n");
            Console.WriteLine(text.ToUpper());
            Console.WriteLine(text.ToLower());
            Console.WriteLine(txt);
            Console.WriteLine(txt2);
            Console.WriteLine(txt3);

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

        static void Method4Booleans()
        {
            bool isCSharp = true;
            bool isPython = false;
            Console.WriteLine("\nBooleans!");
            Console.WriteLine("Is C# a programming language? " + isCSharp);
            Console.WriteLine("Is Python a programming language? " + isPython);

            int age = 25;
            int youngAge = 12;
            int votingAge = 18;
            Console.WriteLine(age >= votingAge ? "You are old enough to vote." : "You are not old enough to vote.");
            Console.WriteLine(youngAge >= votingAge ? "You are old enough to vote." : "You are not old enough to vote.");
        }

        static void Method5IfElseStatement()
        {
            int personAge = 31;
            int votingAge = 18;

            if (personAge >= votingAge)
            {
                Console.WriteLine("You are old enough to vote.");
            }
            else
            {
                Console.WriteLine("You are not old enough to vote.");
            }

        }
        static void Method6IfElseIfStatement()
        { 
            Console.WriteLine("\nIf, else if statement!");
            int x = 20;
            int y = 10;
            if (x > y)
            {
                Console.WriteLine("It is true that x is greater than y.");
            }

            int time = 22;
            if (4 < time && time < 12)
            {
                Console.WriteLine("Good morning!");
            }
            else if (11 < time && time < 20)
            {
                Console.WriteLine("Good day!");
            }
            else
            {
                Console.WriteLine("Good evening!");
            Console.WriteLine("The time is: " + time);
            }
        }

        static void Method7ShortIfElseStatement(int a)
        {
            Console.WriteLine("\nShort if else statement!");
            int time = 20;
            string result = time < 18 ? "Good day." : "Good evening.";
            Console.WriteLine(result);


            Console.WriteLine("\nShort if else statement with numbers!");
            bool result2 = ( a < 10 ) ? true : false;
            Console.WriteLine(Convert.ToString(result2));
        }

        static void Method8SwitchStatement(int day)
        {
            Console.WriteLine("\nSwitch statement!");
            switch (day)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day number.");
                    break;
            }
        }
        public static void Method9SwitchExp(int x)
        {
            Console.WriteLine("\nSwicht expression!");
            
            switch (x)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
            }
        }
    }
}