using System;

namespace Uppgift4._11
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 5; i++){
                Console.WriteLine("Vilket är Europas folkrikaste land?");
                if (Console.ReadLine().ToLower()=="tyskland")
                {
                    Console.WriteLine("Rätt!");
                    break;
                }
                Console.WriteLine($"Fel, du har {4-i} gissningar kvar");
            }
        }
    }
}
