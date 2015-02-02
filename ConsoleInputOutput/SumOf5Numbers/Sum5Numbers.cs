//Problem 7. Sum of 5 Numbers

//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.

using System;
using System.Linq;

class Sum5Numbers
{
    static void Main()
    {
        Console.WriteLine("Enter 5 numbers:");
        string numbers = Console.ReadLine();
        string[] arrayStringNumbers = numbers.Split(new Char[] { ' ' });
        double[] theNumbers = arrayStringNumbers.Select(double.Parse).ToArray();
        double sum = theNumbers.Sum();
        Console.WriteLine("The sum of the numbers is :"+sum);
    }
}
// wtf if you enter a space after the last number the program crashes