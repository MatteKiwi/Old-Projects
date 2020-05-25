using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            Enemy e1 = new Enemy();
            Enemy e2 = new Enemy();

            e1.name = "yo";
            e2.name = "ho";

            e1.nemesis = e2;
            e2.nemesis = e1;

            Console.WriteLine(e1.nemesis.name);

            Console.WriteLine(Enemy.numberOf);

            string[] namn = { "Mathias", "Fille", "Olle", "Lukas" };

            Utils.PrintArray(namn);

            //Program p = new Program();

            Hello();

            Console.ReadLine();
        }

        public static void Hello()
        {
            Console.WriteLine("Hello");
        }
    }
}
