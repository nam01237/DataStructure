using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMain
{
    class LongSword : Sword
    {
        public LongSword()
        {
            AttackPower = 11;
        }

        public override string Attack()
        {
            return "롱소드 " + base.Attack();
        }
    }
}
