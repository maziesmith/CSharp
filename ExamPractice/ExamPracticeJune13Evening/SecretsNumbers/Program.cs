using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecretsNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();

            //special sum:
            int l = number.Length;
            int oddSum = 0;
            int evenSum = 0;
            int specialSum = 0;
            int oddDigit = 0;
            int evenDigit = 0;
            for (int i = 1; i <= l; i++)
            {
                if ((l -(l-i)) % 2 == 1)
                {
                    oddDigit = number[l - i] - '0';
                    oddSum += oddDigit*(int)Math.Pow((l -(l-i)),2);
                }
                else if ((l - (l-i)) % 2 == 0)
                {
                    evenDigit = number[l - i] - '0';
                    evenSum += (int)Math.Pow(evenDigit,2)*(l - (l-i));
                }
            }
            specialSum = oddSum + evenSum;   
            Console.WriteLine(specialSum);

            //secret alpha-sequence :
            int lastDigit = specialSum % 10;
            if (lastDigit == 0)
            {
                Console.WriteLine(number + " has no secret alpha-sequence");
            }
            else
            {
                char[] alphaSequence = new char[lastDigit];
                int R = specialSum % 26;
                
                for (int i = 0; i < lastDigit; i++)
                {
                    int letterNumber = R + 65 + i;
                    if (letterNumber > 90)
                    {
                        letterNumber = R + 65 + i-26;
                        alphaSequence[i] = (char)letterNumber;
                        Console.Write(alphaSequence[i]);
                        
                    }
                    else
                    {
                        alphaSequence[i]=(char)letterNumber;
                        Console.Write(alphaSequence[i]);
                    }
                    
                    
                    
                }

            }
            
        }
    }
}
