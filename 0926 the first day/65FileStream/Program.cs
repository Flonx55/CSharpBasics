using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _65FileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用FileStream来读取数据
            //FileStream 操作字节的
            //Filestream StreamReader StreamWriter 操作字符的
            //1、创建FileStream对象

            FileStream fsRead = new FileStream(@"C:\Users\86182\Desktop\book.txt", FileMode.OpenOrCreate, FileAccess.Read);
            byte[] buffer = new byte[1024 * 1024 * 5];
            //返回本次实际读取的 有效字节数
            int r = fsRead.Read(buffer, 0, buffer.Length);
            //将字节数组中的每一个元素按照指定的编码格式解码成字符串
            string s = Encoding.Default.GetString(buffer, 0, r);
            //关闭流
            fsRead.Close();
            //释放流所占用的资源
            fsRead.Dispose();
            Console.WriteLine(s);
            Console.ReadKey();


            //使用FileStream来写入数据
            //将创建文件流对象的过程写在using当中,会自动的帮我们释放流所占的的资源
            //using (FileStream fsWrite = new FileStream(@"C: \Users\86182\Desktop\book.txt", FileMode.OpenOrCreate, FileAccess.Write))
            //{
            //    string str = "看我str有没有把你覆盖掉";
            //    byte[] buffer = Encoding.Default.GetBytes(str);
            //    fsWrite.Write(buffer, 0, buffer.Length);
            //}
            //Console.WriteLine("写入OK");
            //Console.ReadKey();
        }
    }
}

