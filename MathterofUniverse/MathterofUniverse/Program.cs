using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathterofUniverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 7;
            int m;
            
            
            Console.WriteLine("x * 6 = 42");



            while (true)
            {
                string input = Console.ReadLine();

                bool succ = int.TryParse(input, out x);
                bool succ2 = int.TryParse(input, out m);

                if (succ)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Enter a number");
                }

            }

        
            x *= 6;

            if (x == 7)
            {
                Console.WriteLine("Correct u got 1 point");
            }
            else if (x != 7)
            {
                Console.WriteLine("You got " + m + " * 6 = " + x + ". Which is incorrect ");
                Console.WriteLine("The correct answer was 7");
            }
              
             Console.ReadLine();
                       
        }
    }
}
