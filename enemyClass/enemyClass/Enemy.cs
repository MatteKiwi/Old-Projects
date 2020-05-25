using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enemyClass
{
    class Enemy
    {
        public int hp = 10;

        public void Hurt(int amount)
        {
            hp -= amount;
        }

    }
}
