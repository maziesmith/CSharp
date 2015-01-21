
//Problem 2. Float or Double?

//Which of the following values can be assigned to a variable of type float and which to a variable of type double: 
//34.567839023, 12.345, 8923.1234857, 3456.091?
//Write a program to assign the numbers in variables and print them to ensure no precision is lost.


using System;

    class FloatDouble
    {
        static void Main()
        {
            double doubleVar = 34.567839023D;
            Console.WriteLine(doubleVar);
            float floatVar = 12.345F;
            Console.WriteLine(floatVar);
            double doubleVar2 = 8923.1234857D;
            Console.WriteLine(doubleVar2);
            float floatVar3 = 3456.091F;
            Console.WriteLine(floatVar3);

        }
    }

