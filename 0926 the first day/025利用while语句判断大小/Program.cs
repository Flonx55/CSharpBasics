using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _025利用while语句判断大小
{
    class Program
    {
        static void Main(string[] args)
        {

            //输入两个数字，使用while循环判断其中一个是否大于10，然后输出结果，终止程序。
            //如果两个数都大于10，重新输入。

            #region 自写
            //Console.WriteLine("请输入第一个数");
            //double.TryParse(Console.ReadLine(), out double a);
            //Console.WriteLine("请输入第二个数");
            //double.TryParse(Console.ReadLine(), out double b);
            //while (true)
            //{

            //    if (a > 10 && b < 10)
            //    {
            //        Console.WriteLine(a);
            //        break;
            //    }
            //    else if (b > 10 && a < 10)
            //    {
            //        Console.WriteLine(b);
            //        break;
            //    }
            //    else
            //    {

            //        Console.WriteLine("请重新输入！");
            //        Console.ReadKey();
            //        Console.WriteLine("请输入第一个数");
            //        double.TryParse(Console.ReadLine(), out a);
            //        Console.WriteLine("请输入第二个数");
            //        double.TryParse(Console.ReadLine(), out b);


            //    }
            //}
            //Console.ReadKey();
            #endregion

            #region 参考答案
            while (true)
            {
                Console.WriteLine("请输入x的值");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("请输入y的值");
                int y = Convert.ToInt32(Console.ReadLine());
                if (x>10&&y>10)
                {
                    Console.WriteLine("每个数字都大于0，请重新输入");
                }
                else if (x>10)
                {
                    Console.WriteLine(x);
                }
                else if (y>10)
                {
                    Console.WriteLine(y);
                }
                else
                {
                    Console.WriteLine("每个数字都小于10");
                }
                Console.ReadKey();
            }
            #endregion
        }
    }
}
