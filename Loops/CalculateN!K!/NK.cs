//Problem 6. Calculate N! / K!

//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.
//Examples:

//n	k	n! / k!
//5	2	60
//6	5	6
//8	3	6720

using System;

class NK
{
    static void Main()
    {
        int n = 8;
        int k = 3;
        int factorialN = 1;
        int factorialK = 1;
        int expression = 0;
        int i=1;
        int j = 1;
        for (i = 1, j = 1; i<=n || j<=k; i++, j++)
        {
            factorialN *= i;

            if(j<=k)
            {
                factorialK *= j;
             
            }
            else { continue; }
        }
        expression = factorialN / factorialK;
        Console.WriteLine(expression);
    }
}

