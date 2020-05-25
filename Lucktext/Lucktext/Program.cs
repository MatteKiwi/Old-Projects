using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucktext
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Green;
               

            Console.Write("Write an adjective ");

            string adjective = Console.ReadLine();


            Console.Write("Write an Adverb ");

            string Adverb = Console.ReadLine();

            Console.Write("Write a noun, ");

            string noun = Console.ReadLine();

            Console.Write("Write a second noun ");

            string noun_2 = Console.ReadLine();

            Console.Write("Dont forget the third noun ");

            string noun_3 = Console.ReadLine();
          

            Console.WriteLine("Driving a car can be fun if you follow this " + adjective + " advice: When approaching " + noun + " on the right, always blow your " + noun_2 + " and always stick your " + noun_3 + " out of the window. Above all, drive " + Adverb + ", the end. ");

            
            Console.ReadLine(); 

            
        }
    }
}
