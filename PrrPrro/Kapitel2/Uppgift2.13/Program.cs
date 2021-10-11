using System;

namespace Uppgift2._13
{
    class Program
    {
        static void Main(string[] args)
        {
            //fråga efter 3 tal
            Console.Write("Skriv ett tal ");
            double pay1 = double.Parse(Console.ReadLine());
            Console.Write("Skriv ett tal ");
            double pay2 = double.Parse(Console.ReadLine());
            Console.Write("Skriv ett tal ");
            double pay3 = double.Parse(Console.ReadLine());

            //räkna ut medelvärdet och skicka
            Console.WriteLine($"Medlevärdiga lönen är {(pay1+pay2+pay3)/3}");
        }
    }
}
