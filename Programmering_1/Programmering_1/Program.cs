using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What's your name? ");

            string name = Console.ReadLine();

          
            Console.WriteLine("Hello, " + name + "!" );
          

            Console.ReadLine();

            Console.Write("How old are you? ");

            string age = Console.ReadLine();

            Console.WriteLine(name  + " is " +  age + " years old" );

            Console.ReadLine();

            
          
        }
    }
}
