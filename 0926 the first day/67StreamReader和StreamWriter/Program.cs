using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.InteropServices;

namespace _67StreamReader和StreamWriter
{
    class Program
    {


        static void Main(string[] args)
        {
            //使用StreamReader来读取一个文本文件
            using (StreamReader sr = new StreamReader(@"C:\Users\86182\Desktop\data.txt", Encoding.Default))
            {

                while (!sr.EndOfStream)
                {
                    //读取所有字符，基于数组中的字符将字符串拆分成多个子字符串
                    string[] str = sr.ReadToEnd().Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                    //两行一起遍历
                    for (int j = 0; j < str.Length - 1; j++)
                    {
                        //转化成StringBuider类型方便删除和插入字符
                        StringBuilder sb = new StringBuilder(str[j]);
                        StringBuilder sb2 = new StringBuilder(str[j + 1]);

                        for (int k = 0; k < str[0].Length - 1; k += 2)
                        {
                            //若四个元素均为a或b，用空格替换
                            if ((sb[k] == 'a' && sb[k + 1] == 'a' && sb2[k] ==
                                'a' && sb2[k + 1] == 'a') || (sb[k] == 'b' && sb
                                [k + 1] == 'b' && sb2[k] == 'b' && sb2[k + 1] == 'b'))
                            {
                                sb.Remove(k, 2);
                                sb2.Remove(k, 2);
                                sb.Insert(k, "  ");
                                sb2.Insert(k, "  ");
                            }
                        }
                        Console.WriteLine(sb);
                        Console.WriteLine(sb2);
                    }
                }

                Console.ReadKey();
            }
            //string i = sr.ReadLine();
            //string j = sr.ReadLine();

            //for (int m = 0; m < i.Length; m++)
            //{
            //    if (i[m] == 'a' || j[m] == 'a')
            //    {
            //        int num = Convert.ToInt32(i[m]);
            //        num = 0;
            //        num = Convert.ToInt32(j[m]);
            //        num = 0;
            //    }
            //    if (i[m] == 'b' || j[m] == 'b')
            //    {
            //        int num = Convert.ToInt32(i[m]);
            //        num = 1;
            //        num = Convert.ToInt32(j[m]);
            //        num = 1;
            //    }
            //    if (i[m] + i[m + 1] + j[m] + j[m + 1] == 0 || i[m] + i[m + 1] + j[m] + j[m + 1] == 4)

            //    {

            //    }







            //使用StreamWriter来写入一个文本文件
            //using (StreamWriter sw = new StreamWriter(@"C:\Users\86182\Desktop\newnew.txt",true))
            //{
            //    sw.Write("看我有木有把你覆盖掉");
            //}
            //Console.WriteLine("写入OK");
            //Console.ReadKey();
        }
    }
}
