using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    class Enemy
    {
        public Enemy nemesis;

        public string name;
        public static int numberOf = 0;

        private static Random gen = new Random();

        public Enemy()
        {
            numberOf++;
        }

        public int Attack()
        {
            return gen.Next(2,10);
        }
            

    }
}
