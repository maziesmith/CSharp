//Problem 3. Circle Perimeter and Area

//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.

using System;

class CirclePS
{
    static void Main()
    {
        Console.WriteLine("Please enter the radius of the circle:");
        double r = double.Parse(Console.ReadLine());
        double pi = Math.PI;
        double perimeter = 2*pi*r;
        double area = pi*(Math.Pow(r,2));
        Console.WriteLine("The perimeter of the circle is {0:0.00} and the area is {1:0.00}",perimeter,area);  
            
    }
}

