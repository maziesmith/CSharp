//Problem 16. Decimal to Hexadecimal Number

//Using loops write a program that converts an integer number to its hexadecimal representation.
//The input is entered as long. The output should be a variable of type string.
//Do not use the built-in .NET functionality.

using System;

    class DecimalToHex
    {
        static void Main()
        {
           
             Console.WriteLine("Enter a decimal number: ");
            long decimalNumber = long.Parse(Console.ReadLine());
            string hexNumber = String.Empty;
            if (decimalNumber != 0)
            {
                while (decimalNumber > 0)
                {
                    long remainder = decimalNumber % 16;
                    switch (remainder)
                    {
                        case 10: hexNumber += "A"; break;
                        case 11: hexNumber += "B"; break;
                        case 12: hexNumber += "C"; break;
                        case 13: hexNumber += "D"; break;
                        case 14: hexNumber += "E"; break;
                        case 15: hexNumber += "F"; break;
                        default: hexNumber += remainder.ToString(); break;
                    }

                    decimalNumber /= 16;
                }

                for (int i = hexNumber.Length - 1; i >= 0; i--)
                {
                    Console.Write(hexNumber[i]);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(0);
            }
        }
           
    }

