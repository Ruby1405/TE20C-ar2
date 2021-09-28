using System;

namespace InteraktivBerättelse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interactiv berättelse.\nPress any key to start!");
            Console.ReadKey();
            Console.Clear();

            //Låter spelaren köra om
            bool körom = true;
            while (körom)
            {   
                //Börjar om om spelaren inte går upp ur sängen
                bool sover = true;
                while (sover)
                {     
                Console.WriteLine("Du vaknar till ljusstrålar som skiner in genom fönsträt, går du upp ur sängen? (ja/nej)");
                //Kollar om spelaren går upp ur sängen och bryter loopen i så fall
                if(Console.ReadLine().ToLower()=="ja")
                {sover = false;}
                else{Console.WriteLine("Du sommar igen.\n");}
                }
                Console.Clear();
                Console.WriteLine("Du går upp ur sängen, du är i ett främmande rum.\nEtt väldigt litet rum,bara 2 gånger 2 meter inrätt med en säng, ett fönster och en dörr.");
                //Börjar om i fall spelarens val inte driver berättelsen framåt
                bool dörr = true;
                while(dörr){
                    Console.WriteLine("Går du ut genom dörren? (ja/nej)");
                    //Kollar om spelaren går ut genom dörren
                    if(Console.ReadLine().ToLower()=="ja")
                    {
                        dörr = false;//Bryter dörrloopen
                        Console.Clear();
                        Console.WriteLine("Du går ut ur huset och ser dig omkring, huset är borta.\nRunt om dig finns bara hav så långt ögat kan nå.\nDu står på vad som ser ut som en rund flytande sten.");
                        //Loopar om spelaren inte vill kolla på plattan
                        bool platta = true;
                        while (platta)
                        {
                            Console.WriteLine("Mitt på stenen finns en platta med fyra bokstäver på; n, e, s & w.\nUndersöker du plattan? (ja/nej)");
                            //Kollar om spelaren kollar på plattan och bryter loopen i så fall
                            if(Console.ReadLine().ToLower() == "ja"){
                                platta = false;
                            }
                        }
                        Console.WriteLine("\nDu inser att det går att trycka på bokstäverna,\nnär du gör det förflyttas plattan åt olika håll.");
                        //Ser till att spelaren kommer styra stenen 4 gånger innan den sjunker
                        int styr = 0;
                        while (styr <4)
                        {
                        Console.WriteLine("Vilken bokstav trycker du på? (n/e/s/w)");
                        //Det spelar ingen roll vilket håll de styr
                        Console.ReadLine();
                        Console.WriteLine("\nStenen rör sig fort i vattnent.\n");
                        styr += 1; //Stegar upp styrnings variabeln
                        }
                        Console.Clear();
                        Console.WriteLine("Stenen sjunker och du ligger nu i vattnet.");
                        //Ser till att spelaren drunknar oavsätt
                        int simmar= 0;
                        while (simmar <6)
                        {
                        Console.WriteLine("Simmar du? (ja/nej)");
                        if(Console.ReadLine().ToLower() == "ja"){
                            Console.WriteLine("\nDu simmar och håller dig flytande.\n");
                                simmar += 1; 
                        }else{
                            simmar = 7;
                        }
                        }
                        if(simmar == 6){
                            Console.WriteLine("\nDu blir trött.");//Om spelaren simmade 6 gånger drunknar de för att de blir trötta
                        }
                        Console.WriteLine("\nDu drunknade, du är död!\n");
                        Console.ReadKey();
                    }else{
                        Console.WriteLine("\nDu står mitt i rummet och får en känsla av att du lämmnade gasen igång på spisen.\nStänger du av spisen? (ja/nej)");
                        //Kollar om de stänger av spisen
                        if(Console.ReadLine().ToLower()=="ja"){
                            Console.Clear();
                            Console.WriteLine("Du inser att det inte finns en spis, du står igen i mitten av rummet inrätt med en säng, ett fönster och en dörr.");
                        }else{
                            Console.WriteLine("\nGasen antänder, huset sprängs i luften, du är död!\n");
                            dörr = false;
                            Console.ReadKey();
                        }
                    }
                }
                Console.Clear();
                Console.WriteLine("Vill du köra om från början? (ja/nej)");
                //Kollar om spelaren vill köra om
                if(Console.ReadLine().ToLower()!="ja"){
                    körom=false;
                    Console.Clear();
                }
            }
        }
    }
}
