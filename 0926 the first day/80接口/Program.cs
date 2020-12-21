using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _80接口
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            多继承的时候,考虑类

            接口就是一个规范,能力.

            接口
            [public] interface I..able
            {
              成员
            }
            */
        }
    }
    public class Person
    {
        public void CHLSS()
        {
            Console.WriteLine("我是人类,我可以吃喝拉撒睡");
        }
    }
    public class NBAPlayer
    {
        public void KouLan()
        {
            Console.WriteLine("我可以扣篮");
        }
    }
    public class Student : Person, IKouLanable //继承 单根性
    {
        public void KouLan()
        {
            Console.WriteLine("我也可以扣篮");
        }
    }

    public interface IKouLanable
    {
        void KouLan();
    }

    public interface IFlyable
    {
        //接口中的成员不允许添加访问修饰符,默认就是public
        void Fly();
        string Test();

        //不允许写具有方法体的函数
        //string _name;//接口不能写字段
        string Name
        {
            get;
            set;
        }//自动属性
        
    }
}
