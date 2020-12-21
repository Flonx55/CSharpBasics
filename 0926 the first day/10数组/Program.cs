using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10数组
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 知识点
            //数组
            //一次性存储多个相同类型的变量
            //语法：
            //数组类型【】 数组名称 = new 数组类型【数组长度】；
            //int[] nums = new int[10];

            //当写了上面这一行代码之后，就在内存中开辟了连续的10块空间，我们管每一块称之为
            //这个数组的元素
            //nums[6] = 10;
            //我们通过一个循环给数组赋值，同样，也通过一个循环对数组进行取值
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    nums[i] = i;
            //}
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}
            //Console.ReadKey();

            //如果你想要访问到数组中某一块元素，需要通过这个元素的下标或者索引去访问
            //数组的长度一旦固定了，就不能再被改变了


            //数组的声明方式
            //int[] numsZero = new int[10];
            //int[] numsTwo = {1,2,3,4,5,6 };
            //int[] numsThree = new int[3] { 1, 2, 3 };//不推荐
            //int[] numsFour = new int[] { 1, 2, 3, 4, 5 };

            #endregion
            #region 实例
            #region 实例1
            //实例1：从一个整数数组中取出最大的整数，最小整数，总和，平均值
            //声明一个int类型的数组，并随意的赋初值
            //int[] nums = { 1, 2, 3, 4, 5, 6, 7, 8, 9};
            //int max = int.MinValue;
            //int min = int.MaxValue;
            ////int min = nums[0]；
            //double sum = 0.0;
            ////声明两个变量用来存储最大值和最小值
            ////循环的让数组中的每个元素跟我的最大值，最小值进行比较
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    //关于在循环中nums[i]的理解方式
            //    //1、代表数组中当前循环到的元素
            //    //2、代表数组中的每个元素
            //    //如果数组中当前循环到的这个元素 比我的max还要大，则把当前这个元素赋值给我的max
            //    if (nums[i]<min)
            //    {
            //        min = nums[i];
            //    }
            //    if(nums[i]>max)
            //    {
            //        max = nums[i];
            //    }
            //    sum += nums[i];
            //}
            //Console.WriteLine("这个数组的最大值是{0}，最小值是{1}，总和是{2}，平均值是{3}",max,min,sum,sum/(nums.Length));
            //Console.ReadKey();
            #endregion
            #region 实例2
            //数组里面都是人的名字，分割成，例如：老杨|老苏|老邹
            //（老杨，老苏，老邹，老虎，老牛，老蒋，老王，老马）

            //string[] Name = { "老杨", "老苏", "老邹", "老虎", "老牛", "老马" };
            //老杨|老苏|老邹|老虎|老牛|老马
            //解题思路：通过一个循环，获得字符串数组中的每一个元素
            //string str = null; 
            //for (int i = 0; i < Name.Length-1; i++)
            //{
            //    str += Name[i] + "|";
            //}
            //Console.WriteLine(str+Name[Name.Length -1);
            //Console.ReadKey();
            #endregion
            #region 实例3
            //将一个整数数组的每一个元素进行如下的处理：
            //如果元素是正数则将这个位置的元素的值加1
            //如果元素是负数则将这个位置的元素的值减1
            //如果元素的值是0则不变

            //int[] nums = { 1, -2, 3, -4, 5, 6, 0 };
            ////解题思路：通过一个循环获取数组中的每一个元素
            ////对每一个元素进行判断
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (nums[i] > 0)
            //    {
            //        nums[i] += 1;
            //    }
            //    else if (nums[i] < 0)
            //    {
            //        nums[i] -= 1;
            //    }

            //}
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    Console.WriteLine(nums[i]);
            //}
            //Console.ReadKey();
            #endregion
            #region 实例4
            //将一个字符串数组的元素的顺序进行反转，{“我”，“是”，“好人”}{“好人”，"是","我"}
            //string[] names = {"我","是","好人" };

            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.Write(names[names.Length-i-1]);
            //}

            //for (int i = 0; i < names.Length/2; i++)
            //{
            //    string temp = names[i];
            //    names[i] = names[names.Length - 1 - i];
            //    names[names.Length - 1 - i] = temp;
            //}
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);
            //}

            Console.ReadKey();
            #endregion
            #endregion


            #region 练习
            #endregion
        }
    }
}
