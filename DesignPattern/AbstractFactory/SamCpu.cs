using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMain
{
    class SamCpu : Cpu
    {
        public override void Run()
        {
            Console.WriteLine("삼성 CPU");
        }
    }
}
