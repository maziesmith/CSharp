//Problem 10. Fibonacci Numbers

//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence 
//(at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
//Note: You may need to learn how to use loops.

using System;

class Fibonacci
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int n = int.Parse(Console.ReadLine());
        int[] number = new int[n];
        number[0] = 0;
        number[1] = 1;
        number[2] = 1;
        int index = 0;
        for (index = 3; index<n; index++)
        {
            number[index] = number[index - 1] + number[index - 2];
            
        }
        Console.WriteLine(string.Join(", ", number));
    }
}

