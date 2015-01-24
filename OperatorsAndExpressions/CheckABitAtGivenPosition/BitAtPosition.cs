//Problem 13. Check a Bit at Given Position

//Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.

using System;

    class BitAtPosition
    {
        static void Main()
        {
            Console.WriteLine("Enter the integer number:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(n, 2));
            Console.WriteLine("Choose the position of the bit:");
            int p = int.Parse(Console.ReadLine());
            int nRightP = n >> p;
            int bit = nRightP & 1;
            bool isOne = (bit == 1);
            Console.WriteLine(isOne);    
        }
    }

