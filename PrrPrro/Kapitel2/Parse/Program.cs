using System;

namespace Parse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Hur gammal är du? ");
            double age = double.Parse(Console.ReadLine());
            Console.Write($"Du är {age} år gammal");
            if(age<20){Console.WriteLine($" och du har {20-age} år kvar tills du kan gå på systemet");}
            Console.Write("Hur mycket väger du? ");

            double weight = double.Parse(Console.ReadLine()) *2.2;
            string weightString = weight.ToString("0.##");
            Console.WriteLine($"Din vikt är {weightString} i lbs");
        }
    }
}
