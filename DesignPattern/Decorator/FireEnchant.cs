using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMain
{
    public class FireEnchant : SwordDecorator
    {
        public FireEnchant(Sword sword) : base(sword)
        {
        }

        public override string Attack()
        {
            return "화염계 " + sword.Attack();
        }
    }
}
