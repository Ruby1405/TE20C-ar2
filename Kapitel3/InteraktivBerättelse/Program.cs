using System;

namespace InteraktivBerättelse
{
    class Program
    {
        static void Main(string[] args)
        {
            bool lvl1 = true;
            while (lvl1)
            {     
            Console.WriteLine("Du vaknar till ljusstrålar som skiner in genom fönsträt, går du upp ur sängen? (ja/nej)");
            if(Console.ReadLine().ToLower()=="ja")
            {lvl1 = false;}
            else{Console.WriteLine("Du sommar igen.");}
            }
            Console.Write("Du går upp ur sängen, du är i ett främmande rum.\nEtt väldigt litet rum,bara 2 gånger 2 meter inrätt med en säng, ett fönster och en dörr.\nGår du ut genom dörren? (ja/nej)");
            if(Console.ReadLine().ToLower()=="ja")
            {

            }else{
                Console.Write("Du står mitt i rummet och får en känsla av att du lämmnade gasen igång på spisen.");
            }
        }
    }
}
