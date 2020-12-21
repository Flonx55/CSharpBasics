using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02for循环
{
    class Program
    {
        static void Main(string[] args)
        {
            //向控制台打印10遍 欢迎来到传智播客.net学习
            //int i = 0;//定义循环次数
            //while(i<10)
            //{
            //    Console.WriteLine("欢迎来到传智播客.net学习");
            //    i++;
            //}

            //int i = 0;
            //for(;i<10;)
            //{
              Console.WriteLine("欢迎来到传智播客学习");
            //    i++;
            //}

            #region for循环基础知识
            //for 循环
            //语法
            //for（表达式1；表达式2；表达式3）
            //{
            //
            //    }
            //表达式1：一般为声明循环变量，记录循环的次数（int i = 0;）
            //表达式2：一般为循环条件，（i<10）
            //表达式3：一般为改变循环条件的代码，使循环条件终有一日不再成立（i++）

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("欢迎来到传智播客.net 学习{0}",i);
            //}
            //执行过程：程序首先执行表达式1，声明了一个循环变量用来记录循环的次数
            //然后执行表达式2，判断循环条件是否成立，如果表达式2返回的结果为true
            //则执行循环体，当执行完循环体后，执行表达式3，然后执行表达式2继续判断循环体条件是否
            //成立，如果成立，就继续执行循环体，如果不成立，则跳出for循环
            #endregion

            #region for循环的正序输出和倒序输出
            //for (int i = 10; i >=1; i--)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int i = 10; i >= 1; i--)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region 求1-100之间的所有整数和 偶数和 奇数和            
            //int ou = 0;
            //int ji = 0;
            //int nums = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    ji += i;

            //    ou += ++i;
            //    nums += 2 * i - 1;

            //}
            //Console.WriteLine(ji);
            //Console.WriteLine(ou);
            //Console.WriteLine(nums);
            //Console.ReadKey();
            #endregion

            #region 找出100-999间的水仙花数
            //水仙花数指的是这个百位数字的
            //百位的立方加上十位的立方加上个位的立方==当前这个百位数字
            //153 1 125 27 153

            //int bai, shi, ge;
            //for (int i = 100; i < 1000; i++)
            //{
            //    bai = i / 100;
            //    shi = i % 100 / 10;
            //    ge = i % 10;
            //    if(bai*bai*bai+shi*shi*shi+ge*ge*ge==i)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            #endregion

            #region 输出99乘法表（循环的嵌套）

            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        //if (i >= j)
            //        Console.Write("{0}*{1}={2}\t", i, j, i * j);
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();
            #endregion

            #region 循环录入5个人的年龄并计算平均年龄 如果录入的数据出现负数或大于100的数，立即停止输入并报错

            //int age = 0;
            //int sum = 0;
            //bool b = true;

            //for (int i = 0; i < 5; i++)
            //{
            //    try
            //    {

            //        Console.WriteLine("请输入第{0}名的年龄：", i + 1);
            //        age = int.Parse(Console.ReadLine());
            //        if (age < 0 || age > 100)
            //        {
            //            Console.WriteLine("输入错误,不在正常范围内！");

            //            b = false;
            //            break;
            //        }
            //        else
            //        {
            //            sum += age;

            //        }
            //    }
            //    catch
            //    {
            //        Console.WriteLine("输入的年龄不正确，程序退出！");
            //        b = false;
            //        break;
            //    }
            //}
            //if(b)
            //{
            //    Console.WriteLine("平均年龄是{0}", sum / 5);
            //}
            //Console.ReadKey();
            #endregion

            #region 在while中用break实现要求用户一直输入用户名和密码 只要不是admin，888888，就一直提示要求重新输入，如果正确就提示登录成功

            //string name = "";
            //string code = "";
            //while (true)
            //{

            //    Console.WriteLine("请输入用户名：");
            //     name = Console.ReadLine();
            //    Console.WriteLine("请输入密码：");
            //     code = Console.ReadLine();

            //    if (name=="admin"&&code == "888888")
            //    {
            //        Console.WriteLine("登录成功！");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("请重新输入！");

            //    }
            //}
            //Console.ReadKey();

            #endregion

            #region 1-100之间的整数相加，得到累加值大于20的当前数，打印6

            //int sum = 0;
            //for (int i = 1; i <= 100; i++)
            //{
            //    sum += i;
            //    if (sum > 20)
            //    {

            //        Console.WriteLine(i);
            //        break;
            //    }
            //}
            //Console.ReadKey();


            #endregion

            #region 0-100的质数
            //for (int i = 2; i < 101; i++)
            //{
            //    bool b = true;
            //    for (int j = 2; j < i; j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            b = false;
            //            break;//除尽了说明不是质数，也就没有再往下继续取余的必要了
            //        }

            //    }
            //    if (b)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.ReadKey();
            #endregion


              



            #region 杨辉三角

            //Console.WriteLine("请输入三角形边长");
            //int n;
            //int.TryParse(Console.ReadLine(), out n);
            //if (n <= 0)
            //    return;
            //int[,] a = new int[n, n];
            //a[0, 0] = 1;
            //a[0, 1] = 1;
            //for (int i = 1; i < n - 1; i++)
            //{
            //    a[i, 0] = 1;
            //    a[i, i + 1] = 1;
            //    for (int j = 1; j < n - 1; j++)
            //    {
            //        a[i, j] = a[i - 1, j - 1] + a[i - 1, j];
            //    }

            //}
            //for (int i = 0; i < n - 1; i++)
            //{
            //    for (int j = 0; j <= i + 1; j++)
            //    {
            //        Console.Write("{0}", a[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();
            #endregion
        }
    }
}
