using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMain
{
    public abstract class SwordDecorator : Sword
    {
        protected Sword sword;

        public SwordDecorator( Sword sword )
        {
            this.sword = sword;
        }

        public override abstract string Attack();

    }
}
