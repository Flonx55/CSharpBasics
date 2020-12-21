using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _73访问修饰符
{
    class Program
    {
        static void Main(string[] args)
        {
            /*c#中的访问修饰符
            public :公开的
            private：私有的，只能在当前类的内部访问
            protected：受保护的，只能在当前类的内部以及该类的子类中访问
            internal:只能在当前程序集中访问（项目）,在同一个项目中，public internal的权限是一样的
            protected internal:protected+internal

            1)能够修饰类的访问修饰符只有两个，public internal父类的访问权限
            2）可访问性不一致：子类的访问权限不能高于父类的访问权限,否则子类会暴露父类的成员
            */
        }
    }
    internal class Person
    {

    }
    //public class Student:Person
    {

    }


}
