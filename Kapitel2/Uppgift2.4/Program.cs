using System;

namespace Uppgift2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv två tal");
            int tal1 = int.Parse(Console.ReadLine());
            int tal2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Summan är " + (tal1+tal2) + " och produkten är " + (tal1*tal2));
        }
    }
}
