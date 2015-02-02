using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _369ExamPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            long a = int.Parse(Console.ReadLine());
            long b = int.Parse(Console.ReadLine());
            long c = int.Parse(Console.ReadLine());

            long result=0;

            if(b==3)
            {
                result = a + c;
            }
            else if (b==6)
            {
                result = a * c;
            }
            else if (b==9)
            {
                result = a % c;
            }

            long result2 = 0;

            if (result % 3 == 0)
            {
                result2 = result / 3;
            }
            else
            {
                result2 = result % 3;
            }
                Console.WriteLine(result2);
                Console.WriteLine(result);
  
        }
    }
}
