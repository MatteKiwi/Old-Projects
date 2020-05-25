using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seperata_filer
{
    class Utils
    {
       public static int GetInt()
        {
            int num = 0;

            string text = ""; 

            while (!int.TryParse(text, out num))
            {
                text = Console.ReadLine();
            }

            return num;

        }


    }
}
