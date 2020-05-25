using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Filhantering
{
    class Program
    {
        static void Main(string[] args)
        {
            File.WriteAllText("names.txt", "Herbert");

            if(File.Exists("monsternames.txt"))
            {
                string[] monsternames = File.ReadAllLines("monsternames.txt");
                Console.WriteLine(monsternames[0].Split(';')[1]);
            }

            File
           
            Console.ReadLine();

        }
    }
}
