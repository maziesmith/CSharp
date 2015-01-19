//Problem 16.* Print Long Sequence

//Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
//You might need to learn how to use loops in C# (search in Internet).

using System;

    class PrintLongSequence
    {
        static void Main()
        {
            int firstMember = 2; //Стoйност на първия елемент от редицата

            for (int i = 0; i < 1000; i++) //Цикъл за отпечатване на 1000 числа
            {
                int number = i + firstMember; //Всеки член на редицата е с +1 по-голям от предходния

                if (number % 2 != 0) //Проверка за четност
                    number *= -1; //Промяна знака на числото

                Console.WriteLine(number); //Отпечатване на числото
            }
        }
    }

