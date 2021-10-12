using System;

namespace Uppgift4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilket är världens folkrikaste land?");
            string answer = Console.ReadLine(); //Hämtar svar
            while (answer.ToLower() != "kina") //Kollar om svar är fel
            {
                Console.WriteLine("Fel, försök igen");
                answer = Console.ReadLine(); //Tillåter en att försöka igen
            }

            Console.WriteLine("Rätt!");
        }
    }
}
