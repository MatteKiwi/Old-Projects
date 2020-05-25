using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Fightsim
{
    class Program
    {
        static void Main(string[] args)
        {
            int damage = 0; //int för skada man gör, 
            int acc = 0; //int för accuracy som sedan stoppas in i en random gen
            int acc2 = 0; // int för accuracy som sedan stoppas in i en random gen
            int x; //tom int för en int try.parse
            string playerA = "";  //string för namnet på player A som är tom men fylls i av användaren        
            string replay = ""; //tom string för en while loop som kör om hela spelet

            Console.ForegroundColor = ConsoleColor.Red; // ändrar färgen till röd, så att ascii art ska se bättre ut

            string art = @"___ _ ____ ____ ____ ____ _________ ____ ____ ____ ____ ____ 
||F |||I |||G |||H |||T |||       |||A |||R |||E |||N |||A ||
||__|||__|||__|||__|||__|||_______|||__|||__|||__|||__|||__||
|/__\|/__\|/__\|/__\|/__\|/_______\|/__\|/__\|/__\|/__\|/__\|";  //ascii art för namnet av spelet

            Random generator = new Random();

            Console.WriteLine(art); //ascii art skrivs ut i consolen
            Console.ForegroundColor = ConsoleColor.White; // återställer färgen från röd till vit för texten

            Console.WriteLine(); // tom writeline för att skapa mellanrum
            Console.WriteLine("WELCOME LADIES AND GENTELMEN'S TO THE FIGHT ARENA"); //text som kommer upp i början

            while (playerA.Length < 4 || playerA.Length > 11 || int.TryParse(Console.ReadLine(), out x)) //while loop som ser till att användaren skriver in rätt kriterier
            {
                Console.WriteLine("Player A come forth and type thy name (4-11 characters):");
                playerA = Console.ReadLine();
            }
            Console.WriteLine("Congratulations! " + playerA + " is valid!"); // säger att det användaren har skrivit in funkar som användernamn
            Console.WriteLine("________________________________________________"); //linje för det visuella

            Thread.Sleep(2000); //en delay på 2 s 
            Console.Clear(); // tar bort allt text efter delayen.

            while (replay != "no") //en while loop för hela "matchen" så att man kan spela om den
            {
                int hpa = 100; // int för playerA hp
                int hpb = 100; // int för playerB hp
                int round = 1; // int för rundan börjar på 1 och det går upp med en efter varje runda med en round++; 

                string[] names = { "Juanito", "Carlos", "Jesus" }; // array med alla namn på dom man kan möta

                int i = generator.Next(3); // 3 är antalet grejer i arrayen

                string playerB = names[i];  // vi använder det framslumpade talet som index när vi hämtar från arrayen.

                Console.WriteLine("Welcome " + playerA); //säger välkommen till spelaren samt säger dess namn

                Console.WriteLine("Your opponent is: " + playerB); //anger dess motståndare från arryen names

                while (true) //while loop som körs helatiden till ett break; kommand kommer
                {
                    Console.WriteLine("");
                    Console.WriteLine("Round:" + round); //anger vilken runda man är på 
                    Console.WriteLine("A = Heavy attack"); //säger vilken attack man kan välja antigen A för heave attack eller B för quick attack
                    Console.WriteLine("B = Quick attack");

                    string input = Console.ReadLine(); //tar svaret från användaren och stoppar in den i strigen input
                    acc = generator.Next(0, 100); //skapar ett random tal från 0 till 100 i int acc och detsamma fast för int acc2
                    acc2 = generator.Next(0, 100);

                    if (input.ToLower() == "a" && acc > 40 && acc < 100) //if sats som säger att ifall input är lika med stort eller litet "a" sammt ifall int acc är mellan 40 - 100 så ska player A göra skada på player B mellan talen 30 och 45 samt så tar den bort livet från player B
                    {
                        damage = generator.Next(30, 45);
                        Console.WriteLine(playerA + " heavy slams " + playerB + " for " + damage + " damage");
                        hpb -= damage;
                        Console.WriteLine();
                        round++; //lägger till en runda efter varje runda
                    }

                    if (input.ToLower() == "a" && acc < 40) //if sats som säger ifall input är lika med stort eller litet "a" samt ifall int acc är under talet 40 så missar player A sin attack
                    {
                        Console.WriteLine("YOU MISS");
                        round++; //lägger till en runda efter varje runda
                    }
                    if (input.ToLower() == "a") // if sats som säger ifall input är lika med stort eller litet "a" så ska player B göra skada på player A från talen 15 - 30 samt så räknas player A liv
                    {
                        damage = generator.Next(15, 30);
                        Console.WriteLine(playerB + " slaps at " + playerA + " for " + damage + " damage");
                        hpa -= damage;
                        Console.WriteLine();
                    }


                    else if (input.ToLower() == "b" && acc2 > 20 && acc < 100) // else if sats som säger ifall input är lika med stort eller litet "b" samt ifall acc2 är över 20 och under 100 så ska player A skada player B för 5-20 skada
                    {

                        damage = generator.Next(5, 20);
                        Console.WriteLine(playerA + " drinks a redbull and quickly slap " + playerB + " for " + damage + " damage");
                        hpb -= damage;
                        round++; //lägger till en runda efter varje runda

                    }
                    if (input.ToLower() == "b" && acc2 < 20) // if sats för ifall acc2 hamnar under 20 så missar player A sin attack
                    {
                        Console.WriteLine("YOU MISS");
                        round++; //lägger till en runda efter varje runda
                    }
                    if (input.ToLower() == "b") //if sats som ifall input är lika med stort eller litet "b" så ska player B skada player A för 5-20 dmg
                    {
                        damage = generator.Next(5, 20);
                        Console.WriteLine(playerB + " slaps back at " + playerA + " for " + damage + " damage");
                        hpa -= damage;
                        Console.WriteLine();
                    }
                    //visar livet player A och B har kvar efter varje runda
                    Console.WriteLine(playerA + " has " + hpa + " health left");
                    Console.WriteLine(playerB + " has " + hpb + " health left");
                    Console.WriteLine("_________________________________________");

                    //health check som kollar ifall nån av Player A eller PlayerB har hammnat under 0 eller har 0 liv kvar. Samt så visar den vem som vann
                    if (hpa <= 0 && hpb > 0)
                    {
                        Console.WriteLine("YOU LOST");
                        break;
                    }
                    if (hpb <= 0 && hpa > 0)
                    {
                        Console.WriteLine("YOU WON");
                        break;
                    }
                    if (hpb <= 0 && hpa <= 0)
                    {
                        Console.WriteLine("DRAW");
                        break;
                    }

                }
                //Resterande kod är för att användaren ska bestämma sig ifall hen vill köra igen eller sluta spela
                Console.WriteLine("");
                Console.WriteLine("Would sire care for a rematch?");
                Console.WriteLine("Yes or No? or press whatever to replay");
                replay = Console.ReadLine();
                Thread.Sleep(1500);
                Console.Clear();
            }
            if (replay.ToLower() == "no")
            {
                Environment.Exit(0);
            }

            Console.ReadLine();
        }
    }
}
