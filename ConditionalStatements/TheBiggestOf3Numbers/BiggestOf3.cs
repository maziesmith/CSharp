//Problem 5. The Biggest of 3 Numbers

//Write a program that finds the biggest of three numbers.

using System;

    class BiggestOf3
    {
        static void Main()
        {
            Console.WriteLine("Please enter a number:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter another number:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Please enter a third number:");
            double c = double.Parse(Console.ReadLine());
            double max = 0;
            if (a < b)
            {
                max = b;
                if (c >= max)
                {
                    max = c;
                }
                else
                {
                    max = b;
                }
            }
            else if (a == b)
            {
                max = a = b;
                if (c >= max)
                {
                    max = c;
                }
                else
                {
                    max = b = a;
                }
            }
            else
            {
                max = a;
                if (c >= max)
                {
                    max = c;
                }
                else
                {
                    max = a;
                }
            }
            Console.WriteLine("The biggest is: "+max);
        }
    }

