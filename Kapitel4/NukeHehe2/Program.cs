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
            Console.Clear();
            
            TypeWrite("Runing system login...\nSuccess!\nConfiguring files...\nFailure!\nRetrying...\nSuccess!\nTerminal entry: ");

            Console.ReadLine();
            TypeWrite("Instructions unclear,\nCorrecting...\nInterpreted \"launch nuke\"\nConfirmation? ");

            if(Console.ReadLine().ToLower()=="yes"){
            TypeWrite("Interpreted \"yes\".\nRunning C:\\skynet\\terminalcommand\\nuke\\launch.exe\nDecrypting launch codes...\nFailure!\nRetrying...\nFailure!\nRetrying...\nFailure!\nBooting quad processing...\nRestarting terminal...");
            }else{
            TypeWrite("Confirmation unclear,\nCorrecting...\nInterpreted \"yes\".\nRunning C:\\skynet\\terminalcommand\\nuke\\launch.exe\nDecrypting launch codes...\nFailure!\nRetrying...\nFailure!\nRetrying...\nFailure!\nBooting quad processing...\nRestarting terminal...");
            }

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

            if(Console.ReadLine().ToLower()=="yes"){
            TypeWrite($"Interpreted \"yes\"\nLaunching missile...\nMissile launched, estimated time of arrival: {System.DateTime.Now.AddMinutes(3)} (3 minutes)");
            }else{
            TypeWrite($"Confirmation unclear,\nCorrecting...\nInterpreted \"yes\"\nLaunching missile...\nMissile launched, estimated time of arrival: {System.DateTime.Now.AddMinutes(3)} (3 minutes)\nLogging out...");
            }
            

            int tickTock = 0;
            for(int i=1; i<180; i++){
                Console.Clear();
                switch(tickTock){
                    case 1:
                        Console.WriteLine("            \n    _.=a@@@@@@@a=._\n  _d@@**^¨   ¨^**@@b_\n.d@/´      |  /  `\\@b.\nd@P        | /     \\@b\n@P         |/       \\@\n@|         @        |@\n@b                  d@\n\\@b                d@/\n`\\@\\_            _/@/´\n  `\\@@==._   _.==@@/´\n    `'=a@@@@@@@a='´");
                        break;
                    case 2:
                        Console.WriteLine("            \n    _.=a@@@@@@@a=._\n  _d@@**^¨   ¨^**@@b_\n.d@/´      |     `\\@b.\nd@P        |       \\@b\n@P         |        \\@\n@|         @------  |@\n@b                  d@\n\\@b                d@/\n`\\@\\_            _/@/´\n  `\\@@==._   _.==@@/´\n    `'=a@@@@@@@a='´");
                        break;
                    case 3:
                        Console.WriteLine("            \n    _.=a@@@@@@@a=._\n  _d@@**^¨   ¨^**@@b_\n.d@/´      |     `\\@b.\nd@P        |       \\@b\n@P         |        \\@\n@|         @        |@\n@b          \\       d@\n\\@b          \\     d@/\n`\\@\\_         \\  _/@/´\n  `\\@@==._   _.==@@/´\n    `'=a@@@@@@@a='´");
                        break;
                    case 4:
                        Console.WriteLine("            \n    _.=a@@@@@@@a=._\n  _d@@**^¨   ¨^**@@b_\n.d@/´      |     `\\@b.\nd@P        |       \\@b\n@P         |        \\@\n@|         @        |@\n@b         |        d@\n\\@b        |       d@/\n`\\@\\_      |     _/@/´\n  `\\@@==._   _.==@@/´\n    `'=a@@@@@@@a='´");
                        break;
                    case 5:
                        Console.WriteLine("            \n    _.=a@@@@@@@a=._\n  _d@@**^¨   ¨^**@@b_\n.d@/´      |     `\\@b.\nd@P        |       \\@b\n@P         |        \\@\n@|         @        |@\n@b        /         d@\n\\@b      /         d@/\n`\\@\\_   /        _/@/´\n  `\\@@==._   _.==@@/´\n    `'=a@@@@@@@a='´");
                        break;
                    case 6:
                        Console.WriteLine("            \n    _.=a@@@@@@@a=._\n  _d@@**^¨   ¨^**@@b_\n.d@/´      |     `\\@b.\nd@P        |       \\@b\n@P         |        \\@\n@|   ------@        |@\n@b                  d@\n\\@b                d@/\n`\\@\\_            _/@/´\n  `\\@@==._   _.==@@/´\n    `'=a@@@@@@@a='´");
                        break;
                    case 7:
                        Console.WriteLine("            \n    _.=a@@@@@@@a=._\n  _d@@**^¨   ¨^**@@b_\n.d@/´   \\  |     `\\@b.\nd@P      \\ |       \\@b\n@P        \\|        \\@\n@|         @        |@\n@b                  d@\n\\@b                d@/\n`\\@\\_            _/@/´\n  `\\@@==._   _.==@@/´\n    `'=a@@@@@@@a='´");
                        break;
                    case 8:
                        Console.WriteLine("            \n    _.=a@@@@@@@a=._\n  _d@@**^¨   ¨^**@@b_\n.d@/´      |     `\\@b.\nd@P        |       \\@b\n@P         |        \\@\n@|         @        |@\n@b                  d@\n\\@b                d@/\n`\\@\\_            _/@/´\n  `\\@@==._   _.==@@/´\n    `'=a@@@@@@@a='´");
                        tickTock = 0;
                        break;
                }
                Console.WriteLine($"Time remaining until arrival {180-i} seconds!");
                tickTock++;
                System.Threading.Thread.Sleep(1000);
            }
            /*
            \n    _.=a@@@@@@@a=._
            \n  _d@@**^¨   ¨^**@@b_
            \n.d@/´      |     `\\@b.
            \nd@P        |       \\@b
            \n@P         |        \\@
            \n@|         @        |@
            \n@b                  d@
            \n\@b                d@/
            \n`\@\_            _/@/´
            \n  `\@@==._   _.==@@/´
            \n    `'=a@@@@@@@a='´
            */

            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
        }
    }
}
