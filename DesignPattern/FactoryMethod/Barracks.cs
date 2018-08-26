using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMain
{
    public class Barracks : Building
    {
        public override Unit MakeUnit()
        {
            return new Marine();
        }
    }
}
