//Problem 4. Rectangles

//Write an expression that calculates rectangle’s perimeter and area by given width and height.

using System;

    class Rectangles
    {
        static void Main()
        {
            Console.WriteLine("Enter the height of the rectangle:");
            double height = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the weigth of the rectangle:");
            double weigth = int.Parse(Console.ReadLine()); 
            if(height !=0 && weigth !=0)
            {
                double parameter = (2 * height) + (2 * weigth);
                double area = height * weigth;
                Console.WriteLine(parameter);
                Console.WriteLine(area);
                
            }
            else
            {
                Console.WriteLine("This is not a rectangle! Enter different numbers!");
            }
        }
    }

