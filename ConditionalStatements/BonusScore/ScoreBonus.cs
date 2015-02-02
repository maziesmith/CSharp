//Problem 2. Bonus Score

//Write a program that applies bonus score to given score in the range [1…9] by the following rules:
//If the score is between 1 and 3, the program multiplies it by 10.
//If the score is between 4 and 6, the program multiplies it by 100.
//If the score is between 7 and 9, the program multiplies it by 1000.
//If the score is 0 or more than 9, the program prints “invalid score”.

using System;


class ScoreBonus
{
    static void Main()
    {
        Random randomNumber = new Random();
        int randomScore = randomNumber.Next(1, 9);
        Console.WriteLine("Your score is " + randomScore);
        if (randomScore <= 3 && randomScore >= 1)
        {
            randomScore = randomScore * 10;
            Console.WriteLine("Your bonus is:" + randomScore);
        }
        else if (randomScore>= 4 && randomScore<=6)
        {
            randomScore = randomScore * 100;
            Console.WriteLine("Your bonus is:" + randomScore);
        }
        else if (randomScore>= 7 && randomScore<=9)
        {
            randomScore = randomScore * 1000;
            Console.WriteLine("Your bonus is:" + randomScore);
        }
    }
}

