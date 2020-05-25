using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Threading;

namespace Höstprojekt
{
    class Program
    {
        static void Main(string[] args)
        {
            //kör metoden Welcome
            Welcome();
            //säger att string playerA är lika med metoden PLayername.
            string playerA = PlayerName();
            bool key = false;

            int room = 0;
            // två arrayer, ena med rums beskrivningar av ställerna man kan vara på den andra under är en lite mer onödig array.
            string[] RoomDescriptions = { "Ingum", "Caywold", "Boriedua", "Auciet Tower", "The Tomb of Ulfang the black" };
            string[] Direction = { "Go where? (NORTH | EAST | SOUTH | WEST)" };

            while (room != 5)
            {
                Console.WriteLine("Location: " + RoomDescriptions[room]);
                Console.WriteLine(Direction[0]);
                string input = Console.ReadLine();
                Thread.Sleep(100);
                Console.Clear();

                if (room == 0)
                {
            
                    if (input.ToLower() == "north")
                    {
                        room = 1;
                    }
                    else if (input.ToLower() == "east")
                    {
                        Console.WriteLine("You can't go there");
                    }
                    else if (input.ToLower() == "south")
                    {
                        Console.WriteLine("You can't go there");
                    }
                    else if (input.ToLower() == "west")
                    {
                        Console.WriteLine("You can't go there");
                    }

                }
                else if (room == 1)
                {

                    if (input.ToLower() == "south")
                    {
                        room = 0;
                    }
                    else if (input.ToLower() == "east")
                    {
                        Fightsim();                        
                        Console.ReadLine();
                        key = true;
                        room = 2;
                    }
                    else if (input.ToLower() == "north")
                    {
                        Console.WriteLine("You can't go there");
                    }
                    else if (input.ToLower() == "west")
                    {
                        Console.WriteLine("You can't go there");
                    }
                }
                else if (room == 2)
                {
                    if (input.ToLower() == "west")
                    {                     
                        Console.ReadLine();
                        room = 1;
                    }
                    else if (input.ToLower() == "north")
                    {
                        room = 3;
                    }
                    else if (input.ToLower() == "east")
                    {
                        Console.WriteLine("You can't go there, but...");
                        Thread.Sleep(3000);
                        Fightsim();
                    }
                    else if (input.ToLower() == "south")
                    {
                        Console.WriteLine("You can't go there");
                    }
                }
                else if (room == 3)
                {
                    if (input.ToLower() == "south")
                    {
                        room = 2;
                    }
                    else if (input.ToLower() == "east")
                    {                      
                        room = 4;
                    }
                    else if (input.ToLower() == "north")
                    {
                        Console.WriteLine("You can't go there");
                    }
                    else if (input.ToLower() == "west")
                    {
                        Console.WriteLine("You can't go there");
                    }
                }
                else if (room == 4)
                {

                    if (input.ToLower() == "west")
                    {
                        room = 3;
                    }
                    else if (input.ToLower() == "north" || key == true)
                    {
                        BossFight();                       
                    }
                    else if (input.ToLower() == "east")
                    {
                        Console.WriteLine("You can't go there");
                    }
                    else if (input.ToLower() == "south")
                    {
                        Console.WriteLine("You can't go there");
                    }
                }

            }

            Console.ReadLine();
        }

        static void Welcome() //Metod för att välkomma spelaren, använder sig av foreach för att skriva ut varje bokstav för sig själv
        {
            string Welcome = "Welcome to Tirasea: A medieval realm of silver mountains, shadowed canyons, and vast seas. The realm is mostly populated by humans, though with large numbers of other races. ";
            foreach (char c in Welcome)
            {
                Console.Write(c);
                Thread.Sleep(50);
            }
        }

        static string PlayerName()// Metod för att bestämma playerA namn, använder sig av en while loop med de krav som behövs samt en int.tryparse
        {
            string playerA = "";

            while (playerA.Length < 4 || playerA.Length > 11 || int.TryParse(playerA, out int i)) //while loop som ser till att användaren skriver in rätt kriterier
            {
                Console.WriteLine("\nWhat's your name adventurer? (4-11 characters):");
                playerA = Console.ReadLine();
            }
            Console.WriteLine("Welcome! " + playerA + " to the lands of Tirasea!"); // säger att det användaren har skrivit in funkar som användernamn
            Console.WriteLine("________________________________________________"); //linje för det visuella
            Thread.Sleep(2000);
            Console.Clear();

            return playerA;
        } 

        static string EnemyName()// Metod som slump väljer vad motståndaren heter, den använder sig av en array med 3 namn som sedan väljs ut genom en random generator.
        {
            Random generator = new Random();

            string[] names = { "The tiny Goblin", "The mighty Ogre", "Slow Golem" }; // array med alla namn på dom man kan möta
            int i = generator.Next(3); // 3 är antalet grejer i arrayen
            string Enemies = names[i];  // vi använder det framslumpade talet som index när vi hämtar från arrayen.

            return Enemies;
        } 

