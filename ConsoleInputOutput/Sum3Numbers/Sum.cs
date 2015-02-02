//Problem 1. Sum of 3 Numbers

//Write a program that reads 3 real numbers from the console and prints their sum.

using System;

class Sum
{
    static void Main()
    {
        Console.WriteLine("Enter three number:");
        double firstNumber = double.Parse(Console.ReadLine());
        double secondNumber = double.Parse(Console.ReadLine());
        double thirdNumber = double.Parse(Console.ReadLine());
        double sum = firstNumber + secondNumber + thirdNumber;
        Console.WriteLine("The sum of the nnumbers is: "+sum);
    }
}

