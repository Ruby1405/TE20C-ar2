using System;

namespace Random
{
    class Program
    {
        static void Main(string[] args)
        {
            string retry = "uwu";
            string[] options = {"Rock","Paper","Scissors","Lizzard","Spock"};
            do{


                Console.WriteLine("Do you wanna go again?");
                retry = Console.ReadLine().ToLower();
            }while(retry == "yes");
        }
    }
}
