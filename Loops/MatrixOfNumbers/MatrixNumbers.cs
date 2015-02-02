using System;


class MatrixNumbers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = n+(n-1);
  
        for (int row = 1; row <= n; row++)
        {
                for (int column =row; column <=(row+(n-1)); column++)
                {
                    Console.Write(" {0}  ", column);        
                }
            Console.WriteLine();
        }

    }
}

