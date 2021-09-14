using System;

namespace Uppgift2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilket år är det?");
            int aar = int.Parse(Console.ReadLine());
            Console.WriteLine("Det är " + (2100-aar) + " år kvar till 2100.");
        }
    }
}
