using System;

namespace Sleepsort
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a number to sleep sort");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Interpreted {number}");
            for (var i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
                System.Threading.Thread.Sleep(1);
            }
        }
    }
}
