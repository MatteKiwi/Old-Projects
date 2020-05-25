using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace store_and_return_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[3];
            int n;

            Console.WriteLine("Enter the number of elements to be stored:");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the values");

            for (int i = 0; i < n; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("The numbers stored are: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}", array[i]);
            }

            Console.WriteLine("The numbers in reveresed order are: ");
            for (int x = n-1; x >= 0; x--)
            {
                Console.WriteLine("{0}", array[x]);
            }


            Console.ReadLine();
        }

    }
}
