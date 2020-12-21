﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53键值对集合
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建了键值对集合对象
            Hashtable ht = new Hashtable();
            ht.Add(1,"张三");
            ht.Add(2, true);
            ht.Add(3, '男');
            ht.Add(false, "错误的");
            ht[6] = "新来的";//这也是一种添加数据的方式
            ht[1] = "把张三干掉";
            ht.Add("abc", "cba");

            //abc---cba
            if(!ht.ContainsKey ("abc"))
            {
                ht.Add("abc","cba");
            }
            else
            {
                Console.WriteLine("已经包含了abc这个键");
            }
            //ht.Clear();
            ht.Remove(3);



            //在键值对集合中,是根据键去找值的
            //*******键值对集合中,键必须是唯一的.而值是可以重复的

            //Console.WriteLine(ht[1]);
            //Console.WriteLine(ht[2]);
            //Console.WriteLine(ht[3]);
            //Console.WriteLine(ht[false]);

            //foreach 循环
            foreach (var item in ht.Keys )
            {
                Console.WriteLine(ht[item]);
            }




            //for (int i = 0; i < ht.Count ; i++)
            //{
            //    Console.WriteLine(ht[i]);
                
            //}
            Console.ReadKey();
        }
    }
}
