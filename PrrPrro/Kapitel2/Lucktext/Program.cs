using System;

namespace New_folder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Du ska skriva ett antal ord som detta program kommer använda i en historia.");
            Console.Write("Skriv någon du gillar: ");
            string sample1 = Console.ReadLine();
            Console.Write("Skriv någon du hatar: ");
            string sample2 = Console.ReadLine();
            Console.Write("Skriv någon du uppskattar: ");
            string sample3 = Console.ReadLine();
            Console.Write("Skriv någon du ser upp till: ");
            string sample4 = Console.ReadLine();
            Console.Write("Skriv någon du inte kan namnet på: ");
            string sample5 = Console.ReadLine();
            Console.WriteLine($"Lorem ipsum dolor sit amet, consectetur {sample5} adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud {sample2} exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore {sample2} eu fugiat nulla pariatur {sample3}. Excepteur sint occaecat cupidatat non proident, {sample1} sunt in culpa qui officia deserunt mollit anim id est laborum.");
            
            
        }
    }
}
