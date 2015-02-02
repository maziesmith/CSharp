//Problem 7. Calculate N! / (K! * (N-K)!)

//In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
//Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.
//Examples:

//n	 k	n! / (k! * (n-k)!)
//3  2	3
//4	 2	6
//10 6	210
//52 5	2598960

using System;
using System.Numerics;

class Combinations
{
    static void Main()
    {
        int k = 5;
        int n = 20;
        int nk = n - k;
        BigInteger factorialN = 1;
        BigInteger factorialK = 1;
        BigInteger factorialNK = 1;
        decimal divider = 1;
        BigInteger expression = 1;
        decimal combination = 1;
        for (int i = 1, j = 1; i <= n || j <= k; i++, j++)
        {
            factorialN *= i;

            if (j <= k)
            {
                factorialK *= j;
            }
            else { continue; }
        }
        expression =factorialN / factorialK;
       
        
        for (int i = 1; i <= nk; i++)
        {
            factorialNK *= i;
        }
        Console.WriteLine(factorialNK);
         divider = 1 /(decimal)factorialNK;   
        Console.WriteLine(divider);
        combination = (decimal)expression * divider;
        Console.WriteLine(combination);
    }
}

