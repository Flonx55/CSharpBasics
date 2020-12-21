using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11冒泡排序
{
    class Program
    {

        static void Main(string[] args)
        {
            #region 知识点
            //冒泡排序，就是将一个数组中的元素按照从大到小或者从小打大的顺序进行排序
            int[] nums = { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            //0,1,2,3,4,5,6,7,8,9
            //第一趟比较：8，7，6，……交换了九次
            //第二趟比较：交换了八次
            //第三趟比较：6，5，4，3，2，1，7，8，9交换了七次
            //第四趟比较：交换了六次
            //第九趟比较
            //Array.Sort(nums);
            ////Array.Reverse(nums);
            //foreach (int item in nums)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.ReadKey();

            // Array.Sort(nums);//只能针对数组做一个升序的排列

            //Array.Reverse(nums);//针对数组做一个反转的排列，并不一定为降序
            //降序的话先sort排列好，然后reverse

            //for (int i = 0; i < nums.Length - 1; i++)
            //{
            //    for (int j = 0; j < nums.Length - 1 - i; j++)
            //    {
            //        if (nums[j] > nums[j + 1])
            //        {
            //            int temp = nums[j];
            //            nums[j] = nums[j + 1];
            //            nums[j + 1] = temp;
            //        }
            //    }

            //}
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}
            //Console.ReadKey();



            //float[] flo = new float[10];
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"请输入第{i+1}个值");
            //    flo[i] = Convert.ToSingle(Console.ReadLine());

            //}
            //float max=flo[0], min= flo[0], sum = 0;
            //for (int i = 0; i < flo.Length-1 ; i++)
            //{
            //    sum += flo[i];
            //    if (max<flo[i+1])
            //    {
            //        max = flo[i+1];
            //    }
            //    if (min>flo[i+1])
            //    {
            //        min = flo[i+1];
            //    }
            //}
            //float avg = sum / flo.Length;
            //Console.WriteLine($"max={max},min={min},avg={avg}");


        }

    }

    #endregion

    #region 实例
    #endregion

    #region 练习
    #endregion
}


