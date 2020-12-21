using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26方法的练习3
{
    class Program
    {
        static void Main(string[] args)
        {
            //写一个方法，用来判断用户输入的数字是不是质数
            //再写一个方法，要求用户只能输入数字 输入有误就一直让用户输入 
            Console.WriteLine("请输入一个数字，我们将判断你输入的数字是否为质数");
            string strNumber = Console.ReadLine();
            int number = GetNumber(strNumber);
            bool b = IsPrime(number);
            Console.WriteLine(b);

            Console.ReadKey();
        }
        public static bool IsPrime(int number)
        {
            if(number<2)
            {
                return false;
            }
            else
            {
                //让这个数字从二开始除，除到自身的前一位
                for (int i = 2 ; i <number; i++)
                {
                    if (number % i == 0)
                    {
                        return false;
                    }
                }
                return true;//给质数准备的
            }

        }
        public static int GetNumber(string strNumber)
        {
            while (true)
            {
                try
                {
                    int number = Convert.ToInt32(strNumber);
                    return number;
                }
                catch
                {
                    Console.WriteLine("请重新输入");
                    strNumber = Console.ReadLine();
                }
            }
        }
    }
}
