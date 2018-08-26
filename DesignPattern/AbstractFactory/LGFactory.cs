using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMain
{
    class LGFactory : CellPhonePartsFactory
    {
        public override Cpu MakeCpu()
        {
            return new LGCpu();
        }

        public override Frame MakeFrame()
        {
            return new LGFrame();
        }
    }
}
