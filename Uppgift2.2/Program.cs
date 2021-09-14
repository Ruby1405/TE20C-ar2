using System;

namespace Uppgift2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilket årtal är det i år?");
            int aar = int.Parse(Console.ReadLine());
            aar += 20;
            Console.WriteLine("Om 20 år är året " + aar); 
        }
    }
}
