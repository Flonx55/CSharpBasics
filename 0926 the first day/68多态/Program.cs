using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _68多态
{
    class Program
    {
        static void Main(string[] args)
        {
            //概念:让一个对象能够表现出多种的状态(类型)
            //实现多态的3种手段:虚方法 抽象类 接口

            //实现多态的手段:虚方法
            //步骤
            //1\将父类的方法标记为虚方法,使用关键字virtual
            //  这个函数可以被子类重新写一遍
            Chinese cn1 = new Chinese("韩梅梅");
            Chinese cn2 = new Chinese("李雷");
            Janpanese j1 = new Janpanese("树下君");
            Janpanese j2 = new Janpanese("井边子");
            Korea k1 = new Korea("金秀贤");
            Korea k2 = new Korea("金贤秀");
            American a1 = new American("科比布莱恩特");
            American a2 = new American("奥尼尔");
            Person[] pers = { cn1, j1, j2, k1, k2, a1, a2 };

            for (int i = 0; i < pers.Length ; i++)
            {
                //if (pers[i] is Chinese )
                //{
                //    ((Chinese)pers[i]).SayHello();
                //}
                //else if (pers[i] is Janpanese )
                //{
                //    ((Janpanese)pers[i]).SayHello();
                //}
                //else if (pers[i] is Korea )
                //{
                //    ((Korea)pers[i]).SayHello();
                //}
                //else
                //{
                //    ((American)pers[i]).SayHello();
                //}

                pers[i].SayHello();
            }
            Console.ReadKey();
        }
    }
    public class Person
    {
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public Person(string name)
        {
            this.Name = name;
        }
        public virtual void SayHello()
        {
            Console.WriteLine("我是人类");
        }

    }

    public class Chinese : Person
    {
        public Chinese(string name) : base(name)
        {

        }

        public override  void SayHello()
        {
            Console.WriteLine("我是中国人,我叫{0}",this.Name);
        }



    }

    public class Janpanese:Person
    {
        public Janpanese (string name):base(name)
        {

        }
        public override  void SayHello()
        {
            Console.WriteLine("我是脚盆国人,我叫{0}",this.Name);
        }
    }

    public class Korea : Person
    {
        public Korea(string name):base(name)
        {

        }
        public override  void SayHello()
        {
            Console.WriteLine("我是棒之思密达,我叫{0}",this.Name);
        }

    }

    public class American : Person
    {
        public American (string name):base(name)
        {

        }
        public override  void SayHello()
        {
            Console.WriteLine("我叫{0},我是米国人",this.Name);
        }
    }




}
