//Problem 12. Null Values Arithmetic

//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.

using System;

    class NullValues
    {
        static void Main()
        {
            //The variables can`t be printed if there is nothing assigned to them.
            int? nullableInt=null;
            double? nullableDouble=null;
            Console.WriteLine("The null value of an Int:"+nullableInt);
            Console.WriteLine("The null value of a Double:"+nullableDouble);
            nullableInt = 2;
            nullableDouble = 2.22;
            Console.WriteLine("Some value of an Int: "+nullableInt);
            Console.WriteLine("Some value of a Double:"+nullableDouble);
        }
    }

