using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41字符串的各种方法
{
    class Program
    {
        static void Main(string[] args)
        {
            //1)Length：获得当前字符串中字符的个数
            //2)ToUpper():将字符转换成大写形式
            //3）ToLower():将字符转换成小写形式
            //4)Equals(lessonTwo,StringComparison.OrdinalIgnoreCase):比较两个字符串忽略大小写
            //5)Split()分割字符串,返回字符串类型的数组
            //6)Substring():截取字符串,在截取的时候包含要截取的那个位置
            //7)IndexOf():判断某个字符串在字符串中第一次出现的位置,如果没有返回-1,
            //8)LastIndexOf():判断某个字符串在字符串中最后一次出现的位置,如果没有同样返回-1
            //9)StartsWith():判断以...开始
            //10)EndWith():判断以...结束
            //11)Repalce():将字符串中某个字符串替换成一个新的字符串
            //12)Contains():判断某个字符串中是否包含指定的字符串
            //13)Trim():去掉字符串中前后的空格
            //14)TrimEnd():去掉字符串中结尾的空格
            //15)TrimStart():去掉字符串中前面的空格
            //16)string.IsNullOrEmpty():判断一个字符串是否为空或者为Null
            //17)string.Join():将数组按照指定的字符串连接,返回一个字符串




            //练习1:随机输入你心中想到的一个名字,然后输出它的字符串长度,Length:可以得到字符串的长度
            //Console.WriteLine("请输入你心中想的那个名字:");
            //string name = Console.ReadLine();
            //Console.WriteLine("你心中想的人的名字的长度是{0}",name.Length );
            //Console.ReadKey();


            //两个学员输入各自最喜欢的课程名称，判断是否一致，如果相等，则输出你们俩喜欢相同的课程，如果不相同，则输出你们俩喜欢不相同
            //的课程
            //Console.WriteLine("请输入你喜欢的课程");
            //string lessonOne = Console.ReadLine();
            ////将字符串转换成大写
            ////lessonOne = lessonOne.ToUpper();
            ////将字符串转换成小写
            ////lessonOne = lessonOne.ToLower();
            //Console.WriteLine("请输入你喜欢的课程");
            //string lessonTwo = Console.ReadLine();
            ////lessonTwo = lessonTwo.ToUpper();

            //if(lessonOne.Equals (lessonTwo,StringComparison.OrdinalIgnoreCase))
            //{
            //    Console.WriteLine("你们俩喜欢的课程相同");
            //}
            //else
            //{
            //    Console.WriteLine("你们俩喜欢的课程不同");
            //}
            //Console.ReadKey();



            //string s = "a  b   dfd _  +  =  ,,,   fdf";
            ////分割字符串split
            //char[] chs = { ' ', '_', '+', '=',',' };
            //string[] str = s.Split(chs,StringSplitOptions .RemoveEmptyEntries);
            //Console.WriteLine(str);
            //Console.ReadKey();




            //string s = "2008-08-08";
            ////char[] chs = {'-' };
            //string[] date = s.Split(new char[] { '-'}, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine("{0}年{1}月{2}日",date[0],date[1],date[2]);
            //Console.ReadKey();



            //string str = "国家关键人物老赵";
            //if(str.Contains ("老赵"))
            //{
            //    str = str.Replace("老赵","**");
            //}
            //Console.WriteLine(str);
            //Console.ReadKey();




            //SubString  截取字符串

            //string str = "今天天气好晴朗,处处好风光";
            //str = str.Substring(1,2);
            //Console.WriteLine(str);
            //Console.ReadKey();



            //string str = "今天天气好晴朗,处处好风光";
            //if(str.StartsWith ("今天"))
            //{
            //    Console.WriteLine("是的");
            //}
            //else
            //{
            //    Console.WriteLine("不是的");
            //}
            //Console.ReadKey();




            //string str = "今天天气好晴朗,处处好风光";
            // int index =  str.IndexOf('天',2);
            //Console.WriteLine(index);
            //Console.ReadKey();

            //string str = "今天天气好晴朗,处处好风光";
            //int index = str.LastIndexOf('天');
            //Console.WriteLine(index);
            //Console.ReadKey();



            //LastIndexOf  Substring
            //string path = @"\a\b\c老\d\dg\g\h\老师";
            //int index = path.LastIndexOf("\\");
            //path = path.Substring(index+1);
            //Console.WriteLine(path);
            //Console.ReadKey();



            //string str = "        hahaha         ";
            //string[] haha  = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine(haha);
            //Console.ReadKey();
            //str = str.Trim();
            //str = str.TrimEnd();
            //Console.Write(str);
            //Console.ReadKey();



            //string str ="";
            //if(string.IsNullOrEmpty (str))
            //{
            //    Console.WriteLine("是的");
            //}
            //else
            //{
            //    Console.WriteLine("不是");
            //}
            //Console.ReadKey();


            //string[] names = { "张三", "李四", "王五", "赵六", "田七" };
            //string str = string.Join("|", names);
            //Console.WriteLine(str);
            //Console.ReadKey();

        }
    }
}
 