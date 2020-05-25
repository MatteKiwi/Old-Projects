using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sänkaskepp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("välkommen till skänka skepp");


            int num = 7;
            Console.WriteLine("VÄLKOMMEN TILL SÄNKA SKEPP!");
            int num1 = 0;
            while (num1 != num)
            {
                bool flag = false;
                while (!flag)
                {
                    Console.WriteLine("Skriv in en koordinat [1-10]: ");
                    flag = int.TryParse(Console.ReadLine(), out num1);
                    if (!flag)
                    {
                        Console.WriteLine("Not a number, try again!");
                    }
                    else if (num1 >= 1)
                    {
                        if (num1 <= 10)
                        {
                            continue;
                        }
                        Console.WriteLine("Guess must not be more than 10!");
                    }
                    else
                    {
                        Console.WriteLine("Guess must be at least 1!");
                        flag = false;
                    }
                }
                if (num1 == num)
                {
                    Console.WriteLine("Hit!");
                }
                else if (Math.Abs(num - num1) > 2)
                {
                    Console.WriteLine("Miss!");
                }
                else
                {
                    Console.WriteLine("Near miss!");
                }
            }
            Console.WriteLine("Press ENTER to exit");
            Console.ReadLine();

        }
    }
}
