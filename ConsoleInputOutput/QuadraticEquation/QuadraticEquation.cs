//Problem 6. Quadratic Equation

//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).

using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.WriteLine("Enter the coefficients a,b,c of your equation:");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double D = b * b - 4 * a * c;
        if (D > 0)
        {
            double X1 = (-b + Math.Sqrt(D)) / 2 * a;
            double X2 = (-b - Math.Sqrt(D)) / 2 * a;
            Console.WriteLine("X1={0} , X2 = {1}", X1, X2);
        }
        else if (D==0)
        {
            double X = (-b) / 2 * a;
            Console.WriteLine("X1=X2={0}",X);
        }
        else if (D<0)
        {
            Console.WriteLine("The quadratic equation has no real solutions.");
        }
    }
}

