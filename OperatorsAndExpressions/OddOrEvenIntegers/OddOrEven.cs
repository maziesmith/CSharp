//Problem 1. Odd or Even Integers

//Write an expression that checks if given integer is odd or even.

using System;

    class OddEven
    {
        static void Main()
        {
            //Check whether a number is odd or even using %-division
            int number1 = 5;
            int number2 = 4;
            int number3 = 9;
            string odd = "odd";
            string even = "even";
            if (number1%2==0)
            {
                Console.WriteLine(number1+"-"+even);
            }
            else
            {
                Console.WriteLine(number1+"-"+odd);
            }
            if (number2%2==0)
            {
                Console.WriteLine(number2+"-"+even);
            }
            else
            {
                Console.WriteLine(number2+"-"+odd);
            }
            if (number3 % 2 == 0)
            {
                Console.WriteLine(number3+"-"+even);
            }
            else
            {
                Console.WriteLine(number3+"-"+odd);
            }

            //Check whether a number is odd or even using bitwise operators

            int x = 199999;   
            if((x & 1) == 0)
            {
                Console.WriteLine(x+" is even");
            }
            else
            {
                Console.WriteLine(x+" is odd");
            }
            Console.WriteLine("Binary representation of "+x+": " + Convert.ToString(x, 2).PadLeft(32, '0'));
        }
    }

