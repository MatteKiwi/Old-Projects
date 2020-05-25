using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frågesport
{
    class Program
    {
        static void Main(string[] args)
        {
            int correctAnswers;

            Start:

            Console.WriteLine("Vad är 2 + 2? ");
            Console.WriteLine("A = 4");
            Console.WriteLine("B = 3");

            ConsoleKeyInfo info = Console.ReadKey();
            if (info.Key == ConsoleKey.A)
            {
                Console.WriteLine("Rätt!");
                correctAnswers++;
            }

            ConsoleKeyInfo info2 = Console.ReadKey();
            if (info.Key == ConsoleKey.B)
            {
                Console.WriteLine();
                Console.WriteLine("Fel!");
            }
            goto Start;

            Console.WriteLine("Resultat, {0}", Resultat);

            Console.ReadLine();









        }
    }
}
