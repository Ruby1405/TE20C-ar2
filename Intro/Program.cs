using System;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nWhat is 6 times 9?");
            string answer = Console.ReadLine();
            if(answer == "42"){
                Console.WriteLine("Correct!\n");
            }else{
                Console.WriteLine("Wrong, 42!");
                Console.ReadLine();
                Console.WriteLine("You truly a pathetic being not to know this, it's\nalmost like you haven't read\nThe Hitchiker's Guide to the Galaxy.\n");
            }
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
