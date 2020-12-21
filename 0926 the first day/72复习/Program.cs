using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _72复习
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            泛型集合
            *List<T>
            *Dictionary<T,T>
            *装箱和拆箱
                装箱:将值类型转换为引用类型
                拆箱:将引用类型转换为值类型
                我们应该尽量避免在代码中发生装箱或者拆箱
            *文件流
            *FileStream StreamReader和StreamWriter
            *多态:虚方法,抽象类,接口
            *虚方法:
            *抽象类:
            
            */
            //List<int> list = new List<int>();//确定了元素的类型,不会发生装箱和拆箱

            //Dictionary<int, string> dic = new Dictionary<int, string>();
            //dic.Add(1, "张三");//如果添加进相同的键,会抛异常
            //dic[2] = "李四";//会覆盖原来的值
            //foreach (KeyValuePair <int,string> kv in dic)
            //{
            //    Console.WriteLine("{0}------{1}",kv.Key ,kv.Value );
            //}
            //Console.ReadKey();


            //File FileStream StreamReader StreamWriter
            //using (FileStream fsRead = new FileStream(@"C:\Users\86182\Desktop\book.txt", FileMode.OpenOrCreate, FileAccess.Read)) 
            //{
            //    byte[] buffer = new byte[1024 * 1024 * 5];
            //    //本次读取实际读取到的字节数
            //    int r =fsRead.Read(buffer, 0, buffer.Length );

            //    //将字节数组中的每个元素按照我们指定的编码格式解析成字符串
            //    string s =  Encoding.Default.GetString(buffer, 0, r);
            //    Console.WriteLine(s);
            //    Console.ReadKey();


            //using (FileStream fsWrite = new FileStream(@"C:\Users\86182\Desktop\book.txt",FileMode.Append ,FileAccess.Write))
            //{
            //    string s = "今天好热";
            //    byte[] buffer = Encoding.Default .GetBytes(s);
            //    fsWrite.Write(buffer,0,buffer.Length );
            //}
            //Console.WriteLine("Ok");
            //Console.ReadKey();







            //虚方法和抽象类

            //老师可以起立 学生也可以起立 校长也可以起立
            //声明父类去指向子类对象
            //Person p = new HeadMaster();//new Teacher();//new Student();
            //p.StandUp();//父类自己的standup，里面装的是子类对象
            //Console.ReadKey();
            
        }
    }
    public abstract class Person
    {
        public abstract void StandUp();
    }
    public class Student:Person
    {
        public override void StandUp()
        {
            Console.WriteLine("学生起立，说老师好");
        }
    }
    public class Teacher : Person
    {
        public override void StandUp()
        {
            Console.WriteLine("老师起立，说校长好");
        }
    }
    public class HeadMaster:Person
    {
        public override void StandUp()
        {
            Console.WriteLine("校长起立，说领导好");
        }
    }

}
