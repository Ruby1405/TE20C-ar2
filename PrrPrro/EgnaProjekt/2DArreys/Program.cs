using System;

namespace _2DArreys
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] map = new int[10, 10];

            for (int x = 0; x < 10; x++)
            {
                for (var y = 0; y < 10; y++)
                {
                    map[x, y] = 10 * x + y;
                }
            }

            for (int y = 0; y < 10; y++)
            {
                for (var x = 0; x < 10; x++)
                {
                    Console.Write($"{map[x, y]} ");
                }
                Console.Write("\n");
            }

        }
    }
}
