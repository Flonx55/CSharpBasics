using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 程序调试
{
    class Program
    {
        static void Main(string[] args)
        {
            //写完一段程序后，想看一下这个程序的执行过程
            //当你写完这段程序后，发现，程序并没有按照你想象的样子去执行
            //调试方法
            //F11逐语句调试，（单步调试）
            //F10逐过程调试
            //断点调试
            
             Console.WriteLine("hello world");
            //程序运行到断点处，就不再向下执行了
            Console.WriteLine("这行代码有可能有错误");
            Console.WriteLine("hello world");
            Console.WriteLine("hello world");
            Console.WriteLine("hello world");
            Console.WriteLine("hello world");
            Console.WriteLine("hello world");
            Console.WriteLine("hello world");

            Console.WriteLine("hello world");
            Console.WriteLine("hello world");

            Console.WriteLine("hello world");
            Console.WriteLine("hello world");
            Console.WriteLine("hello world");
            Console.WriteLine("hello world");
            Console.WriteLine("hello world");
            Console.ReadKey();
        }
    }
}
