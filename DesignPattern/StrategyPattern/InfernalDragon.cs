using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMain
{
    class InfernalDragon : Dragon
    {
        public InfernalDragon() : base(new FireBreath(), new MoveFly())
        {

        }
    }
}
