using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44继承练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //记者:我是记者 我的爱好是偷拍 我的年龄是34 我是一个男狗仔
            //司机:我叫舒马赫 我的年龄是43 我是男人 我的驾龄是23年
            //程序员:我叫孙全 我的年龄是23 我是男生 我的工作年限是3年
            Driver a = new Driver("张三",43,'男',23);
            a.DriverSayHello();
            Programmer b = new Programmer("李四",43,'男',3);
            b.ProgrammerSayhello();
            Repoter c = new Repoter("狗仔","偷拍",34,'女');
            c.ReporterSayhello();
            Console.ReadKey();
            //new关键字
            //1)创建对象
            //2)隐藏从父类那里继承过来的同名成员
            //隐藏的后果就是子类调用不到父类的成员
        }
    }
}
