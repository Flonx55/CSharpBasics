using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _75值类型和引用类型_
{
    class Program
    {
        static void Main(string[] args)
        {
            //值类型:int char double decimal bool enum struct 栈
            //引用类型:string 数组 自定义类 集合 object 接口 堆

            //值类型在复制的时候，传递的是这个值的本身
            //引用类型在复制的时候,传递的是对这个对象的引用
            //栈中的地址不一样,堆中的地址一样
            //值传递和引用传递


            //字符串的不可变性:改变一个,另一个不会受影响,会重新开辟空间

            //int n1 = 10;
            //int n2 = n1;
            //n2 = 20;
            //Console.WriteLine(n1);
            //Console.WriteLine(n2);
            //Console.ReadKey();

            Person p1 = new Person();
            p1.Name = "张三";
            Person p2 = p1;
            p2.Name = "李四";

            Console.WriteLine(p1.Name);
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
    }
}
