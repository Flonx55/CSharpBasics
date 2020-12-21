using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15方法的三个练习
{
    class Program
    {
        /// <summary>
        /// 限定用户只能输入yes或者no 并且返回
        /// </summary>
        /// <param name="str">用户的输入</param>
        /// <returns>返回yes或者no</returns>
        public static string IsYesOrNo(string str)
        {
            while (true)
            {
                if (str == "yes" || str == "no")
                    return str;
                else
                {
                    Console.WriteLine("只能输入yes或no，请重新输入！");
                    str = Console.ReadLine();
                    
                }
            }
        }
        /// <summary>
        /// 计算一个整数类型数组的总和
        /// </summary>
        /// <param name="nums">要求总和的数组</param>
        /// <returns>返回这个数组的总和</returns>
        public static int GetSum(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }
            return sum;
        }
        static void Main(string[] args)
        {
            //要求用户输入yes或no，改成方法
            //Console.WriteLine("请输入yes或no");
            //string str = Console.ReadLine();
            //string result = IsYesOrNo(str);
            //Console.ReadKey();


            //计算数组的和：int Sum(int[] values)
            int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int sum = GetSum(nums);
            Console.WriteLine(sum);
            Console.ReadKey();
        }

    }
}
