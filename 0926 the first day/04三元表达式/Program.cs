using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04三元表达式
{
    
    class Program
    {
        static void Main(string[] args)
        {
            //语法：表达式1？表达式2：表达式3;
            //如果表达式1的值为true，那么表达式2的值就是整个三元表达式的值
            //如果表达式1的值为false，那么表达式3的值就是整个三元表达式的值
            //注意：表达式2的结果类型必须跟表达式3的结果类型一致，并且也要跟整个三元表达式的结果类型一致

            #region 计算两个数字的大小 求出最大的
            //Console.WriteLine("请输入第一个数字：");
            //int n1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("请输入第二个数字");
            //int n2 = Convert.ToInt32(Console.ReadLine());

            //int max = n1 > n2 ? n1 : n2;
            ////if(n1>n2)
            ////{
            ////    Console.WriteLine(n1);
            ////}
            ////else

            //    Console.WriteLine(max);
            #endregion

            #region 提示用户输入一个姓名，只要输入的不是老赵，就全是流氓
            //Console.WriteLine("请输入姓名：");
            //string name = Console.ReadLine();

            //string result = name == "laozhao" ? "yincai" : "liumang";
            //Console.WriteLine(result);
            //if(name == "laozhao")
            //{
            //    Console.WriteLine("yincai");
            //}
            //else
            //{
            //Console.WriteLine("liumang");
            //}

            //Console.ReadKey();
            #endregion

            //double i = 2.5;
            //int j = (int)i;
            //Console.WriteLine(j);
            int[] arr = { 1, 6, 3, 7, 3, 5, 47, 2525, 3636,8,19 };
          
            //for (int i = arr.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(arr[i]);
            //}



            //Random ran = new Random();
            //int[] arr1 = new int[40];
            //for (int i = 0; i < 40; i++)
            //{
            //    arr1[i]= ran.Next(0, 100);
            //}
            //foreach (int item in arr1)
            //{
            //    Console.WriteLine(item);
            //}
            //for (int i = 0; i < arr.Length - 1; i++)
            //{
                for (int j = 0; j < arr.Length / 2; j++)
                {
                    int temp;
                    temp = arr[j];
                    arr[j] = arr[arr.Length - j - 1];
                    arr[arr.Length - j - 1] = temp;
                }
                foreach (int item in arr)
                {
                    Console.WriteLine(item);
                }
            
        }
        
    }
}
