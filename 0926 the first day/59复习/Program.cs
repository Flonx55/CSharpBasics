using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.IO;

namespace _59复习
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
                里氏转换：
                1,子类可以赋值给父类(如果有一个方法需要父类作为参数,我们可以传一个子类对象)
                2,如果父类中装的是子类对象,则可以将这个父类强转为子类对象
            */

            //Person p = new Student();
            ////is as
            //Student ss = p as Student;
            //ss.StudentSayHello();
            //Console.ReadKey();

            //if(p is Student )
            //{
            //    ((Student)p).StudentSayHello();
            //}
            //else
            //{
            //    Console.WriteLine("转换失败");
            //}
            //Console.ReadKey();

            //ArrayList list = new ArrayList();
            //Remove RemoveAt RemoveRange Clear Insert InsertRange
            //Reverse Sort

            //Hashtable ht = new Hashtable();
            //ht.Add(1,"张三");
            //ht.Add(true,'男');
            ////在键值对集合中,键必须是唯一的
            //ht[1] = "李四";
            ////ht.ContainsKey 
            //foreach (var item in ht.Keys )
            //{
            //    Console.WriteLine(ht[item]);
            //}
            //Console.ReadKey();


            //Path


            //File
            //Create Delete Copy Move
            //将字节数组中的每一个元素都要按照我们指定的编码格式去解码成字符串
            //UTF-8 GB2312 GBK ASCII Unicode
            //byte[] buffer = File.ReadAllBytes(@"C:\Users\86182\Desktop\book.txt");
            //string s = Encoding.GetEncoding("UTF-8").GetString(buffer);
            //Console.WriteLine(s);
            //Console.ReadKey();

            //没有这个文件的话 会给你创建一个 有的话 会给你覆盖掉
            //string str = "今天天气好晴朗,处处好风光";
            //byte[] buffer =  Encoding.Default.GetBytes(str);
            //File.WriteAllBytes(@"C:\Users\86182\Desktop\book.txt",buffer);
            //Console.WriteLine("写入成功");
            //Console.ReadKey();

            //以行的形式读取
            // string [] content = File.ReadAllLines(@"C:\Users\86182\Desktop\book.txt",Encoding .Default );
            //foreach (string item in content )
            //{
            //    Console.WriteLine(item);
            //}
            //Console.ReadKey();

            string str = File.ReadAllText(@"C:\Users\86182\Desktop\book.txt",Encoding .Default );
            Console.WriteLine(str);
            Console.ReadKey();


        }
    }

    public class Person
    {
        public void PersonSayHello()
        {
            Console.WriteLine("我是老师");
        }
    }
    public class Student:Person
    {
        public void StudentSayHello()
        {
            Console.WriteLine("我是学生");
        }
    }

}
