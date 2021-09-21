using System;

namespace Uppgift2._14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv en multiplikation av två decimaltal");
            string answer = Console.ReadLine();
            int multiplierIndex = answer.IndexOf("*");
            double term1 = double.Parse(answer[..multiplierIndex]);
            double term2 = double.Parse(answer[(multiplierIndex+1)..]);
            Console.WriteLine($"Svaret är {term1*term2}");
        }
    }
}
