//Problem 15. Hexadecimal to Decimal Number

//Using loops write a program that converts a hexadecimal integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

using System;

    class HexadecimalToDecimal
    {
        static void Main()
        {
            Console.WriteLine("Please enter a hexadecimal number;");
            string hex = Console.ReadLine();
            char[] hexNumber = hex.ToCharArray();
            Array.Reverse(hexNumber);
            long decimalNumber = 0; ;
            for (int i = hexNumber.Length-1; i>=0; i--)
            {
                switch(hexNumber[i])
                {
                    case '0': decimalNumber += ((hexNumber[i] - '0') * (long)Math.Pow(16, i)); break;
                    case '1': decimalNumber += ((hexNumber[i] - '0') * (long)Math.Pow(16, i)); break;
                    case '2': decimalNumber += ((hexNumber[i] - '0') * (long)Math.Pow(16, i)); break;
                    case '3': decimalNumber += ((hexNumber[i] - '0') * (long)Math.Pow(16, i)); break;
                    case '4': decimalNumber += ((hexNumber[i] - '0') * (long)Math.Pow(16, i)); break;
                    case '5': decimalNumber += ((hexNumber[i] - '0') * (long)Math.Pow(16, i)); break;
                    case '6': decimalNumber += ((hexNumber[i] - '0') * (long)Math.Pow(16, i)); break;
                    case '7': decimalNumber += ((hexNumber[i] - '0') * (long)Math.Pow(16, i)); break;
                    case '8': decimalNumber += ((hexNumber[i] - '0') * (long)Math.Pow(16, i)); break;
                    case '9': decimalNumber += ((hexNumber[i] - '0') * (long)Math.Pow(16, i)); break;
                    case 'A': decimalNumber += ((hexNumber[i] - '7') * (long)Math.Pow(16, i)); break;
                    case 'B': decimalNumber += ((hexNumber[i] - '7') * (long)Math.Pow(16, i)); break;
                    case 'C': decimalNumber += ((hexNumber[i] - '7') * (long)Math.Pow(16, i)); break;
                    case 'D': decimalNumber += ((hexNumber[i] - '7') * (long)Math.Pow(16, i)); break;
                    case 'E': decimalNumber += ((hexNumber[i] - '7') * (long)Math.Pow(16, i)); break;
                    case 'F': decimalNumber += ((hexNumber[i] - '7') * (long)Math.Pow(16, i)); break;
                    case 'a': decimalNumber += ((hexNumber[i] - 'W') * (long)Math.Pow(16, i)); break;
                    case 'b': decimalNumber += ((hexNumber[i] - 'W') * (long)Math.Pow(16, i)); break;
                    case 'c': decimalNumber += ((hexNumber[i] - 'W') * (long)Math.Pow(16, i)); break;
                    case 'd': decimalNumber += ((hexNumber[i] - 'W') * (long)Math.Pow(16, i)); break;
                    case 'e': decimalNumber += ((hexNumber[i] - 'W') * (long)Math.Pow(16, i)); break;
                    case 'f': decimalNumber += ((hexNumber[i] - 'W') * (long)Math.Pow(16, i)); break;
                    default: Console.WriteLine("Error!"); break;

                }
                
            }
            Console.WriteLine(decimalNumber);
         

        }
    }

