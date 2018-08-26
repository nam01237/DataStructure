using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMain
{
    class SamFactory : CellPhonePartsFactory
    {
        public override Cpu MakeCpu()
        {
            return new SamCpu();
        }

        public override Frame MakeFrame()
        {
            return new SamFrame();
        }
    }
}
