using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            Tamagotchi tamagotchi = new Tamagotchi();

            bool nameCheck = false;

            Console.WriteLine("Hello! Please name your Tamagotchi!");
            while (nameCheck == false)
            {
                
                tamagotchi.name = Console.ReadLine();

                if (tamagotchi.name.Length > 2 && tamagotchi.name.Length < 8 && tamagotchi.name.All(char.IsDigit) == false)
                {
                    nameCheck = true;
                }
                else
                {
                    Console.WriteLine("Try Again!");
                }


            }
            Console.WriteLine("Ok! " + tamagotchi.name + " it is! What a lovely name!");


                     

            Console.WriteLine("Teach new word? YES");
            tamagotchi.Teach(Console.ReadLine());
            tamagotchi.PrintStats();

            Console.ReadLine();
        }
    }
}
