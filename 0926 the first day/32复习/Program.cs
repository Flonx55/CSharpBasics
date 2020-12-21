using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32复习
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();//创建对象,实例化
            p.Age = 10;
            p.Name = "张三";
            p.Gender = '男';
            p.SayHello();
            //当我们创建好一个类的对象后,我们需要给这个对象的每个属性去赋值
            //我们管这个过程称之为对象的初始化
            Person p2 = new Person();
            p2.Age = -12;
            p2.Name = "李四";
            p2.Gender = '春';
            p2.SayHello();
            Console.ReadKey();
        }
    }
}
