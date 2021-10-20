using System;

namespace TypeWrite
{
    class Program
    {
        static void TypeWrite2(string text){
            for(int i = 0; i < text.Length; i++){
                Console.Write(text[i]);
                if(text[i] == ",.!?\n".ToCharArray()){
                    System.Threading.Thread.Sleep(500);
                }else{
                    System.Threading.Thread.Sleep(50);
                }
            }
        }

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
        static void Main(string[] args)
        {
            
            TypeWrite("Hello world! I am your maker.");
            
        }
    }
}
