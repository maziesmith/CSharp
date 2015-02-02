//Problem 1. Exchange If Greater

//Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. 
//As a result print the values a and b, separated by a space.

using System;

    class ExchangeValues
    {
        static void Main()
        {
            double a = 3.9;
            double b = 1.3;
            Console.WriteLine("a="+a);
            Console.WriteLine("b="+b);
            if (a>b)
            {
                a = a + b;
                b = a - b;
                a = a - b;
                Console.WriteLine("a="+a);
                Console.WriteLine("b="+b);

            }
            else
            {
                Console.WriteLine("a=" + a);
                Console.WriteLine("b=" + b);
            }
        }
    }

