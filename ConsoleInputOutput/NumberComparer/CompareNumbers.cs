//Problem 4. Number Comparer

//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.

using System;

    class CompareNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter number a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter number b:");
            double b = double.Parse(Console.ReadLine());
            double result = Math.Max(a,b)
            Console.WriteLine("greater {0}", result);
        }

    }

