using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31类的基本语法
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //类
            //语法：
            //[public] class 类名
            //{
            //      字段;//只是类中声明的一个变量,是类中的数据成员,用来在对象中存储信息
            //              实例字段:属于类或结构的单个对象
            //      属性;
            //      方法;
            //}
            //创建Person类的对象
            Person sunQuan;//自定义类
            Person suQuan = new Person
            {
                Name = "孙全",
                Age = -23,
                Gender = '男',
                //_gender = '春'
                //属性的作用就是保护字段,对字段的赋值和取值进行限定
                //字段在类当中必须是私有的
            };
            suQuan.CHLSS();
            Console.ReadKey();
        }
    }

}
