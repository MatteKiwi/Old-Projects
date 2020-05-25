using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual_Overdrive
{
    class Program
    {
        static void Main(string[] args)
        {
            Character ae1 = new AnoyEnemy();

            ae1.Hurt(9);

            Console.WriteLine();


            Console.ReadLine();
        }
    }
}
