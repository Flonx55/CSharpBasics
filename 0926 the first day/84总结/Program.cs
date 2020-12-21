using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _84总结
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            什么时候用虚方法来实现多态?
            什么时候用抽象类来实现多态?
            什么时候用接口来实现多态?
            */

            //练习:真的鸭子会游泳 木头鸭子不会游泳 橡皮鸭子会游泳------侧重于能力
            ISwimming swim = new XPDuck();
            swim.Swim();
            Console.ReadKey();
        }
    }
    public class RealDuck:ISwimming
    {
        public void Swim()
        {
            Console.WriteLine("真的鸭子靠翅膀游泳");
        }

    }
    public class MuDuck
    {

    }
    public class XPDuck : ISwimming
    {
        public void Swim()
        {
            Console.WriteLine("橡皮鸭子漂着游泳");
        }
    }
    public interface ISwimming
    {
        void Swim();
    }
}
