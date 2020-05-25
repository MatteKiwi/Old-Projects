using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visual_Overdrive
{
    class AnoyEnemy : Character
    {
        public override void Hurt(int amount)
        {
            if (amount % 3 == 0)
            {
                base.Hurt(-amount);
            }
            else
            {
                base.Hurt(amount);
            }
        }
    }
}
