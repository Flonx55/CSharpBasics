using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14方法的调用
{
    
    class Program
    {
        /// <summary>
        /// 计算两个整数之间的最大值 并且返回最大值
        /// </summary>
        /// <param name="n1">第一个数</param>
        /// <param name="n2">第二个数</param>
        /// <returns>返回的最大值</returns>
        public static int  GetMax(int n1,int n2)//形参
        {
            int max = n1 > n2 ? n1 : n2;
            return max;

        }



        //字段，属于类的字段
        public static int _number = 10;



        static void Main(string[] args)//调用者
        {
            //int b = 10;
            //int a = 3;
            //int res = Test(a);
            //Console.WriteLine(res);
            //Console.ReadKey();

            //bool b = IsRun(2000);
            //Console.WriteLine(b);
            //Console.ReadKey();
            //int a1 = 10;
            //int a2 = 29;
            //int max = GetMax(a1,a2);//实参
            //Console.WriteLine(max);
            //Console.ReadKey();
            //不管是形参还是实参，都是在内存中开辟了空间的



            //NewMethod();
            //Console.ReadKey();


            Console.WriteLine("请输入一个数字");
            string input = Console.ReadLine();
            int number = GetNumber(input);
            Console.ReadKey();
        }
        /// <summary>
        /// 需要判断用户的输入是否是数字
        /// 如果是数字，则返回
        /// 如果不是数字，提示用户重新输入
        /// </summary>
        public static int GetNumber(string s)
        {
            while (true)
            {
                try
                {
                    int number = Convert.ToInt32(s);
                    return number;
                }
                catch
                {
                    Console.WriteLine("请重新输入");
                    s = Console.ReadLine();
                }
            }
        }

        //private static void NewMethod()
        //{
        //    while (true)
        //    {
        //        Console.WriteLine("请输入一个数字：");
        //        try
        //        {
        //            int number = Convert.ToInt32(Console.ReadLine());
        //            Console.WriteLine(number);
        //            break;
        //        }
        //        catch
        //        {
        //            Console.WriteLine("输入有误！！！");
        //        }
        //    }
        //}
        //方法的功能一定要单一，方法中最忌讳的就是提示用户输入的字眼



        //我们在Main（）函数中调用Text（）函数，
        //我们管Main（）函数称之为调用者
        //管Text（）函数称之为被调用者

        //如果被调用者想要得到调用者的值：
        //1、传参
        //2、使用静态字段来模拟全局变量
        //全局变量：哪都能使用的变量



        public static int Test(int a)//被调用者
        {
            a = a + 5;
            return a;

        }
        //如果调用者想要得到被调用者的值，返回值

        #region 实例1

        //举例：写一个方法，判断一个年份是否是闰年
        /// <summary>
        /// 判断给定的年份是否是闰年
        /// </summary>
        /// <param name="year">要判断的年份</param>
        /// <returns>是否是闰年</returns>
        public static bool IsRun(int year)
        {
            bool b = (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
            return b;
        }
        #endregion
        #region 实例2
        //读取输入的整数，定义成方法
        //多次调用（如果用户输入的是数字，则返回，否则提示用户重新输入）
        
        

        #endregion
    }
}
