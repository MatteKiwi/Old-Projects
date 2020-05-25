using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace debugg
{
    class Program
    {
        static void Main(string[] args)
        {
            int hp = 100;

            hp++;
            hp += GimmeFive();

            Console.WriteLine(hp);

            Console.ReadLine();

        }

        static int GimmeFive ()
        {
            int t = 10;
            t -= 5;
            return t;
        }
    }
}
