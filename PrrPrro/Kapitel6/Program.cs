using System;

namespace Kapitel6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testa TryParse");
            int test = 0;
            Console.WriteLine(int.TryParse(Console.ReadLine(), out test));
        }
    }
}
