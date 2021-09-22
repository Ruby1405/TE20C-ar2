using System;

namespace IF
{
    class Program
    {
        static void Main(string[] args)
        {
            //En if sats som kollar om användaren läst liftarens guide till gallaxen
            Console.Write("What is six times nine? ");
            if (Console.ReadLine()=="42")
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("WRONG YOU IMBISILE, IT'S 42!");
            }

            //Säger hej till användaren med deras namn i versaler
            Console.Write("\nVad heter du? ");
            Console.WriteLine($"Hej {Console.ReadLine().ToUpper()}!");
        }
    }
}