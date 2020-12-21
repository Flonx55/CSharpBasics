using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11构造函数
{
    class Program
    {
        static void Main(string[] args)
        {
            BankCard card1 = new BankCard();
            BankCard card2 = new BankCard("112");
            Math ma = new Math();
            Student stu = new Student(1112,12);
            stu.StudentMessage();
            Console.ReadKey();

            /*
                调用构造函数
                    当定义类对象时,构造函数会自动执行
                1)调用默认构造函数
                    不带参数的构造函数成为默认构造函数.无论何时,只要使用new运算符实例化对象,并且不为new提供任何参数
                    就会调用默认构造函数.假设一个类包含有默认构造函数,调用默认构造函数的语法如下
                        类名 对象名 = new 类名();
                    如果没有为对象提供构造函数,则默认情况下c#将创建一个构造函数,该构造函数实例化对象,并将所有成员变量
                    设置为相应的默认值 
                2)调用带参数的构造函数
                    假设一个类中包含带参数的构造函数,调用这种带参数的构造函数的语法如下
                        类名 对象名 = new 类名(参数表)



            类的构造函数可通过初始值设定项目来调用基类的构造函数
            public Student(string no,string name,char sex ,int age):base(name,sex,age)
            {...}
            类的构造函数也可通过关键字this调用同一个类的另一个构造函数
            public Point():this(0,20)
            {...}

            //   this:1)当前类的对象
         //        2)在类当中显示的调用本类的构造函数:this
            */
            
        }
    }
}
