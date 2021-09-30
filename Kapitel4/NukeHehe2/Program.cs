using System;

namespace NukeHehe2
{
    class Program
    {
        static void TypeWrite(string text){
            for(int i = 0; i < text.Length; i++){
                Console.Write(text[i]);
                if(text[i] == ',' || text[i] == '.' || text[i] == '!' || text[i] == '?' || text[i] == '\n'){
                    System.Threading.Thread.Sleep(500);
                }else{
                    System.Threading.Thread.Sleep(50);
                }
            }
        }

        static void QuadProcessType(string text){
            for(int i = 0; i < text.Length; i++){
                Console.Clear();
                Console.WriteLine(text[..i]);
                Console.WriteLine(text[..i]);
                Console.WriteLine(text[..i]);
                Console.WriteLine(text[..i]);
                if(text[i] == ',' || text[i] == '.' || text[i] == '!' || text[i] == '?' || text[i] == '\n'){
                    System.Threading.Thread.Sleep(500);
                }else{
                    System.Threading.Thread.Sleep(50);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            TypeWrite("Runing system login...\nSuccess!\nConfiguring files...\nFailure!\nRetrying...\nSuccess!\nTerminal entry: ");
            Console.ReadLine();

            TypeWrite("Instructions unclear,\nCorrecting...\nInterpreted \"launch nuke\"\nConfirmation? ");
            Console.ReadLine();

            TypeWrite("Confirmation unclear,\nCorrecting...\nInterpreted \"yes\".\nRunning C:\\skynet\\terminalcommand\\nuke\\launch.exe\nDecrypting launch codes...\nFailure!\nRetrying...\nFailure!\nRetrying...\nFailure!\nBooting quad processing...\nRestarting terminal...");

            QuadProcessType("Decrypting launch codes... Failure!");

            string text5 = "Retrying... Failure!";
            QuadProcessType(text5);

            string text6 = "Retrying... Success!";
            for(int i = 0; i < text5.Length; i++){
                Console.Clear();
                Console.WriteLine(text5[..i]);
                Console.WriteLine(text5[..i]);
                Console.WriteLine(text6[..i]);
                Console.WriteLine(text5[..i]);
                if(text5[i] == ',' || text5[i] == '.' || text5[i] == '!' || text5[i] == '?' || text5[i] == '\n'){
                    System.Threading.Thread.Sleep(500);
                }else{
                    System.Threading.Thread.Sleep(50);
                }
            }

            Console.Clear();
            Console.WriteLine("--------------------\n--------------------\nRetrying... Success!\n--------------------");
            System.Threading.Thread.Sleep(500);
            Console.Clear();
            Console.WriteLine("Retrying... Success!");
            
            TypeWrite("Connection established\nArming missile...\nSuccess\nTarget coordinates: ");
            Console.ReadLine();

            TypeWrite("Target unclear,\nCorrecting...\nInterpreted \"59.337N 18.046E\"\nApproximate distance from user to target: 50 meters\nConfirmation? ");
            Console.ReadLine();
            
            TypeWrite($"Confirmation unclear,\nCorrecting...\nInterpreted \"yes\"\nLaunching missile...\nMissile launched, estimated time of arrival: {System.DateTime.Now.AddMinutes(3)} (3 minutes)");

            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
        }
    }
}
