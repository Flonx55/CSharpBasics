using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while循环
{
    class Program
    {
        static void Main(string[] args)
        {
            //执行过程：程序首先会执行do中的循环体，执行完成后，会判断do-while循环的循环条件
            //如果成立，则继续执行do中的循环体，如果不成立，则跳出do-while循环
            //特点：最少执行一遍，先循环，在判断
            //string answer = "";
            //do
            //{
            //    Console.WriteLine("老师，我唱的你满意吗？yes/no");
            //     answer = Console.ReadLine();
            //} while (answer=="no");
            //Console.WriteLine("ok,放学回家");
            //Console.ReadKey();
            //Console.WriteLine("老师我唱的你满意吗？");
            //string answer = Console.ReadLine();
            //while(answer == "no")
            //{
            //    Console.WriteLine("老师，我再唱了一遍，你满意么？");
            //    answer = Console.ReadLine();
            //}


            //string userName = "";
            //string pwd = "";
            //do
            //{
            //    Console.WriteLine("请输入用户名");
            //    userName = Console.ReadLine();
            //    Console.WriteLine("请输入密码");
            //    pwd = Console.ReadLine();
            //} while (userName != "admin"&&pwd != "888888");
            //Console.WriteLine("输入成功！");
            //Console.ReadKey();


            //string name = "";
            //string pwd = "";
            //do
            //{
            //    Console.WriteLine("请输入用户名：");
            //    name = Console.ReadLine();
            //    Console.WriteLine("请输入密码：");
            //    pwd = Console.ReadLine();
            //} while (name != "admin"&&pwd != "888888");
            //Console.WriteLine("登录成功");
            //Console.ReadKey();


            //不断要求用户输入学生姓名，输入q结束

            //string name = "";
            //do
            //{
            //    Console.WriteLine("请输入学生姓名：");
            //    name = Console.ReadLine();
            //} while (name != "q");
            //Console.ReadKey();



            //不断要求用户输入一个数字，然后打印这个数字的二倍，输入q结束
            //循环体：要求用户输入一个数字 接收 转换 打印2倍
            //循环条件：输入的不能是q
            //string input = "";
            //while(input != "q")
            //{
            //    Console.WriteLine("请输入一个数字，我们将打印这个数字的2倍");
            //    //不能直接转换为int类型 因为用户有可能输入 q
            //    input = Console.ReadLine();//数字 q 乱七八糟
            //    if(input != "q")
            //    {
            //        try
            //        {
            //            int number = Convert.ToInt32(input);
            //            Console.WriteLine("您输入的数字的2倍是{0}", number * 2);
            //        }
            //        catch
            //        {
            //            Console.WriteLine("输入的字符串不能转化为数字，请重新输入");
            //        }
            //    }
            //    else//==q
            //    {
            //        Console.WriteLine("输入的是q，程序退出");
            //    }
              
            //}
            //Console.ReadKey();
            //int num;
            //string num1;
            //do
            //{
            //    Console.WriteLine("请输入一个数字：");
            //    num1 = Console.ReadLine();
            //    if (num1 == "q")
            //        return;
            //    else
            //    {
            //        num = Convert.ToInt32(num1);
            //        Console.WriteLine("{0}", num * 2);
            //    }

            //} while (num1 !="q");
            //Console.ReadKey();

            //不断要求用户输入一个数字，（假定用户输入的都是正整数，当用户输入end的时候显示刚才输入的数字中的最大值）
            //提示用户输入一个数字，接收，转换成int类型，不停的比较大小
            //循环条件：输入的不能是end

            string input = "";
            int max = 0;
            while(input != "end")
            {
                Console.WriteLine("请输入一个数字，输入end我们将显示你的输入的最大值");
                input = Console.ReadLine();//数字 end 乱七八糟
                if(input != "end")
                {
                    try
                    {
                        int number = Convert.ToInt32(input);
                        //让用户输入的每个数字都跟我假定的最大值比较，只要比我假定的最大值要大
                        //就把当前输入的这个数字赋值给我的最大值
                        if (number > max)
                        {
                            max = number;
                        }
                    }
                    catch
                    {
                        Console.WriteLine("您输入的字符串不能转换为int，请重新输入");
                    }
                }
                else//==end
                {
                    Console.WriteLine("您刚才输的数字中最大值是{0}",max);
                }
            }
            Console.ReadKey();
        



        }
    }
}