        static void Fightsim() // Lång metod för hela slagsmål systemet
        {
            int hpa = 100; // int för playerA hp
            int hpb = 100; // int för Enemies hp 
            int damage = 0; //int för damage, som stoppas in i random gen för att skapa random tal. 
            int acc = 0; // int som användas för accuracy
            int x = 0;  // int som kopplas till metoden Healthcheck så att när ens liv hammar på 0 så slutar while loop. 
    
            Random generator = new Random();

            string Enemies = EnemyName();

            Console.WriteLine(Enemies + " appear"); //anger dess motståndare från arryen names

          
            while (x != 1) //while loop som körs helatiden till ett break; kommand kommer
            {           
                Console.WriteLine("A = Heavy attack"); //säger vilken attack man kan välja antigen A för heave attack eller B för quick attack
                Console.WriteLine("B = Quick attack");

                string input = Console.ReadLine(); //tar svaret från användaren och stoppar in den i strigen input
                acc = generator.Next(0, 100); //skapar ett random tal från 0 till 100 i int acc och detsamma fast för int acc
                Hit();

                if (input.ToLower() == "a" && acc >= 40 && acc <= 100) //if sats som säger att ifall input är lika med stort eller litet "a" sammt ifall int acc är mellan 40 - 100 så ska player A göra skada på player B mellan talen 30 och 45 samt så tar den bort livet från player B
                {                   
                    damage = generator.Next(5, 10);
                    Console.WriteLine("You heavy slam the " + Enemies + " for " + damage + " damage");
                    hpb -= damage;
                    Console.WriteLine();
                }
                if (input.ToLower() == "a" && acc < 40) //if sats som säger ifall input är lika med stort eller litet "a" samt ifall int acc är under talet 40 så missar player A sin attack
                {
                    Console.WriteLine("YOU MISS");
                }
                if (input.ToLower() == "a") // if sats som säger ifall input är lika med stort eller litet "a" så ska player B göra skada på player A från talen 15 - 30 samt så räknas player A liv
                {
                    damage = generator.Next(50, 100);
                    Console.WriteLine(Enemies + " slaps at you for " + damage + " damage");
                    hpa -= damage;
                    Console.WriteLine();
                }
                else if (input.ToLower() == "b" && acc > 20 && acc < 100) // else if sats som säger ifall input är lika med stort eller litet "b" samt ifall acc är över 20 och under 100 så ska player A skada player B för 5-20 skada
                {
                    damage = generator.Next(5, 20);
                    Console.WriteLine("You take your short sword and slice the " + Enemies + " for " + damage + " damage");
                    hpb -= damage;
                }
                if (input.ToLower() == "b" && acc < 20) // if sats för ifall acc hamnar under 20 så missar player A sin attack
                {
                    Console.WriteLine("YOU MISS");
                }
                if (input.ToLower() == "b") //if sats som ifall input är lika med stort eller litet "b" så ska player B skada player A för 5-20 dmg
                {
                    damage = generator.Next(5, 20);
                    Console.WriteLine(Enemies + " slaps back at u for " + damage + " damage");
                    hpa -= damage;
                    Console.WriteLine();
                }
                //visar livet player A och B har kvar efter varje runda
                Console.WriteLine("You have " + hpa + " health left");
                Console.WriteLine(Enemies + " has " + hpb + " health left");
                Console.WriteLine("_________________________________________");
                x = HealthCheck(hpa, hpb, x);              
            }
        }  

        static int HealthCheck(int hpa, int hpb, int x)//metod som är kopplat till slagsmål metoden, den kollar livet på playerA samt enemies och säger vem som vann eller förlorade sammt ifall båda dog
        {
                if (hpa <= 0 && hpb > 0)
                {
                    Console.WriteLine("YOU DIED");
                    Dead();
                }
                if (hpb <= 0 && hpa > 0)
                {
                    Jingle();
                    Console.WriteLine("YOU WON \nAfter looting the corpse you find a health potion and a shiny key. You take the key and drink the health potion. You have regained all your health!");
                    Console.ReadLine();
                    Console.Clear();
                    x = 1;                                      
                }
                if (hpb <= 0 && hpa <= 0)
                {
                    Console.WriteLine("Both died");
                    Dead();
                }

            return x;
        } 
      
        static void Hit()//metod för ljud effekt används i slagsmålmetoden
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\swosh.wav";
            player.Play();
        } 

        static void Dead()//metod för döds ljud effekt spelas när man dör
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\Royalty Free 8 bit death sound effect.wav";
            player.Play();
            Thread.Sleep(5000);
            Console.Clear();
            Environment.Exit(0);
        } 

        static void BossFight() // metod för slutet av spelet, inget speciellt
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\dragon-growl.wav";
            player.Play();

            Console.WriteLine("You open the door with the shiny key");
            Console.WriteLine("BOOM! YOU WON GONCRATZ");
            Thread.Sleep(5000);
            Environment.Exit(0);

        }

        static void Jingle() //ljud effekt som inte funkade :/
        {
            SoundPlayer player = new SoundPlayer();
            player.SoundLocation = AppDomain.CurrentDomain.BaseDirectory + "\\Jingle.wav";
            player.Play();
        }

    }
}
