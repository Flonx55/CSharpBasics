using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 类型转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用convert进行转换，成功了就成了，失败了就异常
            //int number1 = Convert.ToInt32("123abc");

            int number = int.Parse("123");
            Console.WriteLine(number);
            Console.ReadKey();
            
        }
    }
}
