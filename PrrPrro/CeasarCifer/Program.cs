using System;

namespace CeasarCifer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kan kryptera små och stora bokstäver med negativa och positiva hopp
            Console.WriteLine("Running Ceasar Cifer transcryptor.");

            //Skapar variabler
            bool replay = true;
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            string encryption = "";

            //Kör om programmet om man vill det
            while (replay)
            {
                //Låter dig byta alfabet (funkar inte än)
                Console.WriteLine($"Default alphabet:\n{alphabet}\nDo you want to keep it? (y/n)");
                if(Console.ReadLine() == "n"){
                    Console.WriteLine("This feature is not supported right now.");
                    /*
                    Console.WriteLine("Enter new alphabet.");
                    alphabet = Console.ReadLine();
                    */
                }

                //Hur många steg ska hoppas i krypteringen
                Console.WriteLine("How many steps to jump? (integer)");
                int jump = int.Parse(Console.ReadLine());

                //Ska krypteringen endast ge ifrån sig versaler, gemener eller behålla utgångsvärdet
                Console.WriteLine("Only upper, lower or keep case? (u/l/k)");
                string letterCase = Console.ReadLine();
                if(letterCase == "u"){
                    Console.WriteLine("Enter encryption.");
                    encryption = Console.ReadLine().ToUpper();
                }else if(letterCase == "l"){
                    Console.WriteLine("Enter encryption.");
                    encryption = Console.ReadLine().ToLower();
                }else{
                    Console.WriteLine("Enter encryption.");
                    encryption = Console.ReadLine();
                }

                //Tar reda på om vi ska hoppa bakåt
                if(jump > 0)
                {
                    //Stegar igenom varje bokstav
                    for (var i = 0; i < encryption.Length; i++){
                        if (encryption[i] == ' '){
                            //Mellanslag krypteras inte
                            Console.Write(" ");

                        }else if((int)encryption[i]+jump > 122){
                            //Börjar om från början av alfabetet om asciin blir för stor (gemena)
                            Console.Write((char)((int)encryption[i]+jump-alphabet.Length));

                        }else if((int)encryption[i]+jump > 90 && (int)encryption[i] < 61){
                            //Börjar om från början av alfabetet om asciin blir för stor (versaler)
                            Console.Write((char)((int)encryption[i]+jump-alphabet.Length));

                        }else{
                            //Krypterar om inget av förekommande inträffar
                            Console.Write((char)((int)encryption[i]+jump));

                        }
                    }
                }else{//Om vi stegar bakåt gör följande
                    //Stegar igenom varje bokstav
                    for (var i = 0; i < encryption.Length; i++){
                        if (encryption[i] == ' '){
                            //Mellanslag krypteras inte
                            Console.Write(" ");

                        }else if((int)encryption[i]+jump < 41){
                            //Börjar om från slutet om asciin blir för låg (gemena)
                            Console.Write((char)((int)encryption[i]+jump+alphabet.Length));

                        }else if((int)encryption[i]+jump <97 && (int)encryption[i] > 90){
                            //Börjar om från slutet om asciin blir för låg (versaler)
                            Console.Write((char)((int)encryption[i]+jump+alphabet.Length));

                        }else{
                            //Krypterar om inget förekommande inträffar
                            Console.Write((char)((int)encryption[i]+jump));

                        }
                    }
                }

                Console.WriteLine("\nDo you want to rerun? (y/n)");
                if(Console.ReadLine() != "y"){
                    replay = false;
                }
            }
        }
    }
}
