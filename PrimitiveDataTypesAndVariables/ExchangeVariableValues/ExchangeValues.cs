
//Problem 9. Exchange Variable Values

//Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
//Print the variable values before and after the exchange.

using System;

    class ExchangeValues
    {
        static void Main()
        {
            //Exchanging the values using XOR Swap Algorithm
            int a = 5;
            int b = 10;
            Console.WriteLine("a="+a);
            Console.WriteLine("b="+b);
            a = a ^ b;
            b = a ^ b;
            a = a ^ b;
            Console.WriteLine("a="+a);
            Console.WriteLine("b="+b);
            //Exchanging values with arithmetic calculations
            int c = 3;
            int d = 4;
            Console.WriteLine("c="+c);
            Console.WriteLine("d="+d);
            c = c + d;
            d = c - d;
            c = c - d;
            Console.WriteLine("c="+c);
            Console.WriteLine("d="+d);



        }
    }

