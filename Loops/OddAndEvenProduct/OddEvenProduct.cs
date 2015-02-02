//Problem 10. Odd and Even Product

//You are given n integers (given in a single line, separated by a space).
//Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
//Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
//Examples:

//numbers	   result
//2 1 1 6 3	       yes
//product = 6
	
//3 10 4 6 5 1	     yes
//product = 60
	
//4 3 2 5 2	          no
//odd_product = 16	
//even_product = 15	


using System;
using System.Linq;

class OddEvenProduct
{
    static void Main()
    
    {
        Console.WriteLine("Please enter some numbers(integers!) ");
        string numbers = Console.ReadLine();
        numbers.Trim();
        string[] arrayStringNumbers = numbers.Split(new Char[] { ' ' });
        int[] theNumbers = arrayStringNumbers.Select(int.Parse).ToArray();
        Console.WriteLine("Your numbers:");
        foreach(int number in theNumbers)
        {
            Console.Write(" "+number);
        }
        int evenSum =0;
        int oddSum = 0;
        int length = theNumbers.Length;
        Console.WriteLine();
        Console.WriteLine("The length: "+length);
        for (int i = 0; i < length; i+=2)
        {
            oddSum = oddSum + theNumbers[i];
        }
        Console.WriteLine("The sum of the odds: "+oddSum);
        for(int i =1; i< length; i+=2)
        {
            evenSum = evenSum + theNumbers[i];
        }
        Console.WriteLine("The sum of the evens: "+evenSum);
        if (oddSum == evenSum)
        {
            Console.WriteLine("Yes, the odd`s sum is equal to the even`s.");
        }
        else
        {
            Console.WriteLine("No, the sums are not equal.");
        }
    }
}

