//Problem 7. Sort 3 Numbers with Nested Ifs

//Write a program that enters 3 real numbers and prints them sorted in descending order.
//Use nested if statements.
//Note: Don’t use arrays and the built-in sorting functionality.

using System;

class SortWithNestedIF
{
    static void Main()
    {
        Console.WriteLine("a=");
        Console.WriteLine("b=");
        Console.WriteLine("c=");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
         if (a>b)
         {
             if (c > a)
             {
                 Console.WriteLine("{0}>{1}>{2}", c, a, b);
             }
             else if (c == a)
             {
                 Console.WriteLine("{0}={1}>{2}", c, a, b);
             }
             else if (c < a && c > b)
             {
                 Console.WriteLine("{0}>{1}>{2}", a, c, b);
             }
             else if (c < a && c == b)
             {
                 Console.WriteLine("{0}>{1}={2}", a, c, b);
             }
             else if (c < a && c < b)
             {
                 Console.WriteLine("{0}>{1}>{2}", a, b, c);
             } 
         }
         else if (a==b)
         {
             if (c > a)
             {
                 Console.WriteLine("{0}>{1}={2}", c, a, b);
             }
             else if (c == a)
             {
                 Console.WriteLine("{0}={1}={2}", c, a, b);
             }
             else if (c < a)
             {
                 Console.WriteLine("{0}={1}>{2}", a, b, c);
             }
         }
         else if (b > a)
         {
             if (c > b)
             {
                 Console.WriteLine("{0}>{1}>{2}", c, b, a);
             }
             else if (c == b)
             {
                 Console.WriteLine("{0}={1}>{2}", c, b, a);
             }
             else if (c < b && c > a)
             {
                 Console.WriteLine("{0}>{1}>{2}", b, c, a);
             }
             else if (c < b && c == a)
             {
                 Console.WriteLine("{0}>{1}={2}", b, c, a);
             }
             else if (c < b && c < a)
             {
                 Console.WriteLine("{0}>{1}>{2}", b, a, c);
             } 
         }

    }
}

