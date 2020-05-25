using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yoooooooo
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("hej");

                if (Console.ReadKey(true).Key != ConsoleKey.Escape)


                {
                    break;
                }
            }
        }
    }
}
