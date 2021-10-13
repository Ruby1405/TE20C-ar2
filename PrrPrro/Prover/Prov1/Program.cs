using System;

namespace Prov
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean restart = false;
            do
            {
                Console.WriteLine("Nättolönekalkylator.\nVad heter du?");
                string namn = Console.ReadLine(); //Frågar vad användaren heter

                Console.WriteLine("Vad känar du? (i kronor)");
                float brutto = float.Parse(Console.ReadLine()); //Frågar vad användaren känar brutto

                //Kollar att svaret är giltigt
                if (brutto > 10000 && brutto < 45000)
                {
                    Console.WriteLine("Vad har du för inkomstskatt? (i procent)");
                    float skatt = float.Parse(Console.ReadLine());

                    //Kollar att svaret är giltigt
                    if (skatt > 10 && skatt < 45)
                    {
                        Console.WriteLine($"Du betalar {brutto * ((100 - skatt) / 100)}kr i skatt.\nVill du köra om? (ja/nej)");
                    }
                    else
                    {
                        //Om svaret inte var giligt förklarar systemet varför
                        Console.WriteLine("Programmet kan bara hantera skatt mellan 10% och 45%\nVill du köra om? (ja/nej)");
                    }

                }
                else
                {
                    //Om svaret inte var giligt förklarar systemet varför
                    Console.WriteLine("Programmet kan bara hantera bruttoinkomster mellan 10000 och 45000\nVill du köra om? (ja/nej)");
                }

                if (Console.ReadLine() == "ja")//Kollar om användaren vill köra om
                    restart = true;
            } while (restart);//Startar om om användaren vill



        }
    }
}
