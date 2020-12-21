using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54var推断类型
{
    class Program
    {
        static void Main(string[] args)
        {
            //var:能够值能够推断出来类型 在声明var变量的同时必须给他赋初值 
            //c#是一门强类型语言 在代码中,必须对每一个变量的类型有一个明确的定义
            //js是一门弱类型语言 
            //12 2.14 true 'c' "agalf" var
            int n = 15;
            string  n2 = "张三";
            double n3 = 3.14;
            decimal n4 = 5000m;
            bool n5 = true;
            char n6 = '男';
            Console.WriteLine(n.GetType ());
            Console.WriteLine(n2.GetType ());
            Console.WriteLine(n3.GetType());
            Console.WriteLine(n4.GetType ());
            Console.WriteLine(n5.GetType ());
            Console.WriteLine(n6.GetType ());
            Console.ReadKey();
        }
    }
}
