using System;
namespace ForLoop { 
    class Program { 
        static void Main(string[] args) { 
            for (var i = 0; i <= 100000; i++) { 
                Console.WriteLine($"{i}"); 
            } 
            Console.WriteLine($"Tick-count: {Environment.TickCount}"); 
        } 
    } 
}