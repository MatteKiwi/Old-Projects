using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasslistan
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Skriv hur många elver du vill ha i listan");
            //Tar fram antalet elever som ska finnas i "klasslistan" från metoden GetNumber();
            int elever = GetNummer();                       
            Console.WriteLine("Genererar: " + elever + " elever");
            //Skapar en string array som lika lång som antalet använderan skrev in, dessutom så skrivs det sedan ut vilken elev som användaren ger namn och efternamn till med hjälp av en for loop  
            string[] elev = new string[elever];
            for (int i = 0; i < (int)elev.Length; i++)
            { 
                Console.WriteLine("Skapar elev: #" + i + 1);
                //Sätter metoden GetElev till false vilket leder till att efternamnet kommer att retuneras först
                elev[i] = GetElev(false);
            }
            //Skapar en slump "genererare" som heter "gen", bestämmer sedan att int x och y slumpgörs på antalet elever 
            Random gen = new Random();
            //Fick hjälp av Vincent under förra uppgiften där han visade mig hur man använder sig av (int). I detta fall använder jag mig av (int) för att kunna slumpa antalet elever
            int x = gen.Next((int)elev.Length);
            int y = gen.Next((int)elev.Length);
            //Skriver ut 2 slumpelever
            Console.WriteLine("Slump elev 1: " + elev[x]);
            Console.WriteLine("Slump elev 2: " + elev[y]);

            Console.ReadLine();

        }
        //En metod som får fram antalet elver som ska finnas med i listan
        static int GetNummer()
        {
            int elever = 0;
            bool success = false;
            //en while loop som körs medans bool success är inte true
            while (!success)
            {
                Console.Write("Skriv ett tal: ");
                success = int.TryParse(Console.ReadLine(), out elever);
                if (success)
                {
                    //hänvissas till kommentaren på line "74"
                    continue;
                }
                //Felmedellande ifal användren skriver in en bokstav och inte siffra i början
                Console.WriteLine("Ej giltigt försök igen");
            }
            return elever;
        }
        //En metod som får fram namnet på "eleven" som användaren skriver in
        static string GetNamn(string instruktioner)
        {
            //string namn är elev namnet
            string namn = "";
            //while loop som köra så tills elev namnets "krav" uppfylls
            while (namn.Length <= 0 || namn.Length > 64)
            {
                Console.Write(instruktioner + ": ");
                namn = Console.ReadLine();
                //if sats som kollar att "kravet" för minst 1 tecken uppfylls i elev namnet. 
                if (namn.Length > 0)
                {
                    //if sats som kollar så att elev namnet inte överstiger "kravet"
                    if (namn.Length <= 64)
                    {
                        //istället för att använda mig av "break;" Hittade jag på stackoverflow "continue"; som då hoppar bara av den nugående if satsen och forstätter till en andra. Detta använder jag istället för "break;" eftersom "break;" skulle ha stopat hela while loopen
                        continue;
                    }
                    //Fel medellande ifall använderen har skrivet ett namn med över 64 tecken
                    Console.WriteLine("För långt, kom ihåg max 64 tecken");
                }
                //else sats som ger ut ett felmedellande ifall användren har skrivit ett namn med inga tecken.
                else
                {
                    
                    Console.WriteLine("För kort, kom ihåg minst 1 tecken");
                }
               
            }
            //metoden returenar sedan elev namnet
            return namn;
        }       
        //En string metoden som kopplas samman till metoden "Getname", dessutom så har denna metod en bool vilket var ett av kraven till provet
        static string GetElev(bool FörnamnFörst)
        {
            //Sätter ut att string namn samt efternamn är lika med metoden Getnamn. Eller då att man får ut förnamnet samt efternamn med hjälp av metoden Getname
            string förnamn = GetNamn("Förnamn");
            string efternamn = GetNamn("Efternamn");

            //if sats som uppfyller kravet i provet att ifall bool var true så skulle förnamnet retuneras först
            if (FörnamnFörst == true)
            {
                return förnamn + " " + efternamn;
            }
            return efternamn + " " + förnamn;
        } 

    }
}
