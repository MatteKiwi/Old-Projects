using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enemyClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy e1 = new Enemy();
            Enemy e2 = new Enemy();

            Console.WriteLine(e1.hp);
            Console.WriteLine(e2.hp);
            e1.Hurt(10);
            Console.WriteLine(e1.hp);
            Console.WriteLine(e2.hp);


        }
    }
}
