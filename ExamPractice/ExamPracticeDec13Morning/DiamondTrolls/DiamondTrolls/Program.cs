using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiamondTrolls
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = n*2 + 1;
            int height = 6 + ((n - 3) / 2) * 3;
            int topDot = (n/2)+1;
            Console.Write(new string('.', topDot));
            Console.Write(new string('*', n));
            Console.Write(new string('.', topDot));

            Console.WriteLine();
            int nextDots = topDot - 1;
            int topRows=(n/2)-1;
            for (int i = 0; i < topRows; i++)
            {
                topDot--;
                Console.Write(new string('.', topDot));
                Console.Write('*');
                Console.Write(new string('.',nextDots));
                Console.Write('*');
                Console.Write(new string('.', nextDots));
                Console.Write('*');
                Console.WriteLine(new string('.', topDot));
                nextDots++;
            }

            Console.WriteLine(new string ('*', width));

            int firstDots = 1;

            for (int i = 0; i < n-1; i++)
            {
                nextDots--;
                Console.Write(new string('.', firstDots));
                Console.Write('*');
                Console.Write(new string('.', nextDots+1));
                Console.Write('*');
                Console.Write(new string('.', nextDots+1));
                Console.Write('*');
                Console.WriteLine(new string('.', firstDots));

                firstDots++;
            }
            Console.Write(new string('.',(width-1) / 2));
            Console.Write('*');
            Console.Write(new string('.', (width-1)/ 2));
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}
