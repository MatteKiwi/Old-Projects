using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metoder
{
    class Program
    {
        
        static void Main(string[] args)
        {
            SayHello();

            int r = GimmeNumber();

            Describe(1);

            Console.ReadLine();
        }

        static void SayHello ()
        {
            Console.WriteLine("Hello");
        }

        static void Describe(int roomNumber)
        {
            string[] rooms = { "Boiler room is hot", "Cellar is dark", "Attic is filled with cobwebs" };

            Console.WriteLine(rooms[roomNumber]);

        }

        static int GimmeNumber()
        {
            bool success = false;
            int result = 0;

            while (success == false)
            {
                Console.WriteLine("Type number boi");
                string input = Console.ReadLine();
                success = int.TryParse(input, out result);
            }

            return result;
        }
    }
}
