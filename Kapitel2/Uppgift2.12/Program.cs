using System;

namespace Uppgift2._12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hur länge ska du hyra bilen? ");
            double dagar = double.Parse(Console.ReadLine());
            Console.Write("Hur långt ska du köra? ");
            double km = double.Parse(Console.ReadLine());
            Console.WriteLine($"Det kommer kosta {dagar*500+km+300}kr");
        }
    }
}
