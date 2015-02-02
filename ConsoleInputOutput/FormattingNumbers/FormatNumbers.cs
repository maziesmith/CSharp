//Problem 5. Formatting Numbers

//Write a program that reads 3 numbers:
//integer a (0 <= a <= 500)
//floating-point b
//floating-point c
//The program then prints them in 4 virtual columns on the console. Each column should have a width of 10 characters.
//The number a should be printed in hexadecimal, left aligned
//Then the number a should be printed in binary form, padded with zeroes
//The number b should be printed with 2 digits after the decimal point, right aligned
//The number c should be printed with 3 digits after the decimal point, left aligned.

using System;
using System.Globalization;

class FormatNumbers
{
    static void Main()
    {

        int a = 13;
        string binaryA = Convert.ToString(a,2);
        float b = 7.77896f;
        float c = 11.25698f;
        Console.WriteLine("Here are three numbers:{0} {1} {2}",a,b,c);
        Console.WriteLine("{0,-10:X} | {1,-10:B} | {2,10:0.00} |  {3,-10:0.F3}", a,binaryA,b,c);
        
        int d = 5;
        string binaryD = Convert.ToString(d, 2);
        float e = 3.4222f;
        float f = 14.898989f;      
        Console.WriteLine("{0,-10:X} | {1,-10:B} | {2,10:0.00} |  {3,-10:0.F3}", d, binaryD, e, f);

        int h = 78;
        string binaryH = Convert.ToString(h, 2);
        float i = -4.5698f;
        float j = -12.3f;
        Console.WriteLine("{0,-10:X} | {1,-10:B} | {2,10:0.00} | {3,-10:0.F3}", h, binaryH, i, j);
    }
}

