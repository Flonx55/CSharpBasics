using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _82接口特点
{
    class Program
    {
        static void Main(string[] args)
        {
            //IFlyable fly = new IFlyable();
            //为什么不能被实例化？
            //哪些不能被实例化：抽象类 接口 静态类
            //接口当中的成员没有实现，调用对象没意义

            IFlyable fly = new Bird ();
            fly.Fly();
            Console.ReadKey();

            
        }
    }
    public class Person:IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("人类在飞");
        }
    }

    public class Bird:IFlyable
    {
        public void Fly()
        {
            Console.WriteLine ("鸟在飞");
        }
    }

    public interface IFlyable
    {
        //不允许有访问修饰符 默认为public
        //方法、属性、索引器、后两个本质上就是方法 注意：是自动属性，没有方法体
        void Fly();
    }

    public class Student: Person,IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("人类在飞");
        }
    }
    public interface M1:SupperInterface 

    {
        void Test();
    }
    public interface M2
    {
        void Test2();
    }
    public interface M3
    {
        void Test3();
    }
    public interface SupperInterface:M2,M3
    {

    }
}
