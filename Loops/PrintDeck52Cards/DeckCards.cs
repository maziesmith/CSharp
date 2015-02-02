//Problem 4. Print a Deck of 52 Cards

//Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). 
//The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
//The card faces should start from 2 to A.
//Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.
//output

//2 of spades, 2 of clubs, 2 of hearts, 2 of diamonds
//3 of spades, 3 of clubs, 3 of hearts, 3 of diamonds
//…  
//K of spades, K of clubs, K of hearts, K of diamonds
//A of spades, A of clubs, A of hearts, A of diamonds
//Note: You may use the suit symbols instead of text.


using System;

class DeckCards
{
    static void Main()
    {
       Console.OutputEncoding=System.Text.Encoding.UTF8;
       Console.BackgroundColor = ConsoleColor.White;
        
       Console.ForegroundColor = ConsoleColor.Black;
       Console.Write("Deck of Cards:");
        char spade = '\u2660';
        Console.Write(spade);
        char heart = '\u2665';
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(heart);
        char diamond = '\u2666';
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write(diamond);
        char club = '\u2663';
        Console.ForegroundColor = ConsoleColor.Black;
        Console.Write(club);
        Console.WriteLine();

        for (int i = 2; i < 14; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < 4; j++)
            {
                switch (i)
                {
                    case 2: Console.Write(" {0}",i); break;
                    case 3: Console.Write(" {0}", i); break;
                    case 4: Console.Write(" {0}", i); break;
                    case 5: Console.Write(" {0}", i); break;
                    case 6: Console.Write(" {0}", i); break;
                    case 7: Console.Write(" {0}", i); break;
                    case 8: Console.Write(" {0}", i); break;
                    case 9: Console.Write(" {0}", i); break;
                    case 10: Console.Write(i); break;
                    case 11: Console.Write(" J"); break;
                    case 12: Console.Write(" Q"); break;
                    case 13: Console.Write(" K"); break;
                    case 14: Console.Write(" A"); break;
                    default: Console.Write("Error!"); break;
                }
                
                switch(j)
                {
                    case 0: Console.ForegroundColor = ConsoleColor.Black; Console.Write(spade); 
                            Console.ForegroundColor = ConsoleColor.Red; Console.Write(" "); break;

                    case 1: Console.ForegroundColor = ConsoleColor.Red; Console.Write(heart); Console.Write(" "); break;

                    case 2: Console.ForegroundColor = ConsoleColor.Red; Console.Write(diamond); Console.ForegroundColor = ConsoleColor.Black; Console.Write(" "); break;
                    case 3: Console.ForegroundColor = ConsoleColor.Black; Console.Write(club); Console.Write(" ");  break;
                    default: Console.WriteLine("Error!"); break;
                }
                
            }
           
        }
        Console.WriteLine(); Console.WriteLine();
    }
}

