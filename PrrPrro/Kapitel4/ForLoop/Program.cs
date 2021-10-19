using System;

namespace ForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Räkna 1 till 10");

            for (var i = 1; i < 11; i++)
            {
                Console.WriteLine($"Loop nr {i}");
            }


        }
    }
}
