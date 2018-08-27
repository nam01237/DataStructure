using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMain
{
    class Dragon
    {
        public IBreather Breather { set; private get; } 
        public IMoveable Moveable { set; private get; }

        public Dragon() { }

        public Dragon(IBreather breather, IMoveable moveable )
        {
            Breather = breather;
            Moveable = moveable;
        }

        public void Breath()
        {
            Breather.Breath();
        }

        public void Move()
        {
            Moveable.Move();
        }
    }

}
