using System;
using System.Text;

namespace EngFlowchart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Clear();
            Console.WriteLine("Engineering Flowchart 😎");
            
            Console.Write("Does it move? (y/n) ");
            if(Console.ReadLine().ToLower() == "y"){
                Console.Write("Should it move? (y/n) ");
                if(Console.ReadLine().ToLower() == "y"){
                    Console.WriteLine("Don't touch it!");
                }else{
                    Console.WriteLine("Use duct tape!");
                }
            }else{
                Console.Write("Should it move? (y/n) ");
                if(Console.ReadLine().ToLower() == "y"){
                    Console.WriteLine("Use lubricant!");
                }else{
                    Console.WriteLine("Don't touch it!");
                }
            }
        }
    }
}
