using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMain
{
    class SnowDragon : Dragon
    {
        public SnowDragon() : base(new IceBreath(), new MoveCrepp())
        {

        }
    }
}
