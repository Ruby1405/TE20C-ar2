using System;

namespace NukeHehe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            string text1 = "Runing system login...\nSuccess!\nConfiguring files...\nFailure!\nRetrying...\nSuccess!\nTerminal entry: ";

            for(int i = 0; i < text1.Length; i++){
                Console.Write(text1[i]);
                if(text1[i] == ',' || text1[i] == '.' || text1[i] == '!' || text1[i] == '?' || text1[i] == '\n'){
                    System.Threading.Thread.Sleep(500);
                }else{
                    System.Threading.Thread.Sleep(50);
                }
            }
            Console.ReadLine();

            string text2 = "Instructions unclear,\nCorrecting...\nInterpreted \"launch nuke\"\nConfirmation? ";

            for(int i = 0; i < text2.Length; i++){
                Console.Write(text2[i]);
                if(text2[i] == ',' || text2[i] == '.' || text2[i] == '!' || text2[i] == '?' || text2[i] == '\n'){
                    System.Threading.Thread.Sleep(500);
                }else{
                    System.Threading.Thread.Sleep(50);
                }
            }
            Console.ReadLine();

            string text3 = "Confirmation unclear,\nCorrecting...\nInterpreted \"yes\".\nRunning C:\\skynet\\terminalcommand\\nuke\\launch.exe\nDecrypting launch codes...\nFailure!\nRetrying...\nFailure!\nRetrying...\nFailure!\nBooting quad processing...\nRestarting terminal...";

            for(int i = 0; i < text3.Length; i++){
                Console.Write(text3[i]);
                if(text3[i] == ',' || text3[i] == '.' || text3[i] == '!' || text3[i] == '?' || text3[i] == '\n'){
                    System.Threading.Thread.Sleep(500);
                }else{
                    System.Threading.Thread.Sleep(50);
                }
            }

            string text4 = "Decrypting launch codes... Failure!";

            for(int i = 0; i < text4.Length; i++){
                Console.Clear();
                Console.WriteLine(text4[..i]);
                Console.WriteLine(text4[..i]);
                Console.WriteLine(text4[..i]);
                Console.WriteLine(text4[..i]);
                if(text4[i] == ',' || text4[i] == '.' || text4[i] == '!' || text4[i] == '?' || text4[i] == '\n'){
                    System.Threading.Thread.Sleep(500);
                }else{
                    System.Threading.Thread.Sleep(50);
                }
            }

            string text5 = "Retrying... Failure!";

            for(int i = 0; i < text5.Length; i++){
                Console.Clear();
                Console.WriteLine(text5[..i]);
                Console.WriteLine(text5[..i]);
                Console.WriteLine(text5[..i]);
                Console.WriteLine(text5[..i]);
                if(text5[i] == ',' || text5[i] == '.' || text5[i] == '!' || text5[i] == '?' || text5[i] == '\n'){
                    System.Threading.Thread.Sleep(500);
                }else{
                    System.Threading.Thread.Sleep(50);
                }
            }

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
            
            string text7 = "Connection established\nArming missile...\nSuccess\nTarget coordinates: ";
            
            for(int i = 0; i < text7.Length; i++){
                Console.Write(text7[i]);
                if(text7[i] == ',' || text7[i] == '.' || text7[i] == '!' || text7[i] == '?' || text7[i] == '\n'){
                    System.Threading.Thread.Sleep(500);
                }else{
                    System.Threading.Thread.Sleep(50);
                }
            }
            Console.ReadLine();

            string text8 = "Target unclear,\nCorrecting...\nInterpreted \"59.337N 18.046E\"\nApproximate distance from user to target: 50 meters\nConfirmation? ";
            
            for(int i = 0; i < text8.Length; i++){
                Console.Write(text8[i]);
                if(text8[i] == ',' || text8[i] == '.' || text8[i] == '!' || text8[i] == '?' || text8[i] == '\n'){
                    System.Threading.Thread.Sleep(500);
                }else{
                    System.Threading.Thread.Sleep(50);
                }
            }
            Console.ReadLine();
            
            string text9 = $"Confirmation unclear,\nCorrecting...\nInterpreted \"yes\"\nLaunching missile...\nMissile launched, estimated time of arrival: {System.DateTime.Now.AddMinutes(3)} (3 minutes)";
            
            for(int i = 0; i < text9.Length; i++){
                Console.Write(text9[i]);
                if(text9[i] == ',' || text9[i] == '.' || text9[i] == '!' || text9[i] == '?' || text9[i] == '\n'){
                    System.Threading.Thread.Sleep(500);
                }else{
                    System.Threading.Thread.Sleep(50);
                }
            }

            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
        }
    }
}
