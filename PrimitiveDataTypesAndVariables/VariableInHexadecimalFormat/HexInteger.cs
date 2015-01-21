//Problem 3. Variable in Hexadecimal Format

//Declare an integer variable and assign it with the value 254 in hexadecimal format (0x##).
//Use Windows Calculator to find its hexadecimal representation.
//Print the variable and ensure that the result is 254.

using System;

class HexInteger
{
    static void Main()
    {
        //An attempt to convert string hexadecimal number to integer:
        //Console.WriteLine("Please enter a number in hexadecimal format:");
        //string hexNumber = "0x"+Console.ReadLine();
        //int hex = Convert.ToInt32(hexNumber, 16);
        //Console.WriteLine("The decimal value of "+hexNumber+" is:"+hex);

        int hex = 0xfe;
        Console.WriteLine("the decimal of 0xFE is: "+hex);

    }
}

