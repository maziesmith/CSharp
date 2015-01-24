//Problem 8. Prime Number Check

//Write an expression that checks if given positive integer number n (n <= 100) is prime (i.e. it is divisible without remainder only to itself and 1).
//Note: You should check if the number is positive

using System;

class PrimeNumber
{
    static void Main()
    {
        Console.Write("Enter a Number : ");
        int number;
        number = Convert.ToInt32(Console.ReadLine());
        int counter;
        counter = 0;
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                counter++;
            }
        }
        if (counter == 2)
        {
            Console.WriteLine("Entered Number is a Prime Number and the Largest Factor is {0}", number);
        }
        else
        {
            Console.WriteLine("Not a Prime Number");
        }
      
    }
}

