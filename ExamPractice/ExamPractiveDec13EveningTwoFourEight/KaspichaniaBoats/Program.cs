using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaspichaniaBoats
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int topDots = n;
            int width = n * 2 + 1;
            int heigth = 6 + ((n - 3) / 2) * 3;
            //Top row:
            Console.Write(new string('.',topDots));
            Console.Write("*");
            Console.Write(new string('.', topDots));
            Console.WriteLine();
            
            //Upper diagonals:
            int diagonalDotsOuter = n - 1;
            int diagonalDotsInner = 0;
            for (int i = 0; i < (n-1); i++)
            {
                
                Console.Write(new string('.', diagonalDotsOuter));
                Console.Write("*");
                Console.Write(new string('.', diagonalDotsInner));
                Console.Write('*');
                Console.Write(new string('.', diagonalDotsInner));
                Console.Write("*");
                Console.Write(new string('.', diagonalDotsOuter));
                Console.WriteLine();
                diagonalDotsOuter--;
                diagonalDotsInner++;
            }
            
            //The Stars` row:
            Console.WriteLine(new string('*',width));
            
            //Lower diagonals:
            int outerLowerDots = 1;
            int innerLowerDots = n - 2;
            for (int i = 0; i < n/2; i++)
            {
                Console.Write(new string('.', outerLowerDots));
                Console.Write('*');
                Console.Write(new string('.', innerLowerDots));
                Console.Write('*');
                Console.Write(new string('.', innerLowerDots));
                Console.Write('*');
                Console.Write(new string('.', outerLowerDots));
                Console.WriteLine();
                outerLowerDots++;
                innerLowerDots--;
            }

            //Bottom row:
            int bottomDots = (n / 2) + 1;
            Console.Write(new string('.',bottomDots));
            Console.Write(new string('*', n));
            Console.Write(new string('.', bottomDots));
            Console.WriteLine();

        }
    }
}
