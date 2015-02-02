using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoFourEight
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int R = 0;
            if(b==2)
            {
                R = a % c;
            }
            else if (b == 4)
            {
                R = a + c;
            }
            else if (b == 8)
            {
                R = a * c;
            }
            if (R % 4 == 0)
            {
                Console.WriteLine(R/4);
            }
            else
            {
                Console.WriteLine(R%4);
            }
            Console.WriteLine(R);
        }
    }
}
