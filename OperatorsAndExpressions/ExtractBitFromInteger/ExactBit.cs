//Problem 12. Extract Bit from Integer

//Write an expression that extracts from given integer n the value of given bit at index p.

using System;

    class ExactBit
    {
        static void Main()
        {
            Console.WriteLine("Enter the integer number:");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(Convert.ToString(n,2));
            Console.WriteLine("Choose the position of the bit:");
            int p = int.Parse(Console.ReadLine());
            int nRightP = n >> p;
            int bit = nRightP & 1;
            Console.WriteLine(bit);    
        }
    }

