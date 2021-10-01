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

            string text1 = "Retrying... Failure!";
            QuadProcessType(text1);

            string text2 = "Retrying... Success!";
            for(int i = 0; i < text1.Length; i++){
                Console.Clear();
                Console.WriteLine(text1[..i]);
                Console.WriteLine(text1[..i]);
                Console.WriteLine(text2[..i]);
                Console.WriteLine(text1[..i]);
                if(text1[i] == ',' || text1[i] == '.' || text1[i] == '!' || text1[i] == '?' || text1[i] == '\n'){
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
            
            TypeWrite("Connection established\nArming missile...\nSuccess!\nTarget coordinates: ");

            Console.ReadLine();
            TypeWrite("Target unclear,\nCorrecting...\nInterpreted \"59.337N 18.046E\"\nApproximate distance from user to target: 50 meters\nConfirmation? ");

            DateTime ETA = System.DateTime.Now.AddMinutes(3);
            if(Console.ReadLine().ToLower()=="yes"){
            TypeWrite($"Interpreted \"yes\"\nLaunching missile...\nMissile launched, estimated time of arrival: {System.DateTime.Now.AddMinutes(3)} (3 minutes)");
            }else{
            TypeWrite($"Confirmation unclear,\nCorrecting...\nInterpreted \"yes\"\nLaunching missile...\nMissile launched, estimated time of arrival: {ETA} (3 minutes)\nLogging out...");
            }
            
            Console.Clear();
            string text3 = $"    _.=a@@@@@@@a=._\n  _d@@**^¨   ¨^**@@b_\n.d@/´      |  /  `\\@b.\nd@P        | /     \\@b\n@P         |/       \\@\n@|         @        |@\n@b                  d@\n\\@b                d@/\n`\\@\\_            _/@/´\n  `\\@@==._   _.==@@/´\n    `'=a@@@@@@@a='´\nMissile target: 59.337N 18.046E (distance user-target: 50m)\nEstimated time of arrival {ETA}\nTime remaining until arrival {180} seconds!";
            for(int i = 0; i < text3.Length; i++){
                Console.Write(text3[i]);
                System.Threading.Thread.Sleep(10);
            }
            
            int tickTock = 1;
            for(int i=1; i<180; i++){
                Console.Clear();
                switch(tickTock){
                    case 1:
                        Console.WriteLine("    _.=a@@@@@@@a=._\n  _d@@**^¨   ¨^**@@b_\n.d@/´      |  /  `\\@b.\nd@P        | /     \\@b\n@P         |/       \\@\n@|         @        |@\n@b                  d@\n\\@b                d@/\n`\\@\\_            _/@/´\n  `\\@@==._   _.==@@/´\n    `'=a@@@@@@@a='´");
                        break;
                    case 2:
                        Console.WriteLine("    _.=a@@@@@@@a=._\n  _d@@**^¨   ¨^**@@b_\n.d@/´      |     `\\@b.\nd@P        |       \\@b\n@P         |        \\@\n@|         @------  |@\n@b                  d@\n\\@b                d@/\n`\\@\\_            _/@/´\n  `\\@@==._   _.==@@/´\n    `'=a@@@@@@@a='´");
                        break;
                    case 3:
                        Console.WriteLine("    _.=a@@@@@@@a=._\n  _d@@**^¨   ¨^**@@b_\n.d@/´      |     `\\@b.\nd@P        |       \\@b\n@P         |        \\@\n@|         @        |@\n@b          \\       d@\n\\@b          \\     d@/\n`\\@\\_         \\  _/@/´\n  `\\@@==._   _.==@@/´\n    `'=a@@@@@@@a='´");
                        break;
                    case 4:
                        Console.WriteLine("    _.=a@@@@@@@a=._\n  _d@@**^¨   ¨^**@@b_\n.d@/´      |     `\\@b.\nd@P        |       \\@b\n@P         |        \\@\n@|         @        |@\n@b         |        d@\n\\@b        |       d@/\n`\\@\\_      |     _/@/´\n  `\\@@==._   _.==@@/´\n    `'=a@@@@@@@a='´");
                        break;
                    case 5:
                        Console.WriteLine("    _.=a@@@@@@@a=._\n  _d@@**^¨   ¨^**@@b_\n.d@/´      |     `\\@b.\nd@P        |       \\@b\n@P         |        \\@\n@|         @        |@\n@b        /         d@\n\\@b      /         d@/\n`\\@\\_   /        _/@/´\n  `\\@@==._   _.==@@/´\n    `'=a@@@@@@@a='´");
                        break;
                    case 6:
                        Console.WriteLine("    _.=a@@@@@@@a=._\n  _d@@**^¨   ¨^**@@b_\n.d@/´      |     `\\@b.\nd@P        |       \\@b\n@P         |        \\@\n@|   ------@        |@\n@b                  d@\n\\@b                d@/\n`\\@\\_            _/@/´\n  `\\@@==._   _.==@@/´\n    `'=a@@@@@@@a='´");
                        break;
                    case 7:
                        Console.WriteLine("    _.=a@@@@@@@a=._\n  _d@@**^¨   ¨^**@@b_\n.d@/´   \\  |     `\\@b.\nd@P      \\ |       \\@b\n@P        \\|        \\@\n@|         @        |@\n@b                  d@\n\\@b                d@/\n`\\@\\_            _/@/´\n  `\\@@==._   _.==@@/´\n    `'=a@@@@@@@a='´");
                        break;
                    case 8:
                        Console.WriteLine("    _.=a@@@@@@@a=._\n  _d@@**^¨   ¨^**@@b_\n.d@/´      |     `\\@b.\nd@P        |       \\@b\n@P         |        \\@\n@|         @        |@\n@b                  d@\n\\@b                d@/\n`\\@\\_            _/@/´\n  `\\@@==._   _.==@@/´\n    `'=a@@@@@@@a='´");
                        tickTock = 0;
                        break;
                }
                Console.WriteLine($"Missile target: 59.337N 18.046E (distance user-target: 50m)\nEstimated time of arrival {ETA}\nTime remaining until arrival {180-i} seconds!");
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
