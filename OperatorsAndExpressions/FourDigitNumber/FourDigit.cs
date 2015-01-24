//Problem 6. Four-Digit Number

//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//Prints on the console the number in reversed order: dcba (in our example 1102).
//Puts the last digit in the first position: dabc (in our example 1201).
//Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0.

using System;
using System.Text;

    class FourDigit
    {
        static void Main()
        {
            Console.WriteLine("Please choose a 4-FourDigit number");        
            string validNumber = Console.ReadLine();
            int n;
            bool isNumeric = int.TryParse(validNumber, out n);
            
            if (isNumeric == true)
            {
                int numberGeneral = Convert.ToInt32(validNumber);
                if (validNumber.StartsWith("0"))
                {
                    Console.WriteLine("Please enter a 4-digit number, NOT 4 digits starting with ZERO!");
                    numberGeneral = int.Parse(Console.ReadLine());

                    //Calculate the sum of digits
                    int number = numberGeneral;
                    int sum = 0;
                    while (number != 0)
                    {
                        sum += number % 10;
                        number /= 10;
                    }
                    Console.WriteLine("The sum of digits is: " + sum);

                    //Print in reverse order
                    int leftSideNumber = numberGeneral;
                    int reverse = 0;
                    while (leftSideNumber > 0)
                    {
                        int digit = leftSideNumber % 10;
                        reverse = reverse * 10 + digit;
                        leftSideNumber = leftSideNumber / 10;  //left = Math.floor(left / 10); 
                    }
                    Console.WriteLine("The reverse version of the number:" + reverse);

                    //Last digit first
                    int numberReverse = numberGeneral;
                    string numberThreeDigit = (numberReverse / 10).ToString();
                    string numberString = numberReverse.ToString();
                    string lastDigit = numberString[3].ToString();
                    Console.WriteLine("If the last digit comes first: " + lastDigit + numberThreeDigit);

                    //Exchange 2nd and 3rd digit
                    string numberSecondThird = numberGeneral.ToString();
                    string secondDigit = numberSecondThird[1].ToString();
                    string thirdDigit = numberSecondThird[2].ToString();
                    var stringNumber = new StringBuilder(numberSecondThird);
                    stringNumber.Replace(secondDigit, thirdDigit, 1, 1);
                    stringNumber.Replace(thirdDigit, secondDigit, 2, 1);
                    numberSecondThird = stringNumber.ToString();
                    Console.WriteLine("If the second and third digits are replaced: " + numberSecondThird);
                }
                else
                {


                    //Calculate the sum of digits
                    int number = numberGeneral;
                    int sum = 0;
                    while (number != 0)
                    {
                        sum += number % 10;
                        number /= 10;
                    }
                    Console.WriteLine("The sum of digits is: " + sum);

                    //Print in reverse order
                    int leftSideNumber = numberGeneral;
                    int reverse = 0;
                    while (leftSideNumber > 0)
                    {
                        int digit = leftSideNumber % 10;
                        reverse = reverse * 10 + digit;
                        leftSideNumber = leftSideNumber / 10;  //left = Math.floor(left / 10); 
                    }
                    Console.WriteLine("The reverse version of the number:" + reverse);

                    //Last digit first
                    int numberReverse = numberGeneral;
                    string numberThreeDigit = (numberReverse / 10).ToString();
                    string numberString = numberReverse.ToString();
                    string lastDigit = numberString[3].ToString();
                    Console.WriteLine("If the last digit comes first: " + lastDigit + numberThreeDigit);

                    //Exchange 2nd and 3rd digit
                    string numberSecondThird = numberGeneral.ToString();
                    string secondDigit = numberSecondThird[1].ToString();
                    string thirdDigit = numberSecondThird[2].ToString();
                    var stringNumber = new StringBuilder(numberSecondThird);
                    stringNumber.Replace(secondDigit, thirdDigit, 1, 1);
                    stringNumber.Replace(thirdDigit, secondDigit, 2, 1);
                    numberSecondThird = stringNumber.ToString();
                    Console.WriteLine("If the second and third digits are replaced: " + numberSecondThird);
                }
            }
            else
            {
                Console.WriteLine("Please enter a number!!!!!!!!!!!!");
                validNumber = Console.ReadLine();
                int numberGeneral = Convert.ToInt32(validNumber);
                if (validNumber.StartsWith("0"))
                {
                    Console.WriteLine("Please enter a 4-digit number, NOT 4 digits starting with ZERO!");
                    numberGeneral = int.Parse(Console.ReadLine());

                    //Calculate the sum of digits
                    int number = numberGeneral;
                    int sum = 0;
                    while (number != 0)
                    {
                        sum += number % 10;
                        number /= 10;
                    }
                    Console.WriteLine("The sum of digits is: " + sum);

                    //Print in reverse order
                    int leftSideNumber = numberGeneral;
                    int reverse = 0;
                    while (leftSideNumber > 0)
                    {
                        int digit = leftSideNumber % 10;
                        reverse = reverse * 10 + digit;
                        leftSideNumber = leftSideNumber / 10;  //left = Math.floor(left / 10); 
                    }
                    Console.WriteLine("The reverse version of the number:" + reverse);

                    //Last digit first
                    int numberReverse = numberGeneral;
                    string numberThreeDigit = (numberReverse / 10).ToString();
                    string numberString = numberReverse.ToString();
                    string lastDigit = numberString[3].ToString();
                    Console.WriteLine("If the last digit comes first: " + lastDigit + numberThreeDigit);

                    //Exchange 2nd and 3rd digit
                    string numberSecondThird = numberGeneral.ToString();
                    string secondDigit = numberSecondThird[1].ToString();
                    string thirdDigit = numberSecondThird[2].ToString();
                    var stringNumber = new StringBuilder(numberSecondThird);
                    stringNumber.Replace(secondDigit, thirdDigit, 1, 1);
                    stringNumber.Replace(thirdDigit, secondDigit, 2, 1);
                    numberSecondThird = stringNumber.ToString();
                    Console.WriteLine("If the second and third digits are replaced: " + numberSecondThird);
                }
                else
                {


                    //Calculate the sum of digits
                    int number = numberGeneral;
                    int sum = 0;
                    while (number != 0)
                    {
                        sum += number % 10;
                        number /= 10;
                    }
                    Console.WriteLine("The sum of digits is: " + sum);

                    //Print in reverse order
                    int leftSideNumber = numberGeneral;
                    int reverse = 0;
                    while (leftSideNumber > 0)
                    {
                        int digit = leftSideNumber % 10;
                        reverse = reverse * 10 + digit;
                        leftSideNumber = leftSideNumber / 10;  //left = Math.floor(left / 10); 
                    }
                    Console.WriteLine("The reverse version of the number:" + reverse);

                    //Last digit first
                    int numberReverse = numberGeneral;
                    string numberThreeDigit = (numberReverse / 10).ToString();
                    string numberString = numberReverse.ToString();
                    string lastDigit = numberString[3].ToString();
                    Console.WriteLine("If the last digit comes first: " + lastDigit + numberThreeDigit);

                    //Exchange 2nd and 3rd digit
                    string numberSecondThird = numberGeneral.ToString();
                    string secondDigit = numberSecondThird[1].ToString();
                    string thirdDigit = numberSecondThird[2].ToString();
                    var stringNumber = new StringBuilder(numberSecondThird);
                    stringNumber.Replace(secondDigit, thirdDigit, 1, 1);
                    stringNumber.Replace(thirdDigit, secondDigit, 2, 1);
                    numberSecondThird = stringNumber.ToString();
                    Console.WriteLine("If the second and third digits are replaced: " + numberSecondThird);
                }
            }
        }
    }

