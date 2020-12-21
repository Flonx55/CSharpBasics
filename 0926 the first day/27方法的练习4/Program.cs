using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27方法的练习4
{
    class Program
    {
        static void Main(string[] args)
        {
            //接收输入后判断其等级并显示出来
            //判断依据如下：等级 = 优 90-100  良 80-89
            //Console.WriteLine("请输入考试成绩");
            //int score = Convert.ToInt32(Console.ReadLine());

            //string level = GetLevel(score);
            //Console.WriteLine(level);
            //Console.ReadKey();



            //请将字符串数组{"中国","美国","巴西","澳大利亚","加拿大"}中的内容反转
            //string[] names = {"中国","美国","巴西","澳大利亚","加拿大" };
            //string[] newName = Test(names);
            //for (int i = 0; i < names.Length; i++)
            //{
            //    Console.WriteLine(names[i]);

            //}
            //Console.WriteLine(newName);
            //Console.ReadKey();



            //写一个方法 计算圆的面积和周长 面积是PI*R*R 周长是2*PI*R
            double r = 5;
            double perimeter;
            double area;
            GetPerimeterArea(r, out perimeter, out area);
            Console.WriteLine(perimeter);
            Console.WriteLine(area);
            Console.ReadKey();



        }
        public static void GetPerimeterArea(double r,out double perimeter,out double area)
        {
            perimeter = 2 * 3.14 * r;
            area = 3.14 * r * r;
        }
        public static string[] Test(string[] names)
        {
            for (int i = 0; i < names.Length / 2; i++)
            {
                string temp = names[i];
                names[i] = names[names.Length - 1 - i];
                names[names.Length - 1 - i] = temp;
            }
            return names;
        }

















        public static string GetLevel(int score)
        {
            string level = "";
            switch(score/10)
            {
                case 10:
                case 9: level = "优";
                    break;
                case 8:level = "良";
                    break;
                case 7:level = "中";
                    break;
                case 6:level = "差";
                    break;
                default:level = "不及格";
                    break;
            }
            return level;
        }
        //public static int Grade(int score)
        //{
        //    try
        //    {

        //       if(score>89)
        //        {
        //            Console.WriteLine("优");
        //        }
        //       else if(score>79&&score<90)
        //        {
        //            Console.WriteLine("良");
        //        }
        //    }
        //    catch
        //    {
        //        Console.WriteLine("输入有误，请重新输入");
        //    }
        //}
    }
}
