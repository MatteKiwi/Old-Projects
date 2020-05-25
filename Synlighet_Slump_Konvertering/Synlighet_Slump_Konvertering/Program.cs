using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Synlighet_Slump_Konvertering
{
    class Program
    {
        static void Main(string[] args)
        {
          

          /*  Random gen = new Random();

            int i = 0;
            while (i < 10)
            {
                int k = gen.Next();
                Console.WriteLine(k);
                i++;
            }
            Console.WriteLine("---"); */

            string input = Console.ReadLine();
            int nummer;
            bool success = int.TryParse(input, out nummer);

            while (true)
            {

                if (success == true)
                {
                    Console.WriteLine(nummer * 2);
                    Console.WriteLine("Nice");
                    break;

                }
                if (nummer == 0)
                {

                    Console.WriteLine("this aint it chief");
                }

            }

            Console.WriteLine("okay");
            Console.ReadLine();
        }
    }
}
