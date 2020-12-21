using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21params可变参数
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] s = { 99, 88, 77 };
            //Test("张三", 99,88,77);
            //Console.ReadKey(); 

            //求任意长度数组的和,整数类型的
            int[] nums = {1,2,3,4,5 };
            int sum = GetSum( nums);
            Console.WriteLine(sum);
            Console.ReadKey();
            


        }

        public static int GetSum(params int[] n)
        {
            int sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                sum += n[i];
            }
            return sum;
        }
        //将实参列表中跟可变参数数组类型一致的元素都当作数组的元素去处理
        //params可变参数必须是形参列表中的最后一个参数
        //
        public static void Test(string name,params int[] score)
        {
            int sum = 0;
            for (int i = 0; i < score.Length; i++)
            {
                sum += score[i];

            }
            Console.WriteLine("{0}这次考试的总成绩是{1}", name, sum);
        }
    }
}
