//Problem 9. Print a Sequence

//Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

using System;

    class Sequence
    {
        static void Main()
        {
            int firstMember = 2; //Стoйност на първия елемент от редицата

            for (int i = 0; i < 10; i++) //Цикъл за отпечатване на 10 числа
            {
                int number = i + firstMember; //Всеки член на редицата е с +1 по-голям от предходния

                if (number % 2 != 0) //Проверка за четност
                    number *= -1; //Промяна знака на числото

                Console.WriteLine(number); //Отпечатване на числото
            }
        }
    }

