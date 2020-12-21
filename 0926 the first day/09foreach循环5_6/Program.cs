using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09foreach循环5_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //5_6
            //int i = 0;
            //Console.WriteLine("请输入字符串");
            //string b = Console.ReadLine();
            //Console.WriteLine("请输入子字符串");
            //string c = Console.ReadLine();
            //foreach(string c in b)//foreach 循环只能检索char类型的元素，不能检索string类型

            //5_7
            int[,] a = new int[,] { { 0, 0, 1, 1 }, { 1, 1, 2, 2 }, { 2, 3, 4, 5 } };

            Console.WriteLine("数组a:");
            foreach(int x in a)
            {
                Console.Write(x);
                Console.Write(' ');
            }
            int[][] b = new int[3][];
            b[0] = new int[] { 0, 0, 1, 1 };
            b[1] = new int[] { 1, 1, 2, 2 };
            b[2] = new int[] { 2, 3, 4, 5 };
            Console.WriteLine("\r\n数组b:");
            foreach(int[] c in b)
            {
                foreach(int x in c)
                {
                    Console.Write(x);
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
