using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @continue
{
    class Program
    {
        static void Main(string[] args)
        {
            //while(true)
            //{
            //    Console.WriteLine("hello World");
            //    //break;
            //    continue;

            //}
            //用while continue 实现计算1 到100之间的除了能被7整除之外所有整数的和


            //int sum = 0;
            //int i = 1;
            //while(i <= 100)
            //{
            //    if(i%7 == 0)
            //    {
            //        i++;
            //        continue;
            //    }
            //    sum += i;
            //    i++;

            //}
            //Console.WriteLine(sum);
            
            //找出100之内所有的素数
            //素数/质数：只能被1和自身整除的数字
            //1 不是质数，最小的质数是2 3 5 7 11
            //2 3 4 5 6 7 
            //7 7%1 7%2 7%3 7%4 7%5 7%6 7%7
            for(int i = 2;i <= 100;i++)
            {
                for(int j = 2;j <i;j++)
                {
                    if(i%j == 0)
                    {
                        continue;
                    }
                    
                }
                
            }

            Console.ReadKey();
        }
    }
}
