using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _62装箱和拆箱
{
    class Program
    {
        static void Main(string[] args)
        {
            //装箱：就是将值类型转换为引用类型
            //拆箱：将引用类型转换为值类型

            //看两种类型是否发生了装箱或者拆箱，要看，这两种类型是否存在继承关系，
            //

            //int n = 10;
            //object o = n;//object 引用类型  装箱
            //int nn = (int)o;//拆箱

            //00:00:01.0238898

            //ArrayList list = new ArrayList();
            //00:00:00.0953447

            //List<int> list = new List<int>();
            ////这个循环发生了100万次装箱操作
            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            //for (int i = 0; i < 10000000; i++)
            //{
            //    list.Add(i);
            //}
            //sw.Stop();
            //Console.WriteLine(sw.Elapsed );
            //Console.ReadKey();

            //这个地方没有发生任意类型的装箱和拆箱
            //string str = "123";
            //int n = Convert.ToInt32(str);


            int n = 10;
            IComparable i = n; //装箱


        }
    }
}
