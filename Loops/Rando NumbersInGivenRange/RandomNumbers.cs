//Problem 11. Random Numbers in Given Range

//Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].

using System;


    class RandomNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter an integer:");
            int min = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter bigger integer: ");
            int max = int.Parse(Console.ReadLine());
            Console.WriteLine("How many numbers do you want?");
            int n = int.Parse(Console.ReadLine());
            Random randomNumber = new Random();
            for (int i = 0; i <= n; i++)
            {               
                int randomN = randomNumber.Next(min, max);
                Console.Write(" "+randomN);
            }
            Console.WriteLine();
        }
    }

