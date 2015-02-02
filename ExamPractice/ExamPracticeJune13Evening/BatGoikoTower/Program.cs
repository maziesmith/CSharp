using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatGoikoTower
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());
            int width = h * 2;
            int topOuterDots = width / 2 - 1;
            int innerDots = 0;
   

            for(int i =0; i<h;i++)
            {
                if (i == 1 || i == 3 || i == 6 || i == 10 || i == 15 || i == 21 || i == 28 || i == 36)
                {
                    Console.Write(new string('.', topOuterDots));
                    Console.Write('/');
                    Console.Write(new string('-', innerDots));
                    Console.Write(new string('-', innerDots));
                    Console.Write('\\');
                    Console.Write(new string('.', topOuterDots));
                    Console.WriteLine();
                    innerDots++;
                    topOuterDots--;
                }
                else
                {

                    Console.Write(new string('.', topOuterDots));
                    Console.Write('/');
                    Console.Write(new string('.', innerDots));
                    Console.Write(new string('.', innerDots));
                    Console.Write('\\');
                    Console.Write(new string('.', topOuterDots));
                    Console.WriteLine();
                    innerDots++;
                    topOuterDots--;
                }
                


            }
        }
    }
}
