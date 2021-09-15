using System;

namespace Uppgift2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hej! var kommer du ifrån?");
            string bostad = Console.ReadLine();
            Console.WriteLine("Vad är ditt drömresmål?");
            string resmaal = Console.ReadLine();
            Console.WriteLine("Hej " + bostad + "-bo. Jag hoppas att du får resa till " + resmaal + ".");
        }
    }
}
