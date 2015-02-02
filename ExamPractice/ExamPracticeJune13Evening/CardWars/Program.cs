using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardWars
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());
            int scorePesho = 0;
            int scoreGosho = 0;
            int gamesWonPesho = 0;
            int gamesWonGosho = 0;

            for (int currentGame = 1; currentGame <= n; currentGame++)
            {
                string firstCardPesho = Console.ReadLine();
                string secondCardPesho = Console.ReadLine();
                string thirdCardPesho = Console.ReadLine();
                string firstCardGosho = Console.ReadLine();
                string secondCardGosho = Console.ReadLine();
                string thirdCardGosho = Console.ReadLine();
                int firstCardPeshoPoints = 0;
                int secondCardPeshoPoints = 0;
                int thirdCardPeshoPoints = 0;
                int firstCardGoshoPoints = 0;
                int secondCradGoshoPoints = 0;
                int thirdCardGoshoPoints = 0;

                switch (firstCardPesho)
                {
                    case "A": firstCardPeshoPoints = 1; break;
                    case "10": firstCardPeshoPoints = 2; break;
                    case "9": firstCardPeshoPoints = 3; break;
                    case "8": firstCardPeshoPoints = 4; break;
                    case "7": firstCardPeshoPoints = 5; break;
                    case "6": firstCardPeshoPoints = 6; break;
                    case "5": firstCardPeshoPoints = 7; break;
                    case "4": firstCardPeshoPoints = 8; break;
                    case "3": firstCardPeshoPoints = 9; break;
                    case "2": firstCardPeshoPoints = 10; break;
                    case "J": firstCardPeshoPoints = 11; break;
                    case "Q": firstCardPeshoPoints = 12; break;
                    case "K": firstCardPeshoPoints = 13; break;
                    case "Z": scorePesho *= 2; break;
                    case "Y": scorePesho -= 200; break;
                    case "X": Console.WriteLine("X card drawn! Player one wins the match!"); break;
                      
                }

                switch (secondCardPesho)
                {
                    case "A": secondCardPeshoPoints = 1; break;
                    case "10": secondCardPeshoPoints = 2; break;
                    case "9": secondCardPeshoPoints = 3; break;
                    case "8": secondCardPeshoPoints = 4; break;
                    case "7": secondCardPeshoPoints = 5; break;
                    case "6": secondCardPeshoPoints = 6; break;
                    case "5": secondCardPeshoPoints = 7; break;
                    case "4": secondCardPeshoPoints = 8; break;
                    case "3": secondCardPeshoPoints = 9; break;
                    case "2": secondCardPeshoPoints = 10; break;
                    case "J": secondCardPeshoPoints = 11; break;
                    case "Q": secondCardPeshoPoints = 12; break;
                    case "K": secondCardPeshoPoints = 13; break;
                    case "Z": scorePesho *= 2;break;
                    case "Y": scorePesho -= 200; break;
                    case "X": Console.WriteLine("X card drawn! Player one wins the match!"); break;


                }
                switch (thirdCardPesho)
                {
                    case "A": thirdCardPeshoPoints = 1; break;
                    case "10": thirdCardPeshoPoints = 2; break;
                    case "9": thirdCardPeshoPoints = 3; break;
                    case "8": thirdCardPeshoPoints = 4; break;
                    case "7": thirdCardPeshoPoints = 5; break;
                    case "6": thirdCardPeshoPoints = 6; break;
                    case "5": thirdCardPeshoPoints = 7; break;
                    case "4": thirdCardPeshoPoints = 8; break;
                    case "3": thirdCardPeshoPoints = 9; break;
                    case "2": thirdCardPeshoPoints = 10; break;
                    case "J": thirdCardPeshoPoints = 11; break;
                    case "Q": thirdCardPeshoPoints = 12; break;
                    case "K": thirdCardPeshoPoints = 13; break;
                    case "Z": scorePesho *= 2; break;
                    case "Y": scorePesho -= 200; break;
                    case "X": Console.WriteLine("X card drawn! Player one wins the match!"); break;


                }
                switch (firstCardGosho)
                {
                    case "A": firstCardGoshoPoints = 1; break;
                    case "10": firstCardGoshoPoints = 2; break;
                    case "9": firstCardGoshoPoints = 3; break;
                    case "8": firstCardGoshoPoints = 4; break;
                    case "7": firstCardGoshoPoints = 5; break;
                    case "6": firstCardGoshoPoints = 6; break;
                    case "5": firstCardGoshoPoints = 7; break;
                    case "4": firstCardGoshoPoints = 8; break;
                    case "3": firstCardGoshoPoints = 9; break;
                    case "2": firstCardGoshoPoints = 10; break;
                    case "J": firstCardGoshoPoints = 11; break;
                    case "Q": firstCardGoshoPoints = 12; break;
                    case "K": firstCardGoshoPoints = 13; break;
                    case "Z": scoreGosho *= 2; break;
                    case "Y": scoreGosho -= 200; break;
                    case "X": Console.WriteLine("X card drawn! Player two wins the match!"); break;


                }
                switch (secondCardGosho)
                {
                    case "A": secondCradGoshoPoints = 1; break;
                    case "10": secondCradGoshoPoints = 2; break;
                    case "9": secondCradGoshoPoints = 3; break;
                    case "8": secondCradGoshoPoints = 4; break;
                    case "7": secondCradGoshoPoints = 5; break;
                    case "6": secondCradGoshoPoints = 6; break;
                    case "5": secondCradGoshoPoints = 7; break;
                    case "4": secondCradGoshoPoints = 8; break;
                    case "3": secondCradGoshoPoints = 9; break;
                    case "2": secondCradGoshoPoints = 10; break;
                    case "J": secondCradGoshoPoints = 11; break;
                    case "Q": secondCradGoshoPoints = 12; break;
                    case "K": secondCradGoshoPoints = 13; break;
                    case "Z": scoreGosho *= 2; break;
                    case "Y": scoreGosho -= 200; break;
                    case "X": Console.WriteLine("X card drawn! Player two wins the match!"); break;


                }
                switch (thirdCardGosho)
                {
                    case "A": thirdCardGoshoPoints = 1; break;
                    case "10": thirdCardGoshoPoints = 2; break;
                    case "9": thirdCardGoshoPoints = 3; break;
                    case "8": thirdCardGoshoPoints = 4; break;
                    case "7": thirdCardGoshoPoints = 5; break;
                    case "6": thirdCardGoshoPoints = 6; break;
                    case "5": thirdCardGoshoPoints = 7; break;
                    case "4": thirdCardGoshoPoints = 8; break;
                    case "3": thirdCardGoshoPoints = 9; break;
                    case "2": thirdCardGoshoPoints = 10; break;
                    case "J": thirdCardGoshoPoints = 11; break;
                    case "Q": thirdCardGoshoPoints = 12; break;
                    case "K": thirdCardGoshoPoints = 13; break;
                    case "Z": scoreGosho *= 2; break;
                    case "Y": scoreGosho -= 200; break;
                    case "X": Console.WriteLine("X card drawn! Player two wins the match!"); break;


                }

                int handPointsPesho = firstCardPeshoPoints + secondCardPeshoPoints + thirdCardPeshoPoints;
                int handPointsGosho = firstCardGoshoPoints + secondCradGoshoPoints + thirdCardGoshoPoints;
                
                if (handPointsGosho > handPointsPesho)
                {
                    scoreGosho += handPointsGosho;
                    gamesWonGosho++;

                }
                else if (handPointsPesho > handPointsGosho)
                {
                    scorePesho += handPointsPesho;
                    gamesWonPesho++;
                }
                else
                {
                    scorePesho += 0;
                    scoreGosho += 0;
                }
            }

            //who wins the match
            if (scorePesho > scoreGosho)
            {
                Console.WriteLine("First player wins!");
                Console.WriteLine("Score: " + scorePesho);
                Console.WriteLine("Games won: " + gamesWonPesho);
            }
            else if (scoreGosho > scorePesho)
            {
                Console.WriteLine("Second player wins!");
                Console.WriteLine("Score: " + scoreGosho);
                Console.WriteLine("Games won: " + gamesWonGosho);
            }
            else
            {
                Console.WriteLine("It's a tie!");
                Console.WriteLine("Score: 0");
            }

        }
    }
}
