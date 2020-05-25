using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekplats
{
    class Program
    {
        static void Main(string[] args)
        {
            string svar = ""; // Skapa en tom svarsvariabel

            // Loopa så länge svar varken är a eller b
            while (svar != "a" && svar != "b")
            {
                Console.Write("Välj a eller b:");

                // Hämta in ett nytt värde för svar
                svar = Console.ReadLine();

                // Om svaret inte var a eller b, skriv ut ett felmeddelande
                if (svar != "a" && svar != "b")
                {
                    Console.WriteLine("Du måste välja a eller b");
                }
            }
          
            Console.WriteLine("x + 5 = 10");

            bool succ = false;
            while (succ == false)
            {
                string input = Console.ReadLine();
                bool succ2 = int.TryParse(input, out int i);

                if (i == 5)
                {
                    Console.WriteLine("Nice");
                    Console.WriteLine("Vad smart du är");
                    succ = true;
                }
                if (i !=5)
                {
                    Console.WriteLine("Not this time");
                }
            }         
            Console.ReadLine();
        }
    }
}
