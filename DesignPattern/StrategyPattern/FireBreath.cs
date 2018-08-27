using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMain
{
    class FireBreath : IBreather
    {
        public void Breath()
        {
            Console.WriteLine("화염 브레스");
        }
    }
}
