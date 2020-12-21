using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25方法的练习2
{
    class Program
    {
        static void Main(string[] args)
        {
            //用方法来实现:有一个字符串数组
            //{"马龙","迈克尔乔丹","雷吉米勒","蒂姆邓肯","科比布莱恩特"}
            //string[] name = { "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特" };
            //string max = GetLongest(name);
            //Console.WriteLine(max);
            //Console.ReadKey();


            //用方法来实现:请计算出一个整型数组的平均值,保留两位小数
            int[] numbers = { 1, 2,7 };
            double avg = GetAvg(numbers);

            //从本质上保留两位小数
            string s = avg.ToString("0.000");
            avg = Convert.ToDouble(s);

            Console.WriteLine(avg);
            Console.ReadKey();

        }
        public static double GetAvg(int[] nums)
        {
            double sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];

            }
            return sum / nums.Length;
        }



        /// <summary>
        /// 求一个字符串数组中最长的元素
        /// </summary>
        /// <param name="s">接收的字符串数组</param>
        /// <returns>最大值</returns>
        public static string GetLongest(string[] s)
        {
            string max = s[0];
            for (int i = 0; i < s.Length; i++)
            {
                if(s[i].Length>max.Length)
                {
                    max = s[i];
                }
                
            }
            return max;
        }
    }
}
