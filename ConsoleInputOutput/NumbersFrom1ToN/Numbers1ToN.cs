//Problem 8. Numbers from 1 to n

//Write a program that reads an integer number n from the console and prints all the numbers in the interval [1..n], each on a single line.
//Note: You may need to use a for-loop.

using System;

class Numbers1ToN
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int n = int.Parse(Console.ReadLine());
        for (int i=1; i<=n; i++)
        {
            Console.Write(" {0} ",i);
        }
    }
}

