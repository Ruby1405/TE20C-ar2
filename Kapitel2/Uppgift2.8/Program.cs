using System;

namespace Uppgift2._8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en addition utan mellanslag.");
            string text = Console.ReadLine();
            int plusindex = text.IndexOf("+");
            Console.WriteLine("Svaret är " + (int.Parse(text[..plusindex])+int.Parse(text[(plusindex+1)..])));
        }
    }
}
