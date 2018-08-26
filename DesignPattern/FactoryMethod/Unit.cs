using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMain
{
    public abstract class Unit
    {
        public string Name { get; protected set; }
        public int Hp { get; protected set; }
        public int AttackPower { get; protected set; }

        public virtual void Attak(Unit target)
        {
            Console.WriteLine($"{Name}(이)가 {target.Name}을 공격");
            target.Damaged(AttackPower);
        }

        public virtual void Damaged(int damage)
        {
            Hp -= damage;
        }
    }
}
