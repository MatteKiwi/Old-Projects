using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HangmanRepetition
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Exempel på förbättringar:
             * - Använd char istället för string.
             * - Bygg om metoderna så att man inte kan gissa på en bokstav man redan gissat på.
             * - Felsäkra metoderna. Utgå från att andra människor kommer att mata in nonsens som parametrar och 
             *   se till att koden inte krashar.
             * - Bygg en klass att spara ordet i. Klassen innehåller både det rätta ordet och hur långt spelaren kommit.
             * - Hämta ordlistan från en textfil eller en databas.
             * - Definitivt överkurs: Hitta ett sätt att hämta ett slumpat ord från en hemsida.
             */


            //HangmanGame();
            
        }

        static void HangmanGame()
        {
            // FÖRBEREDELSER
            string word = RandomWord();

            string[] visibleWord = GenerateUnderscores(word);

            List<string> erroneousGuesses = new List<string>();

            int maxErroneousGuesses = 7;

            // SPELET
            while (!IsComplete(visibleWord) && erroneousGuesses.Count < maxErroneousGuesses)
            {
                DrawHangedMan(erroneousGuesses.Count);
                PrettyPrint(visibleWord);

                string guess = GetGuess();

                if (IsIn(guess, word))
                {
                    visibleWord = ReplaceFilter(guess, word, visibleWord);

                }
                else
                {
                    erroneousGuesses.Add(guess);
                }
            }

            if (IsComplete(visibleWord))
            {
                DisplayWin();
            }
            else
            {
                DisplayLoss();
            }
        }

        static string[] GenerateUnderscores(string word)
        {
            // Skapa en array med lika många _ som det finns bokstäver/tecken i word
            string[] UnderScore = new string[word.Length];

            for (int i = 0; i < word.Length; i++)
            {
                UnderScore[i] = "_";
            }
                
            return UnderScore;
        }

        static string RandomWord()
        {
            // Slumpa ett ord från en lista, bara små bokstäver
            List<string> randomWord = new List<string> {"Random", "Ballon", "Car" };

            Random Gen = new Random();

            int index = Gen.Next(randomWord.Count);

            string randomword = randomWord[index];          

            return randomword.ToLower();
        }

        static string PrettyPrint(string[] visibleWord)
        {
            // Returnera en snygg string som genererats utifrån visibleWord.
            // T.ex. om visibleWord är ["a", "p", "a"] så kan man returnera "a p a".

            string[] names = visibleWord;

            string PrettyPrint = string.Join(" ", names);

            return PrettyPrint;
        }

        static bool IsComplete(string[] visibleWord)
        {
            // Returnera true ifall alla _ har bytts ut mot tecken, annars false

            if (visibleWord.Contains("_"))
            {
                return false;
            }
            else
            {
                return true;
            }
                      
        }

        static string GetGuess()
        {
            // Returnera en 1 bokstavs gissning. Returnera alltid en liten bokstav (a istället för A t.ex.)
            Console.WriteLine("Skriv in en gissning");

            string guess = Console.ReadLine();

            return guess.ToLower();
        }

        static bool IsIn(string s, string word)
        {
            // Returnera true om s finns i word, annars false.
            if (word.Contains(s))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        static string[] ReplaceFilter(string s, string word, string[] visibleWord)
        {
            // Skapa och returnera en kopia av visibleWord där alla positioner där 
            // s finns i word bytts ut mot s.
            // T.ex. om s är "m", word är ["m", "a", "m", "m", "a"] och visibleWord är
            // ["_", "_", "_", "_", "_"] så ska metoden returnera ["m", "_", "m", "m", "_"]



            return visibleWord;
        }

        static string DrawHangedMan(int step)
        {
            // Print the hanged man's current status, where step = 0 equals nothing being shown,
            // step = 1 equals the hill being drawn, etc.

            return "";
        }

        static void DisplayWin()
        {
            // Visa någon form av vinst-meddelande
            Console.WriteLine("Gongratz! u WON");
        }

        static void DisplayLoss()
        {
            // Visa någon form av förlust-meddelande
            Console.WriteLine("Nah fam u suck");
        }

    }
}
