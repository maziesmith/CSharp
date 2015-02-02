using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enigmanation
{
    class Program
    {
        static void Main(string[] args)
        
        {
            //2+3+6-4*2+1%2=

            string expression = Console.ReadLine();
            
            double currentResult =0;
            int indexAfterBr = 0;
            if (char.IsDigit(expression[0]))
            {
            currentResult = (expression[0] - '0');
                 for (int i = 1; i < expression.Length; i++)
                    {
                        if (expression[i] == '(')
                        {
                            double BracketsCurrent = expression[i + 1] - '0';
                            for (int j = 0; j < expression.Length; j++)
                            {
                                if (expression[j] == '+')
                                {
                                    BracketsCurrent = BracketsCurrent + (expression[j + 1] - '0');
                                }
                                if (expression[j] == '-')
                                {
                                    BracketsCurrent = BracketsCurrent - (expression[j + 1] - '0');
                                }
                                if(expression[j]=='*')
                                {
                                    BracketsCurrent = BracketsCurrent * (expression[j + 1] - '0');
                                }
                                if (expression[j] == '%')
                                {
                                    BracketsCurrent = BracketsCurrent % (expression[j + 1] - '0');
                                }
                                if (expression[j] == ')')
                                {
                                    break;
                                }
                            }
                            if (expression[i - 1] == '+')
                            {
                                currentResult += BracketsCurrent;
                            }
                            if (expression[i - 1] == '-')
                            {
                                currentResult -= BracketsCurrent;
                            }
                            if (expression[i - 1] == '*')
                            {
                                currentResult *= BracketsCurrent;
                            }
                            if (expression[i - 1] == '%')
                            {
                                currentResult %= BracketsCurrent;
                            }
                  
                        }
                        if (expression[i] == '+')
                        {
                    
                            currentResult = currentResult + (expression[i + 1] - '0');
                    
                        }
                        if (expression[i] == '-')
                        {
                            currentResult = currentResult - (expression[i + 1] - '0');
                        }
                        if(expression[i]=='*')
                        {
                            currentResult = currentResult * (expression[i + 1] - '0');
                        }
                        if (expression[i] == '%')
                        {
                            currentResult = currentResult % (expression[i + 1] - '0');
                        }
               
                    }
                 Console.WriteLine("{0:0.000}", currentResult);
            }
            else if(expression[0]=='(')
                {
                    double BracketsCurrent = expression[1] - '0';
                    for (int j = 0; j < expression.Length; j++)
                    {
                        if (expression[j] == '+')
                        {
                            BracketsCurrent = BracketsCurrent + (expression[j + 1] - '0');
                        }
                        if (expression[j] == '-')
                        {
                            BracketsCurrent = BracketsCurrent - (expression[j + 1] - '0');
                        }
                        if(expression[j]=='*')
                        {
                            BracketsCurrent = BracketsCurrent * (expression[j + 1] - '0');
                        }
                        if (expression[j] == '%')
                        {
                            BracketsCurrent = BracketsCurrent % (expression[j + 1] - '0');
                        }
                        if (expression[j] == ')')
                        {
                            indexAfterBr = j + 1;
                            break;
                        }
                    }
                    currentResult = BracketsCurrent;
                    for (int i = indexAfterBr; i < expression.Length; i++)
                    {
                         if (expression[i] == '(')
                        {
                            BracketsCurrent = expression[i + 1] - '0';
                            for (int j = 0; j < expression.Length; j++)
                            {
                                if (expression[j] == '+')
                                {
                                    BracketsCurrent = BracketsCurrent + (expression[j + 1] - '0');
                                }
                                if (expression[j] == '-')
                                {
                                    BracketsCurrent = BracketsCurrent - (expression[j + 1] - '0');
                                }
                                if(expression[j]=='*')
                                {
                                    BracketsCurrent = BracketsCurrent * (expression[j + 1] - '0');
                                }
                                if (expression[j] == '%')
                                {
                                    BracketsCurrent = BracketsCurrent % (expression[j + 1] - '0');
                                }
                                if (expression[j] == ')')
                                {
                                    break;
                                }
                            }
                            if (expression[i - 1] == '+')
                            {
                                currentResult += BracketsCurrent;
                            }
                            if (expression[i - 1] == '-')
                            {
                                currentResult -= BracketsCurrent;
                            }
                            if (expression[i - 1] == '*')
                            {
                                currentResult *= BracketsCurrent;
                            }
                            if (expression[i - 1] == '%')
                            {
                                currentResult %= BracketsCurrent;
                            }
                  
                        }
                        if (expression[i] == '+')
                        {
                    
                            currentResult = currentResult + (expression[i + 1] - '0');
                    
                        }
                        if (expression[i] == '-')
                        {
                            currentResult = currentResult - (expression[i + 1] - '0');
                        }
                        if(expression[i]=='*')
                        {
                            currentResult = currentResult * (expression[i + 1] - '0');
                        }
                        if (expression[i] == '%')
                        {
                            currentResult = currentResult % (expression[i + 1] - '0');
                        }
               
                    }           
                }     
           Console.WriteLine("{0:0.000}",currentResult);
        }
    }
}
