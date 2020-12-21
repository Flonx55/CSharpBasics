using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42字符串的练习
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 字符串各种方法综合运用
            //文本文件中  存储了多个文章标题,作者
            //标题和作者之间用若干空格(数量不定)隔开每行一组
            //标题有的长有的短,输出到控制台的时候最多添加标题长度10
            //如果超过10,则截取长度8的字符串并且最后添加"...",加一个竖线后输出作者的名字
            //string path = @"C:\Users\86182\Desktop\book.txt";
            //string[] contents = File.ReadAllLines(path, Encoding.UTF8);
            //for (int i = 0; i < contents.Length; i++)
            //{
            //    string[] strNew = contents[i].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //    //Console.WriteLine(strNew [0].+"|"+strNew [1]);
                
            //    Console.WriteLine((strNew[0].Length > 10 ? strNew[0].Substring(0, 8) + "..." : strNew[0]) + "|" + strNew[1]);
            //}
            //Console.ReadKey();
            #endregion

            #region 查找某一字符位置及次数-->string==char类型的只读数组-->查找char类型的最简单,
            //让用户输入一句话，找出所有e的位置
            //string str = "abcdeefgfefdfefdfefdfe";

            //for (int i = 0; i < str.Length ; i++)
            //{
            //    if(str[i]=='e')
            //    {
            //        Console.WriteLine(i);
            //    }
            //}
            //Console.ReadKey();

            #endregion

            #region 查找字符或字符串位置及次数-->indexof+while循环-->两者皆适用,熟练使用

            //string str = "abac";
            //int index = str.IndexOf("abac");
            //int count = 1;//用来记录aba出现的次数
            //if (index == -1)
            //{
            //     count = 0;
            //    Console.WriteLine("未找到子字符串");
               
            //}
            //else
            //Console.WriteLine("第1次出现aba的位置是{0}", index);
            ////循环体：从上一次出现aba的位置加1的位置找下一次aba出现的位置
            ////循环条件：index!=-1
           
            //while (index != -1)
            //{
            //    count++;
            //    index = str.IndexOf("abac", index + 1);
            //    if (index == -1)
            //        break;
            //    Console.WriteLine("第{0}次出现aba的位置是{1}", count, index);
            //}

            //Console.WriteLine("第{0}次出现aba的位置是", count);

            Console.ReadKey();
            #endregion

            #region 接收用户输入的字符串，将其中的字符以与输入相反的顺序输出-->ToCharArray()-->string char 转换

            //string str = "abcdefg";


            //char[] chs = str.ToCharArray();
            //for (int i = 0; i < chs.Length / 2; i++)
            //{
            //    char temp = chs[i];
            //    chs[i] = chs[chs.Length - 1 - i];
            //    chs[chs.Length - 1 - i] = temp;
            //}
            //str = new string(chs);
            //Console.WriteLine(str);
            //Console.ReadKey();
            //// 倒叙循环
            ////for (int i = str.Length - 1; i >= 0; i--)
            //// {
            ////   Console.WriteLine(str[i]);

            ////}
            #endregion

            #region 字符串顺序相反输出,并按照指定字符分隔符连接-->split()+string.Join()
            //string str = "Hello C sharp";
            //string str = "sharp c hello";
            //string[] strNew =  str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //for (int i = 0; i < strNew.Length /2; i++)
            //{
            //    string temp = strNew[i];
            //    strNew[i] = strNew[strNew.Length - 1 - i];
            //    strNew[strNew.Length - 1 - i] = temp;
            //}

            //str = string.Join(" ", strNew);
            //Console.WriteLine(str);
            //string.join:将字符串按照指定的字符分隔符连接
            //Console.WriteLine(strNew );
            //for (int i = 0; i < strNew .Length ; i++)
            //{
            //    Console.WriteLine(strNew [i]);
            //}


            //Console.ReadKey();
            #endregion

            #region 从E-mail 中提取出用户名和域名:abc@163.com-->IndexOf()+Substring()
            //string email = "abc@163.com";
            //string userName = email.Substring(0,3);
            //string yuMing = email.Substring(4);
            //Console.WriteLine(userName );
            //Console.WriteLine(yuMing );

            //string email = "1244271534@qq.com";
            //int index = email.IndexOf('@');
            //string userName = email.Substring(0, index);
            //string yuMing = email.Substring(index + 1);
            //Console.WriteLine(userName );
            //Console.WriteLine(yuMing );
            //Console.ReadKey();
            #endregion

            #region 查找指定字符,如若存在会替换-->contains n repalce
            //用户输入一句话,判断这句话中有没有邪恶,如果有邪恶就替换成这种形式然后输出,"老牛很**"
            //string str = "老牛很邪恶";
            //if (str.Contains("邪恶"))
            //{
            //  str = str.Replace("邪恶","**");
            //}
            //Console.WriteLine(str);
            //Console.ReadKey();
            #endregion

            #region 添加|，后切割掉
            //string[] names = { "诸葛亮","鸟叔","卡卡西","卡哇伊"};
            //string str = string.Join("|",names);
            //string[] strNew = str.Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
            ////Console.WriteLine(str);
            //Console.ReadKey();
            #endregion





        }
    }
}
