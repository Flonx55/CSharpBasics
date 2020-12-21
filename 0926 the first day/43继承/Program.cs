using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43继承
{
    class Program
    {
        static void Main(string[] args)
        {
            //把这几个类当中重要的成员单独的拿出来封装成一个类，作为这几个类的父类
            //Student s = new Student();
            //我们可能会在一些类中写一些重复的成员，我们可以将这些重复的成员，单独的封装在一个类中，作为
            //这些类的父亲
            //Student,teacher,子类 派生类
            //Person          父类 基类
            //子类继承了父类,子类从父类那里继承过来了什么?
            //子类继承了父类的属性和方法,但是没有继承父类的私有字段
            //子类有没有继承父类的构造函数
            //子类并没有继承父类的构造函数，但是，子类会默认的调用父类无参数的构造函数，创建父类对象，让子类可以使用父类中的
            //成员.所以,如果在父类中重新写了一个有参数的构造函数之后,那个无参数的就被干掉了,子类就调不到了,所以子类会报错
            //解决办法
            //1)在父类中重新写一个无参数的构造函数
            //2)在子类中显示的调用父类的构造函数,使用关键字:base()
            Student s = new Student("学生",18,'男',101);
            
            
            //object 是所有类的基类.



            //继承的特性:
            //单根性:一个子类只能有一个父亲
            //传递性:




        }
    }
    //public class Student//只适用于教学，不利于开发
    //{

    //}
}
