using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace The_Big_Score
{
    class Program
    {
        static void Main(string[] args)
        {
            

            //string array med poängen samt namnen
            string[] highScores = { "100 Vincent", "50 Oliver", "0 Eric" };
            

            int option = 0;

            while (option != 6)
            {
                option = 0;
                //input är like med metoden interface
                string input = InterFace();


                if (input == "1")
                {
                    option = 1;
                    PrintHighScores(highScores);
                    option = 0;
                    Console.ReadLine();
                }


                if (input == "2")
                {
                    string[] names = GetNames(highScores);
                    option = 2;
                    for (int i = 0; i < names.Length; i++)
                    {
                        Console.WriteLine(names[i]);
                    }
                    option = 0;
                    Console.ReadKey();

                }


                if (input == "3")
                {
                    option = 3;
                    Console.WriteLine("not yet");
                    option = 0;
                    Console.ReadLine();
                }
                if (input == "4")
                {
                    option = 4;
                    int average = GetAverge(highScores);
                    Console.WriteLine(average);
                    option = 0;
                    Console.ReadLine();
                }
                if (input == "5")
                {
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Ange en siffra mellan 1-5");
                }
                Console.Clear();

            }


        }

        //metod som skriver ut alla highscores snyggt
        static void PrintHighScores(string[] highScores)
        {
            Console.WriteLine("HIGH SCORES");

            for (int i = 0; i < highScores.Length; i++)
            {
                Console.WriteLine(i + 1 + ") " + highScores[i]);
            }
        }
        //gui av det hela, där man får sina val om vad man vill göra
        static string InterFace()
        {
            Console.WriteLine("Välj ett alternativ");
            Console.WriteLine("1. Visa high scores.");
            Console.WriteLine("2. Visa unika namn");
            Console.WriteLine("3. Visa en användares bästa poäng.");
            Console.WriteLine("4. Visa medelpoäng.");
            Console.WriteLine("5. Exit");
            Console.WriteLine("Skriv en siffra och tryck ENTER:");
            string input = Console.ReadLine();
            return input;
        }
        //metod som använder sig av regex för att ta bort siffrona från arrayen highscores och sedan retunerar den då med bara namnen
        static string[] GetNames(string[] highScore)
        {
            string[] names = highScore;

            for (int i = 0; i < names.Length; i++)
            {
                highScore[i] = Regex.Replace(names[i], @"(\s-|[^A-Za-z])", "");

            }
            return names;
        }
        // metod som använder sig av regex för att splitta bort alla bokstäver från arryen names, sedan konverteras names och delas på längden av highscore
        static int GetAverge(string[] highScores)
        {
            string name = (highScores[0] + highScores[1] + highScores[2]);

            string[] names = Regex.Split(name, @"\D+");

            int[] numbers;
            numbers = new int[names.Length];

            numbers[0] = Int32.Parse(names[0]);
            numbers[1] = Int32.Parse(names[1]);
            numbers[2] = Int32.Parse(names[2]);
            int i = numbers[0] + numbers[1] + numbers[2];

            int average = i / highScores.Length;

            return average;
        }

    }
}
