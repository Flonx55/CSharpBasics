using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03类型转换
{
//   class A
//    {
//        public static int X;
//        static A()
//        {
//            X = B.Y + 1;
//        }
//    }
//    class B
//    {
//        //public static int Y = A.X + 1;
//        public static int Y;
        
//        static B()
//        {
//            Y = A.X + 1;
//        }
//        //static void Main()
//        //{
//        //    Console.WriteLine($"{A.X}{B.Y}");
//        //}
//    }





    //class Class1
    //{
    //    static int num = 1;
    //    static int getNum()
    //    {
    //        return num;
    //    }
    //    static int i = getNum();
    //    int j = getNum();
    //    [STAThread]
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine(i);
    //        Console.WriteLine(new Class1().j);
           
    //    }
    //}



    

    public abstract class A
    {
        public A()
        {
            Console.WriteLine('A');
        }
        public virtual void Fun()
        {
            Console.WriteLine("A.Fun()");
        }
    }
    public class B:A
    {
        public B()
        {
            Console.WriteLine('B');
        }
        public new void Fun()
        {
            Console.WriteLine("B.Fun()");
        }
        public static void Main()
        {
            A a = new B();
            a.Fun();
        }
    }
}
