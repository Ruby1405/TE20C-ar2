using System;

namespace IF
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is six times nine? ");
            if (Console.ReadLine()=="42")
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("WRONG YOU IMBISILE, IT'S 42!");
            }

            Console.Write("\nVad heter du? ");
            Console.WriteLine($"Hej {Console.ReadLine().ToUpper()}!");
        }
    }
}