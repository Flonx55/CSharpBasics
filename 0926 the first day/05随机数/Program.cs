using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05随机数
{
    class Program
    {
        static void Main(string[] args)
        {
            //产生随机数
            //1、创建能够产生随机数的对象
            //2、让产生随机数的这个对象调用方法来产生随机数
            //Random r = new Random();
            //while (true)
            //{
                //int rNumber = r.Next(1, 11);//左闭右开
                //Console.WriteLine(rNumber);
                //Console.ReadKey();
                //创建随机数
                //1、创建能够产生随机数的现象
                //2、让产生随机数的这个对象调用方法来产生随机数
                //输入名字随机显示这个人上辈子是什么样的人
                //首先创建能够产生随机数的对象
                //产生随机数（1，7）
                Random r = new Random();
                while (true)
                {
                    int rNumber = r.Next(1, 6);
                    Console.WriteLine("请输入名字：");
                    string name = Console.ReadLine();
                    switch (rNumber)
                    {
                        case 1:
                            Console.WriteLine("{0}上辈子是猪", name);
                            break;
                        case 2:
                            Console.WriteLine("{0}上辈子是牛", name);
                            break;
                        case 3:
                            Console.WriteLine("{0}上辈子是鸡", name);
                            break;
                        case 4:
                            Console.WriteLine("{0}上辈子是鸭", name);
                            break;
                        case 5:
                            Console.WriteLine("{0}上辈子是羊", name);
                            break;

                    }
                Console.ReadKey();
            
                

            }

        }
    }
}
