using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46里_氏转换
{
    class Program
    {
        static void Main(string[] args)
        {
            //object:一切类型的基类
            //里氏转换:1)子类可以赋值给父类:如果有一个地方,需要父类作为参数,我们可以给一个子类代替
            //2)如果父类中装的是子类对象,那么可以将这个父类强转为子类对象


            //子类对象可以调用父类中的成员,但是父类对象永远都只能调用自己的成员

            //Student s = new Student();
            //Person p = s;
            Person p = new Student();
            //string str = string.Join("|",new string[] { "1","2","3","4"});
            //Console.WriteLine(str);
            //Console.ReadKey();


            //if(p is Student )//把p转换成Teacher
            //{
            //    Student ss = (Student)p;
            //    ss.StudentSayHello();

            //}
            //else
            //{
            //    Console.WriteLine("转换失败");
            //}

            //as的用法
             Student t = p as Student ;
            t.StudentSayHello();


            Console.ReadKey();


            //is:表示类型转换，如果能够转换成功，则返回一个true,否则返回一个false
            //as:如果能够转换,如果能够转换则返回对应的对象,否则返回一个null
            
        }
    }

    public class Person
    {
        public void PersonSayHello()
        {
            Console.WriteLine("我是父类");
        }
    }
    public class Student:Person 
    {
        public void StudentSayHello()
        {
            Console.WriteLine("我是学生");
        }
    }
    public class Teacher:Person 
    {
        public void TeacherSayHello()
        {
            Console.WriteLine("我是老师");
        }
    }
}
