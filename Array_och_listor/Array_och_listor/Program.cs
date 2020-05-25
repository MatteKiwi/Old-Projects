using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_och_listor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[] enemyHitpoints = {50,75,100,150,55};

            //enemyHitpoints[1] = 50000;

            Console.WriteLine(enemyHitpoints[1]);

            string[] choice = { "Start", "Options", "Quit" };
            int i = 0;

            while (i < choice.Length)
            {
                Console.WriteLine(choice[i]);
                i++;
            }

            string[] names = { "Oliver", "Eric", "Robin" };

            Random gen = new Random();

            int m = gen.Next(names.Length);

            string name = names[m]; */

            int[] heltal = { 1, 2, 3, 4, 5, 6, 7};
            int x = 0;

            while (x < heltal.Length)
            {
                Console.WriteLine(heltal[x] + 3);
                x++;        
            }

            string[] array = new string[5];
            int f = 0;

            while (f < array.Length)
            {
                Console.WriteLine("Skriv");
                string input = Console.ReadLine();
                array[f] = input;
                f++;
            }
            Console.WriteLine(string.Join(", ", array));
            /*int n = 0;
            while (n < array.Length)
            {
                Console.WriteLine(array[n]);
                n++;
            } */

            Console.ReadLine();
        }
    }
}
