using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33静态和非静态的区别
{
    public class Person
    {
        public static string _name;
        private char _gender;

        public void M1()
        {
            Console.WriteLine("我是非静态方法");
           
        }
        public static void M2()
        {
            Console.WriteLine("我是静态方法");
            
        }
        //静态字段属于类而不属于某个类的实例
        //静态和非静态的区别
        
        //1,在非静态类中,既可以有实例成员,也可以有静态成员
        //2,在调用实例成员的时候,需要使用对象名.实例成员();
        //3,在调用静态成员的时候,需要使用类名.静态成员名();
        //总结:静态成员必须使用类名去调用,而实例成员必须使用对象名调用
        //    静态函数中,只能访问静态成员,不允许访问实例成员
        //    实例函数中,既可以使用静态成员,也可以使用实例成员
        //    静态类中只允许有静态成员,不允许出现实例成员

        //使用:
        //1,如果你想要你的类当作一个"工具类"去使用,这个时候可以考虑将类写成静态类
        //2,静态类在整个项目中资源共享,(类不占内存,对象要占),
        //只有在程序全部结束后,静态类才会释放资源

        //堆 栈,静态存储区域
        //释放资源:垃圾空间全部清掉,GC,Garbage Collection

    }
}
