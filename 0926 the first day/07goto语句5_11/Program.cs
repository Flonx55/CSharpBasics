using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07goto语句5_11
{
    class Program
    {
        static void Main(string[] args)//密码输入正确后，不会执行console.readkey(),而是转到了error语句里
        {
        start:
            Console.WriteLine("请输入身份证密码：");
            string s = Console.ReadLine();
            if (s.Length != 15 && s.Length != 18)
                goto error;
            if ((s.Length == 15 && s[14] % 2 == 0) || (s.Length == 18 && s[16] % 2 == 0))
                Console.WriteLine("性别为女");
            else
                Console.WriteLine("性别为男");
            
            Console.ReadKey();
        error:
            Console.WriteLine("长度不正确");
            goto start;
            
        }
    }
}
