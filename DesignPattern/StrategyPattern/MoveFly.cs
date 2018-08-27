using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMain
{
    class MoveFly : IMoveable
    {
        public void Move()
        {
            Console.WriteLine("날아서 움직임");
        }
    }
}
