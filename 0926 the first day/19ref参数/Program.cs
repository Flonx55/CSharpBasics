using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19ref参数
{
    class Program
    {
        static void Main(string[] args)
        {
            double salary = 5000;
            JiangJin(salary);
            Console.WriteLine(salary);
            Console.ReadKey();
        }
        public static double JiangJin(double s)
        {
            s += 500;
            return s;
        }
        public static void FaKuan(double s)
        {
            s -= 500;
            return s;
        }
    }
}
