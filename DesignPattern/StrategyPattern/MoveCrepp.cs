using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMain
{
    class MoveCrepp : IMoveable
    {
        public void Move()
        {
            Console.WriteLine("기어서 움직임");
        }
    }
}
