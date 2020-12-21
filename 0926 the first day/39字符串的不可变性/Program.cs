using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39字符串的不可变性
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "张三";
            //name = "孙全";
            //Console.WriteLine(name);
            //Console.ReadKey();
            //字符串的不可变性
            //当你给一个字符串重新赋值之后,老值并没有销毁而是重新开辟一块空间存储新值
            //当程序结束后,GC扫描整个内存,如果发现有的空间没有被指向,则立即销毁


            //我们可以将字符串看作是char类型的一个只读数组

            //string s1 = "zhangsan";
            //string s2 = "zhangsan ";


            //可以将string类型看作是char类型的只读数组
            string s = "abcdefg";
            //s[0] = 'b';//不能这样做,因为是只读的
            //首先将字符串转化为char类型的数组
            char[] chs = s.ToCharArray();
            chs[0] = 'b';
            //将字符数组转化成我们的字符串
            s = new string(chs);


            //ToCharArray();将字符串转换为char数组
            //new string (char[] chs):能够将char数组转换为字符串


            //既然可以将string看作char类型的只读数组,所以我可以通过下标去访问字符串中的某一个元素
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}
