using System;

namespace Uppgift2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv två tal");
            int tal1 = int.Parse(Console.ReadLine());
            int tal2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Medelvärdet är " + ((tal1+tal2)/2));
        }
    }
}
