using System;

namespace Uppgift2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur högt kan du hoppa i meter?");
            double hopp = 2.45 - double.Parse(Console.ReadLine());
            Console.WriteLine("Rekordet i höjdhopp är " + hopp + " meter högre.");
        }
    }
}
