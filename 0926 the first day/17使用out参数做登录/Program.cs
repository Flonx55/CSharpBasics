using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17使用out参数做登录
{
    class Program
    {
        static void Main(string[] args)
        {
            //分别提示用户输入用户名和密码
            //写一个方法判断用户输入的是否正确
            //返回给用户一个登录结果,并且还要单独的返回给用户一个登录信息
            //如果用户名错误,除了返回登录结果外,还要返回一个"用户名错误"
            //如果密码错误,除了返回登录结果外,还要返回一个"密码错误"

            Console.WriteLine("请输入用户名");
            string userName = Console.ReadLine();
            Console.WriteLine("请输入密码");
            string userCode = Console.ReadLine();
            bool b = IsLogin(userName, userCode, out string msg);
            Console.WriteLine("登录信息{0}",b);
            Console.WriteLine("登录信息{0}",msg);
            Console.ReadKey();
        }
        /// <summary>
        /// 判断登录是否成功
        /// </summary>
        /// <param name="name">用户名</param>
        /// <param name="code">密码</param>
        /// <param name="msg">多余返回的信息</param>
        /// <returns></returns>
        public static bool IsLogin(string name,string code ,out string msg)
        {
            if(name=="admin"&&code=="888888")
            {
                msg = "登录成功";
                return true;
                
            }
            else if(name=="admin")
            {
                msg = "密码错误";
                return false;
            }
            else if(code=="888888")
            {
                msg = "用户名错误";
                return false;
            }
            else
            {
                msg = "未知错误";
                return false;
            }
        }
    }
}
