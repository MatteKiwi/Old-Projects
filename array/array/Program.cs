using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] testu = { "what", "is", "dis", "hello" };
            int i = 0;

            while (i < testu.Length)
            {
                Console.WriteLine(testu[i]);
                i++;
            }
            Console.ReadLine();


        }

    }
}
