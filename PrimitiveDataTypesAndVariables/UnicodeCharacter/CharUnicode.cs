//Problem 4. Unicode Character

//Declare a character variable and assign it with the symbol that has Unicode code 42 (decimal) using the \u00XX syntax, and then print it.
//Hint: first, use the Windows Calculator to find the hexadecimal representation of 42. The output should be *.

using System;

class CharUnicode
{
    static void Main()
    {
        char character = '\u002a';
        Console.WriteLine(character);
    }
}

