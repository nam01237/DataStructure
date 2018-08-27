using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMain
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestFactoryMethod();
            //TestAbstractFactory();
            //TestDecorator();
            //TestStrategy();
        }

        static void TestStrategy()
        {
            Dragon infrnal = new InfernalDragon();
            Dragon snow = new SnowDragon();
            Dragon dragon = new Dragon();

            infrnal.Breath();
            infrnal.Move();
            snow.Breath();
            snow.Move();

            dragon.Breather = new FireBreath();
            dragon.Moveable = new MoveCrepp();

            dragon.Breath();
            dragon.Move();
        }

        static void TestDecorator()
        {
            Sword longSword = new LongSword();

            SwordDecorator iceDecorator = new IceInchant(longSword);
            SwordDecorator fireDecorator = new FireEnchant(longSword);

            Console.WriteLine( longSword.Attack() );
            Console.WriteLine( iceDecorator.Attack() );
            Console.WriteLine( fireDecorator.Attack() );
        }

        static void TestAbstractFactory()
        {
            SamFactory samFactory = new SamFactory();
            LGFactory lgFactory = new LGFactory();

            Cpu samCpu = samFactory.MakeCpu();
            Cpu lgCpu = lgFactory.MakeCpu();

            Frame samFrame = samFactory.MakeFrame();
            Frame lgFrame = lgFactory.MakeFrame();

            samCpu.Run();
            samFrame.Run();

            lgCpu.Run();
            lgFrame.Run();
        }

        static void TestFactoryMethod()
        {
            Barracks barracks = new Barracks();
            Gateway gateway = new Gateway();

            Unit marine = barracks.MakeUnit();
            Unit zealot = gateway.MakeUnit();

            Console.WriteLine($"질럿 체력 : {zealot.Hp}");
            Console.WriteLine($"마린 공격력 : {marine.AttackPower}");
            marine.Attak(zealot);
            Console.WriteLine($"질럿 체력 : {zealot.Hp}");
            Console.WriteLine($"마린 공격력 : {marine.AttackPower}");

        }
    }
}
