using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expression3X
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            decimal result = 0;
            decimal currentBracketResult = 0;
            char currentOperator = '+';
            char currentBracketOperator = '+';
            bool inBracket = false;

            foreach(char symbol in expression)
            {
                if (symbol=='(')
                {
                    inBracket = true;
                    continue;
                }
                if (symbol == '+' || symbol == '-' || symbol == '*' || symbol == '/')
                {
                    if (inBracket)
                    {

                    }
                    else
                    {
                        currentOperator = symbol;
                    }
                }
                if (char.IsDigit(symbol))
                {
                    int currentNumber = symbol - '0';

                    if (inBracket)
                    {
                        switch (currentBracketOperator)
                        {
                            case '+': currentBracketResult += currentNumber;
                                break;
                            case '-': currentBracketResult -= currentNumber;
                                break;
                            case '*': currentBracketResult *= currentNumber;
                                break;
                            case '/': currentBracketResult /= currentNumber;
                                break;
                        }
                    }
                    else
                    {
                        switch (currentBracketOperator)
                        {
                            case '+': result += currentNumber;
                                break;
                            case '-': result -= currentNumber;
                                break;
                            case '*': result *= currentNumber;
                                break;
                            case '/': result /= currentNumber;
                                break;
                        }
                    }
                
                }

            }


        }
    }
}
