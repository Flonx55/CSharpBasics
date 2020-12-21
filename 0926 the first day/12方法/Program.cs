using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12方法
{
    class Program
    {
        
        static void Main(string[] args)
        {
            #region 知识点
            //（方法）函数就是将一堆代码进行重用的一种机制，函数就是一段代码，这段代码可能有输入
            //的值（参数），可能会有返回值，一个函数就像一个专门做这件事的人，我们调用它来做一些事情
            //它可能需要我们提供一些数据给他，它执行完成后可能会有一些执行结果给我们，要求的数据就是参数
            //返回的执行结果就是返回值

            //string s = Console.ReadLine()就是一个有返回结果的函数；
            //Console.writeline("Hello")就是一个有执行参数的函数，知有告诉writeline被打印的数据它才知道如何
            //打印，int i = Convert.Toint32("22")则是一个既有参数又有返回值的函数，
            //有了函数写代码就像拼积木，c#中的各种各样的技术=其实就是通过for、if这些基础的语法将不同的函数按照
            //一定的逻辑组织起来

          
            //方法：函数就是一堆代码进行重用的一种机制
            //函数的语法：
            //【public】 static 返回值类型 方法名（【参数列表】）
            //{
            //      方法体
            //}
            //public：访问修饰符，公开的，公共的，哪都可以访问
            //static：静态的
            //返回值类型：如果不需要返回值，写void
            //方法名：pascal：每个单词的首字母都大写，其余字母小写
            //参数列表：完成这个方法所必须要提供给这个方法的条件，如果没有参数，小括号也不能省略

            ///****在某些情况下，类名是可以省略的，如果你写的方法跟main函数同在一个类中，这个时候
            //类名可以省略

            #endregion

            #region 实例 return用法

            #region 实例1 return用法
            //计算两个整数之间的最大值

            //int max = Program.GetMax(1,3);
            //Console.WriteLine(max);
            //Console.ReadKey();

            //超级玛丽 闪烁 播放一段特殊的音乐 屏幕停止
            //Console.WriteLine("超级玛丽走呀走，跳呀跳，顶呀顶");
            //Console.WriteLine("突然，顶到一个无敌");
            //Console.WriteLine("屏幕开始闪烁");
            //Console.WriteLine("播放无敌的背景音乐");
            //Console.WriteLine("屏幕停止");
            //Console.WriteLine("超级玛丽走呀走，跳呀跳，顶呀顶");
            //Console.WriteLine("超级玛丽走呀走，跳呀跳，顶呀顶");
            //Console.WriteLine("突然，顶到一个无敌");

            //Program.Wudi();
            //Console.ReadKey();
            #endregion
            #endregion

           
        }
        /// <summary>
        /// 计算两个整数之间的最大值并且将最大值返回
        /// </summary>
        /// <param name="n1">第一个整数</param>
        /// <param name="n2">第二个整数</param>
        /// <returns>将最大值返回</returns>
        public static int GetMax(int n1,int n2)
        {
            return n1 > n2 ? n1 : n2;
            //return作用
            //在方法中返回要返回的值
            //立即结束本次方法

            //方法写好后，如果想要被执行，必须要在main函数中调用
            //方法的调用语法：
            //类名.方法名（参数）
        }
        /// <summary>
        /// 无敌
        /// </summary>
        public static void Wudi()
        {
            Console.WriteLine("突然，顶到一个无敌");
            Console.WriteLine("屏幕开始闪烁");
            Console.WriteLine("播放无敌的背景音乐");
            Console.WriteLine("屏幕停止");
        }
        
    }
}
