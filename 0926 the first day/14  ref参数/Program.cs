using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14__ref参数
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
        public static void JiangJin(double s)
        {
            s += 500;
        }
        public static void FaKuan(double s)
        {
            s -= 500;
        }
    }
}
