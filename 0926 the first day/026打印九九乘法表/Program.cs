﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _026打印九九乘法表
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int j = 1; j <=i; j++)
                {
                    Console.Write("{0}*{1}={2} ",j,i,i*j);
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
