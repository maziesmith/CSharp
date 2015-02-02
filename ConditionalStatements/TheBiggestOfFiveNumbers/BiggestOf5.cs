//Problem 6. The Biggest of Five Numbers

//Write a program that finds the biggest of five numbers by using only five if statements.

using System;
using System.Linq;

class BiggestOf5
{
    static void Main()
    {

        Console.WriteLine("Please enter five numbers separated by\",\":");
        string numbers = Console.ReadLine();       
        numbers.Trim();
        string[] arrayStringNumbers = numbers.Split(new Char[] { ',' });
        double[] theNumbers = arrayStringNumbers.Select(double.Parse).ToArray();
        double maxNumber = theNumbers.Max();
        double minNumber = theNumbers.Min();
        Console.WriteLine("The biggest number is {0} and the smallest is {1}", maxNumber, minNumber);
        

        //same with if 

        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        Console.Write("d = ");
        double d = double.Parse(Console.ReadLine());
        Console.Write("e = ");
        double e = double.Parse(Console.ReadLine());

        double biggest = a;

        if (b > biggest)
        {
            biggest = b;
        }
        if (c > biggest)
        {
            biggest = c;
        }
        if (d > biggest)
        {
            biggest = d;
        }
        if (e > biggest)
        {
            biggest = e;
        }
        Console.WriteLine("biggest: " + biggest);
    }
}

