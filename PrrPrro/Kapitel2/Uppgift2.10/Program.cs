using System;

namespace Uppgift2._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vilken är din favoritbok? ");
            string text = Console.ReadLine();
            Console.Write($"Din favoritbok är {text}");
        }
    }
}
