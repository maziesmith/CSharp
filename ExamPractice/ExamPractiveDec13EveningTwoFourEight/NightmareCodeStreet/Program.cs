using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightmareCodeStreet
{
    class Program
    {
        static void Main(string[] args)
        {
            string digits = Console.ReadLine();
            int oddSum = 0;
            int number = 0;
            int counter = 0;
            for (int i = 1; i < digits.Length; i += 2)
            {
                if (char.IsDigit(digits[i]))
                {
                    number = digits[i] - '0';
                    oddSum += number;
                    counter++;
                }
                else { continue; }
            }
            Console.WriteLine(counter+" "+oddSum);

        }
    }
}
