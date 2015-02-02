//Problem 4. Multiplication Sign

//Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
//Use a sequence of if operators.

using System;

class ProductSign
{
    static void Main()
    {
        Console.WriteLine("Please enter a number:");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter another number:");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Please enter a third number:");
        double c = double.Parse(Console.ReadLine());

        if (a==0 || b==0 || c==0)
        {
            Console.WriteLine("The product of your numbers is: 0");
        }

        else if ((a < 0 && b < 0 && c < 0) || (a < 0 && b > 0 && c > 0) || (a > 0 && b < 0 && c > 0) || (a > 0 && b > 0 && c < 0))
        {
            Console.WriteLine("The product of your numbers is: -  (negative)");
        }
        else
        {
            Console.WriteLine("The product of your numbers is: +  (positive)");
        }

    }
}

