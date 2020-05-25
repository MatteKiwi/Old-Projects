using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneriskaKlasser2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Container<int> c = new Container<int>();
            Container<string> c2 = new Container<string>();       
            c.contents = 8;
            c2.contents = "yo"; */

            Container<int> start = new Container<int>();
            start.next = new Container<int>();
            start.next.next = new Container<int>();
            start.next.next.next = new Container<int>();

            start.next.next.next = start;

            Space<int> s = new Space<int>();

           /* Container<int> current = start;

            for (int i = 0; i < 64; i++)
            {
                current.next = new Container<int>();
                current = current.next;
            } */
    
        }
    }
}
