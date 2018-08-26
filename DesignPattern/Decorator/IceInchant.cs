using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMain
{
    class IceInchant : SwordDecorator
    {
        public IceInchant(Sword sword) : base(sword)
        {
        }

        public override string Attack()
        {
            return "얼음계 " + sword.Attack();
        }
    }
}
