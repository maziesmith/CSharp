//Problem 1. Numbers from 1 to N

//Write a program that enters from the console a positive integer n and prints all the numbers from 1 to n, on a single line, separated by a space.

using System;

    class Numbers1ToN

    {
        static void Main()
        {
            Console.WriteLine("Choose a number:");
            int n = int.Parse(Console.ReadLine());

            //with for loop:
            for (int i = 0; i <= n; i++)
            {
                Console.Write("{0} ",i);
            }
            Console.WriteLine();
            
            //with while loop
            int counter = 0;
            while (counter <= n)
            {
                Console.Write("{0} ",counter);
                counter++;
            }
            Console.WriteLine();

            //with do...while loop:
            int anotherCounter = 0;
            do
            {
                Console.Write("{0} ", anotherCounter);
                anotherCounter++;
            }
            while (anotherCounter <= n);
        }
    }

