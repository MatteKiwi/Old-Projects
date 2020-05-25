using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class Utils
    {
        public static void PrintArray(string[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine((i+1 + "." + a[i]));
            }
        }
    }
}
