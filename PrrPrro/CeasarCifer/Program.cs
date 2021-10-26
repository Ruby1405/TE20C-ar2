using System;

namespace CeasarCifer
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kan kryptera små och stora bokstäver med negativa och positiva hopp
            Console.WriteLine("Running Ceasar Cifer transcryptor.");
            bool replay = true;
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            string encryption = "";

            while (replay)
            {
                Console.WriteLine($"Default alphabet:\n{alphabet}\nDo you want to keep it? (y/n)");
                if(Console.ReadLine() == "n"){
                    Console.WriteLine("This feature is not supported right now.");
                    /*
                    Console.WriteLine("Enter new alphabet.");
                    alphabet = Console.ReadLine();
                    */
                }

                Console.WriteLine("How many steps to jump? (integer)");
                int jump = int.Parse(Console.ReadLine());

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

                if(jump > 0)
                {
                    for (var i = 0; i < encryption.Length; i++){
                        if (encryption[i] == ' '){

                            Console.Write(" ");

                        }else if((int)encryption[i]+jump > 122){

                            Console.Write((char)((int)encryption[i]+jump-alphabet.Length));

                        }else if((int)encryption[i]+jump > 90 && (int)encryption[i] < 61){

                            Console.Write((char)((int)encryption[i]+jump-alphabet.Length));

                        }else{

                            Console.Write((char)((int)encryption[i]+jump));

                        }
                    }
                }else{
                    for (var i = 0; i < encryption.Length; i++){
                        if (encryption[i] == ' '){

                            Console.Write(" ");

                        }else if((int)encryption[i]+jump < 41){

                            Console.Write((char)((int)encryption[i]+jump+alphabet.Length));

                        }else if((int)encryption[i]+jump <97 && (int)encryption[i] > 90){

                            Console.Write((char)((int)encryption[i]+jump+alphabet.Length));

                        }else{

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
