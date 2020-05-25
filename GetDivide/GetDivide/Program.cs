using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetDivide
{
    class Program
    {
        static void Main(string[] args)
        {
           

            Console.WriteLine("Enter a number");
            string input = Console.ReadLine();
            while (true)
            {
                if (int.TryParse(input, out int max))
                {
                    break;
                }
                else if(!int.TryParse(input, out max))
                {
                    Console.WriteLine("try agane");

                    Console.ReadLine();
                }


                Console.ReadLine();
            }


            

        }

        static int GetDivide(int max)
        {

            int[] divide = new int[max];

            divide[0] = max;

            for (int i = 0; i < .Length; i++)
            {

            }


            return 
        }
    }
}
