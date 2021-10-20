using System;

namespace GameOfLife
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Game of life");

            int[,] currentCells = new int[64,16];
            //Console.WriteLine(currentCells.GetLength(0));
            //Console.WriteLine(currentCells.GetLength(1));

            while (true)
            {
                for (var x = 0; x < currentCells.GetLength(0); x++)
                {
                    for (var y = 0; y < currentCells.GetLength(1); y++)
                    {
                        Console.Write("O");
                    }
                    Console.Write("\n");
                }
            }
        }
    }
}
