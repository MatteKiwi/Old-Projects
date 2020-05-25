using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colortest
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            // this is from internet, copy paste ;)



            Console.WriteLine("rainbow");

            Type type = typeof(ConsoleColor);
            Console.ForegroundColor = ConsoleColor.White;
            foreach (var name in Enum.GetNames(type))
            {
                Console.BackgroundColor = (ConsoleColor)Enum.Parse(type, name);
                Console.WriteLine(name);
            }
            Console.BackgroundColor = ConsoleColor.Black; 
            foreach (var name in Enum.GetNames(type))
            {
                Console.ForegroundColor = (ConsoleColor)Enum.Parse(type, name);
                Console.WriteLine(name);
            }


            Console.ReadLine();





        }
    }
}