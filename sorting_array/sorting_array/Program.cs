using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sorting_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            int t;
    
            Console.WriteLine("Enter 10 numbers:");

            for (int i = 0; i < 10; i++)
            {
                int number = Convert.ToInt32(Console.ReadLine());
     
                array[i] = number;
             
            }

            Console.WriteLine("\nUnsorted array:");
            foreach (int aa in array)
                Console.Write(aa + " ");
            for (int p = 0; p <= array.Length - 2; p++)
            {
                for (int i = 0; i <= array.Length -2; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        t = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = t;
                    }
                }
            }

            Console.WriteLine("\n" + "Sorted array: ");
            foreach (int aa in array)
                Console.Write(aa + " ");
            Console.Write("\n");


            Console.ReadLine();
        }
    }
}
