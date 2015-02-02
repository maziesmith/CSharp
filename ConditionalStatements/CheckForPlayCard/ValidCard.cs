//Problem 3. Check for a Play Card

//Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. 
//Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. Examples:

using System;
using System.Linq;

class ValidCard
{
    static void Main()
    {
        string[] arrayCard = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
        Console.WriteLine("Please enter a string(haha something like a playng card symbol :D)");
        string text = Console.ReadLine();

        if (arrayCard.Contains(text))
        {
            Console.WriteLine("yes");
        }
        else
        {
            Console.WriteLine("no");
        }

           

    }
}
