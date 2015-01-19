//Problem 15.* Age after 10 Years

//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

using System;

    class AgeAfter
    {
        static void Main()
        {
            Console.WriteLine("Please type the date of your birthday:");
            string birthday = Console.ReadLine();
            DateTime birthdayDate = Convert.ToDateTime(birthday);
            DateTime today = DateTime.Today;
            Console.WriteLine("Today is:"+today.ToString());
            int currentAge = 0;
            if (today.Month < birthdayDate.Month)
            {
                currentAge = today.Year - birthdayDate.Year - 1;
            }
            else if(today.Month>birthdayDate.Month)
            {
                currentAge = today.Year - birthdayDate.Year;
            }
            else if (today.Month == birthdayDate.Month && today.Day < birthdayDate.Day)
            {
                currentAge = today.Year - birthdayDate.Year - 1;
            }
            else if (today.Month == birthdayDate.Month && today.Day > birthdayDate.Day)
            {
                currentAge = today.Year - birthdayDate.Year;
            }
            else if (today.Month == birthdayDate.Month && today.Day == birthdayDate.Day)
            {
                Console.WriteLine("Happy Birthday!!!");
                currentAge = today.Year - birthdayDate.Year;
            }
            Console.WriteLine("Your age is:"+ currentAge);
            int futureAge = currentAge+10;
            Console.WriteLine("In 10 years your age will be:" + futureAge);

        }
    }

