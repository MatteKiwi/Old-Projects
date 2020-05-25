using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registrering
{
    class Program
    {
        static void Main(string[] args)
        {         
           

            int i; //int för 
            string username = ""; //string för username som är tom
            int level = 0; //level som ligger på 0

            Console.WriteLine("Welcome"); //Texten som kommer upp när det börjar
            Console.WriteLine("Please choose a username (3-32 characters, not only numbers");



            bool succ = false; //En bool för att få while loop att funka

            while (succ == false) //While loop för att välja rätt username
            {
                username = Console.ReadLine();
                int.TryParse(username, out i);  //Tryparse stringen username till int för att sedan i en if statement kolla om den uppfyller kraven

                if (i >= 3 || i <= 32) // if statement för att se om username är större eller lika med 3 samt ifall den e mindre eller lika med 32
                {
                    succ = true; // om den uppfyller kravet blir den while loopen true
                }
                else if (i < 3 || i > 32) // if statement för att se ifall username hammnar under kraven
                {
                    Console.WriteLine("no"); //meddelande ifall det blir fel
                }

            }

            Console.WriteLine("Nice one " + username + " is valid"); //Säger att username är bra
            Console.WriteLine("Choose your level (1-20)"); //frågar vilken level

            while (true) //while loop som går för alltid
            {

                string level1 = Console.ReadLine(); //string för level som kollar med readline
                bool convert2 = int.TryParse(level1, out level); //try parsar level till int level
                     
                if (level >= 1 || level <= 20) // if statement som kollar om level är 1 - 20
                {
                    break;
                }
                else if (level < 1 || level > 20) // ifall den inte är det
                {
                    Console.WriteLine("try again"); //meddalnde som säger försök inte
                }
            }

            Console.WriteLine("Starting at level: " + level + " Good luck out there " + username); //slutsats med level samt usernamet
            Console.ReadLine();

       
        }
    }
}
