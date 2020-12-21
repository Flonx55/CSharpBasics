using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57File类
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建一个文件
            //File.Create(@"C:\Users\86182\Desktop\new.txt");
            //Console.WriteLine("创建成功!");
            //Console.ReadKey();

            //删除一个文件
            //File.Delete(@"C:\Users\86182\Desktop\new.txt");
            //Console.WriteLine("删除成功");
            //Console.ReadKey();

            //复制一个文件
            File.Copy(@"C:\Users\86182\Desktop\book.txt", @"C:\Users\86182\Desktop\book1.txt");
            Console.WriteLine("复制成功");
            Console.ReadKey();
        }
    }
}
