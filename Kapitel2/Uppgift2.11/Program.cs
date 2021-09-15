using System;

namespace Uppgift2._11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hur långt hoppade Elin i meter? ");
            double elin = double.Parse(Console.ReadLine());
            Console.Write("Hur långt hoppade Alma i meter? ");
            double alma = double.Parse(Console.ReadLine());
            double skillnad = elin - alma;
            Console.WriteLine($"Elin hoppade {skillnad} meter längre än Alma.");
        }
    }
}
