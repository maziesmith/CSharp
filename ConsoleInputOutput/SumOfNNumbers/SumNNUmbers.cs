//Problem 9. Sum of n Numbers

//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.

using System;
using System.Linq;

class SumNNUmbers
{
    static void Main()
    {
        Console.WriteLine("How many numbers do you want to sum?");
        int counter = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter {0} numbers:",counter);
        string numbers = Console.ReadLine();
        string[] arrayStringNumbers = numbers.Split(new Char[] { ' ' });
        double[] theNumbers = arrayStringNumbers.Select(double.Parse).ToArray();
        double sum = theNumbers.Sum();
        Console.WriteLine("The sum of the numbers is :" + sum);

        
    }
}
// wtf if you enter a space after the last number the program crashes
