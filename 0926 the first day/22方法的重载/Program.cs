using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22方法的重载
{
    class Program
    {
        static void Main(string[] args)
        {
            //方法的重载指的就是方法的名称相同,但是参数不同
            //参数不同,分为两种情况
            //1)如果参数的个数相同,那么参数的类型不能相同
            //2)如果参数的类型相同,那么参数的个数不能相同
            //***方法的重载跟返回值没有关系***
            Console.WriteLine(1);
        }
        public static void M(int n1,int n2)
        {
            int result = n1 + n2;
        }
        public static double M(double d1,double d2)
        {
            return d1 + d2;
        }
        public static void M(int n1,int n2 ,int n3)
        {
            int result = n1 + n2 + n3;
        }
        public static string M(string s1,string s2)
        {   
            return s1 + s2;
        }
    }
}
