using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual_Overdrive
{
    class Character
    {
        protected int hp = 100;

        public virtual void Hurt(int amount)
        {
            hp -= amount;

            if (hp < 0)
            {
                hp = 0;
            }
        }

    }
}
