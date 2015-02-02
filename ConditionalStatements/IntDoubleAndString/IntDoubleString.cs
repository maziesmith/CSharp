//Problem 9. Play with Int, Double and String

//Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//If the variable is int or double, the program increases it by one.
//If the variable is a string, the program appends * at the end.
//Print the result at the console. Use switch statement.

using System;

class IntDoubleString
{
    static void Main()
    {
        Console.WriteLine(@"Plese choose:I for integer; D for double or S for string");

        char choise = Console.ReadLine().Trim().ToUpper()[0];
        
        switch (choise)
        {
            case 'I':
                Console.Write("Enter a number: ");
                int inputInteger = int.Parse(Console.ReadLine());
                Console.WriteLine(inputInteger + 1);
                break;
            case 'D':
                Console.Write("Enter a number: ");
                double inputDouble = double.Parse(Console.ReadLine());
                Console.WriteLine(inputDouble + 1);
                break;
            case 'S':
                Console.Write("Enter a string: ");
                string inputString = Console.ReadLine();
                Console.WriteLine(inputString+"*");
                break;
            default:
                Console.WriteLine("Not a valid entry!");
                break;
        }
    }
}
