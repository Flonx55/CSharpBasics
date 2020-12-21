using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18自己写tryparse
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            bool b = int.TryParse("123",out num);
            Console.WriteLine(num);
            Console.WriteLine(b);
            Console.ReadKey();
        }
        public static bool MyTryParse(string s, out int result)
        {
            result = 0;
            //把字符串转换为int类型,转换失败没抛异常,
            try
            {
                result = Convert.ToInt32(s);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
