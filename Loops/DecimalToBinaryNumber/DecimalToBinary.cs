//Problem 14. Decimal to Binary Number

//Using loops write a program that converts an integer number to its binary representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

using System;

    class DecimalToBinary
    {
        static void Main()
        {
            Console.WriteLine("Please enter a decimal number:");
            long decimalNumber = long.Parse(Console.ReadLine());
            string binary = "";
            long divided;
           

            while (decimalNumber >= 1)
            {
                divided = decimalNumber / 2;
                binary += (decimalNumber % 2).ToString();
                decimalNumber =divided;
            }

            // Reversing the  value
            string theBinary = "";
            for (int i = binary.Length - 1; i >= 0; i--)
            {
                theBinary = theBinary + binary[i];

            }

            Console.WriteLine("The Binary format for given number is {0}", theBinary);
        }
    }

