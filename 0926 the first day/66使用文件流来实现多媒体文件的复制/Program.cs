using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _66使用文件流来实现多媒体文件的复制
{
    class Program
    {
        static void Main(string[] args)
        {
            //先将要复制的多媒体文件读取出来,然后再写入到你指定的位置
            string source = @"C:\Users\86182\Desktop\book.txt";
            string target = @"C:\Users\86182\Desktop\newBook.txt";
            CopyFile(source, target);
            Console.WriteLine("复制成功");
            Console.ReadKey();
        }
        public static void CopyFile(string source,string target)
        {
            //1\我们创建一个负责读取的流
            using (FileStream fsRead = new FileStream(source, FileMode.Open, FileAccess.Read))
            {
                //2创建一个负责写入的流
                using (FileStream fsWrite = new FileStream(target, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    byte[] buffer = new byte[1024 * 1024 * 5];
                    //因为文件可能会比较大,所以我们读取的时候,应该通过一个循环去读取
                    while (true)
                    {
                        //返回本次读取实际读取到的字节数
                        int r = fsRead.Read(buffer, 0, buffer.Length);
                        //如果返回一个0,也就意味着什么都没有读取到,读取完了
                        if (r==0)
                        {
                            break;
                        }
                        fsWrite.Write(buffer, 0, r);
                    }
                    
                }
            }

        }
    }
}
