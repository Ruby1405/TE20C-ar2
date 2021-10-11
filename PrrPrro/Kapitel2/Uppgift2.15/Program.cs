using System;

namespace Uppgift2._15
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sammlar in en mening på tre ord från användaren
            Console.WriteLine("Skriv en mening med tre ord, avsluta med punkt.");
            string text = Console.ReadLine();

            //Lägger in indexing på mellanslag och punkten
            int dotindex = text.IndexOf(".");
            int spaceindex1 = text.IndexOf(" ");
            int spaceindex2 = text.IndexOf(" ",spaceindex1+1);

            //Skriver ut orden i omvänd ordning
            Console.WriteLine($"{text[(spaceindex2+1)..dotindex]} {text[(spaceindex1+1)..spaceindex2]} {text[..spaceindex1]}.");
        }
    }
}
