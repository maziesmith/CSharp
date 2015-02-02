//Problem 13. Binary to Decimal Number

//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

using System;
using System.Linq;
using System.Globalization;

class BinaryToDecimal
{
    static void Main()  
    {
        Console.WriteLine("Please enter a binary number:");
        string stringBinaryNumber = Console.ReadLine();
        int[] arrayBinaryNumber = new int[stringBinaryNumber.Length];
        for (int i = 0; i < stringBinaryNumber.Length; i++)
        {

            arrayBinaryNumber[i] = Convert.ToInt32(stringBinaryNumber[i].ToString());

        }
        int[] reverseBinary = arrayBinaryNumber.Reverse().ToArray();
       
       
            long decimalNumber = 0;
            
            for (int bit =0, pow = 0; bit < reverseBinary.Length; bit++, pow++)
            {
                decimalNumber += (reverseBinary[bit]) * (long)Math.Pow(2, pow);
            }
            Console.WriteLine("The decimal: "+decimalNumber);
       
    }
}

