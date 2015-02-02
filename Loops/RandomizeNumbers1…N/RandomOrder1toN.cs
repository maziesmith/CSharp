using System;

//Problem 12.* Randomize the Numbers 1…N

//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.

class RandomOrder1toN
{
    static void Main()
    {
        Console.WriteLine("Please enter an integer:");
        int n = int.Parse(Console.ReadLine());
        int[] arrayNumbers = new int[n];
        Random num = new Random();
         for (int i = 1; i <arrayNumbers.Length; i++)
			{
                arrayNumbers[i] = (i);
			}
         for (int i = arrayNumbers.Length-1; i > 0;i--)
         {
             int swapIndex = num.Next(i + 1);
             int number = arrayNumbers[i];
             arrayNumbers[i] = arrayNumbers[swapIndex];
             arrayNumbers[swapIndex] = number;
         }

        foreach (int i in arrayNumbers)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" "+(i+1));
        }
        Console.ResetColor();
        Console.WriteLine();
    }
}




        // Fisher–Yates shuffle

        /*   public static IEnumerable<T> Shuffle<T>(this IEnumerable<T> source, Random rng)
                {
                    T[] elements = source.ToArray();
                    // Note i > 0 to avoid final pointless iteration
                        for (int i = elements.Length-1; i > 0; i--)
                        {
                            // Swap element "i" with a random earlier element it (or itself)
                            int swapIndex = rng.Next(i + 1);
                            T tmp = elements[i];
                            elements[i] = elements[swapIndex];
                            elements[swapIndex] = tmp;
                        }
                        // Lazily yield (avoiding aliasing issues etc)
                        foreach (T element in elements)
                        {
                            yield return element;
                        }
                    }
                */


