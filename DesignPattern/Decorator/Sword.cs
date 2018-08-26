using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMain
{
    public abstract class Sword
    {
        public int AttackPower { get; protected set; }

        public virtual string Attack()
        {
            return ($"공격 데미지 {AttackPower}");
        }
        
    }
}
