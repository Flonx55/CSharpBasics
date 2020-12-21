using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20ref练习
{
    class Program
    {
        static void Main(string[] args)
        {
            //使用方法来交换两个int类型的变量
            int n1 = 10;
            int n2 = 20;
            //int temp = n1;
            //n1 = n2;
            //n2 = temp;
            Test(ref n1,ref n2);
            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.ReadKey();

            //n1 = n1 - n2;//-10 20
            //n2 = n1 + n2;//-10 10
        
            //n1 = n2 - n1;//20 10

        }
        public static void Test(ref int n1, ref int n2)
        {
            int temp = n1;
            n1 = n2;
            n2 = temp;

        }
    }
}
