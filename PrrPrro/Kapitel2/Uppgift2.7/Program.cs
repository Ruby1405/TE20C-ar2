using System;

namespace Uppgift2._7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv två ord på en rad");
            string text = Console.ReadLine();
            int indexspace = text.IndexOf(" ");
            Console.WriteLine(text[(indexspace+1)..]+""+text[..indexspace]);
        }
    }
}
