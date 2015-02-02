//Problem 8. Catalan Numbers

//In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
//Write a program to calculate the nth Catalan number by given n (1 <= n <= 100).
//Examples:

//n	Catalan(n)
//0	     1
//5	     42
//10	16796
//15	9694845


using System;
using System.Numerics;

class Catalan
{
    static void Main()
    {
        int n = 20;
        BigInteger factorialN = 1;
        BigInteger factorialN1 = 1;
        BigInteger factorial2N = 1;
        BigInteger catalan = 1;
        for (int i = 1; i <= n; i++)
        {
            factorialN *= i;
            factorialN1 = (n + 1) * factorialN;          
        }
        for (int j = 1; j <= (2 * n); j++)
        {
            factorial2N *= j;
        }
        catalan = factorial2N / (factorialN * factorialN1);
        Console.WriteLine(catalan);
    }
}

