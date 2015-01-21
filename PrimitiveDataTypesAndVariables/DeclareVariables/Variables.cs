//Problem 1. Declare Variables

//Declare five variables choosing for each of them the most appropriate of the types byte, sbyte, short, ushort, int, uint, long, ulong 
//to represent the following values: 52130, -115, 4825932, 97, -10000.
//Choose a large enough type for each number to ensure it will fit in it. Try to compile the code.
//Submit the source code of your Visual Studio project as part of your homework submission.


using System;

class Variables
{
    static void Main()
    {
        sbyte sbyteVar = -115;
        Console.WriteLine(sbyteVar);
        ushort ushortVar = 52130;
        Console.WriteLine(ushortVar);
        int intVar = 4825932;
        Console.WriteLine(intVar);
        byte byteVar = 97;
        Console.WriteLine(byteVar);
        short shortVar = -10000;
        Console.WriteLine(shortVar);
    }
}
