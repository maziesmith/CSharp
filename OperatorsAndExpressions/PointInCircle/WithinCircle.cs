//Problem 7. Point in a Circle

//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).

using System;

class WithinCircle
{
    static void Main()
    {
        Console.WriteLine("Choose your point:");
        Console.WriteLine("x=");
        string pointX = Console.ReadLine();
        double d;
        bool isXNumeric = double.TryParse(pointX, out d); 
        Console.WriteLine("y=");
        string pointY = Console.ReadLine();
        bool isYNumeric = double.TryParse(pointY, out d);

        

        if (isXNumeric == true && isYNumeric == true)
        {
            double x = double.Parse(pointX);
            double y = double.Parse(pointY);
            double r = 2;

            
            if (x == 0 && y == 0)
            {
                Console.WriteLine("Your point is the center of the circle!");
            }
            else if ((Math.Pow(x, 2) + Math.Pow(y, 2)) < Math.Pow(r, 2))
            {
                Console.WriteLine("Your point is within the circle.");
            }
            else if ((Math.Pow(x, 2) + Math.Pow(y, 2)) == Math.Pow(r, 2))
            {
                Console.WriteLine("Your point is on  the circle.");
            }
            else if ((Math.Pow(x, 2) + Math.Pow(y, 2)) > Math.Pow(r, 2))
            {
                Console.WriteLine("Your point is out of the circle.");
            }
        }
        else
        {
            Console.WriteLine("Please choose only numeric values!");

            Console.WriteLine("x=");
            pointX = Console.ReadLine();
            Console.WriteLine("y=");
            pointY = Console.ReadLine();
            double x = double.Parse(pointX);
            double y = double.Parse(pointY);
            double r = 2;


            if (x == 0 && y == 0)
            {
                Console.WriteLine("Your point is the center of the circle!");
            }
            else if ((Math.Pow(x, 2) + Math.Pow(y, 2)) < Math.Pow(r, 2))
            {
                Console.WriteLine("Your point is within the circle.");
            }
            else if ((Math.Pow(x, 2) + Math.Pow(y, 2)) == Math.Pow(r, 2))
            {
                Console.WriteLine("Your point is on  the circle.");
            }
            else if ((Math.Pow(x, 2) + Math.Pow(y, 2)) > Math.Pow(r, 2))
            {
                Console.WriteLine("Your point is out of the circle.");
            }
        }
        
    }
}

