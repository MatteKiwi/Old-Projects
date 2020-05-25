using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reference_value
{
    class Program
    {
        static void Main(string[] args)
        {

            int u = 6;

            u = DoValue(u);

            Console.WriteLine(u);

            int[] grejer = { 3, 4, 5 };

            DoReference(grejer);

            Console.WriteLine(grejer[0]);


            Console.ReadLine();


        }

        static void DoReference(int[] arr)
        {
            arr[0] = 11;
        }

        static int DoValue(int h)
        {
            h++;

            return h;
        }
    }
}
