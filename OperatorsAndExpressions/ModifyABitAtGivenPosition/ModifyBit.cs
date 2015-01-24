//Problem 14. Modify a Bit at Given Position

//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold 
//the value v at the position p from the binary representation of n while preserving all other bits in n.

using System;

    class ModifyBit
    {
        static void Main()
        {
            Console.WriteLine("Enter the integer number:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the position of the bit:");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the value of bit:");
            int valueBit = int.Parse(Console.ReadLine());
            if (valueBit == 0)
            {
                int mask = ~(1 << p);
                int result = n & mask;
                Console.WriteLine(result);
            }
            else
            {
                int mask = 1 << p;
                int result = n | mask;
                Console.WriteLine(result);
            }
        }
    }

