using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14十进制转换为二进制
{
    class Program
    {
        static void Main(string[] args)
        {


            //Console.WriteLine("请输入行号：");
            //Int32.TryParse(Console.ReadLine(), out int hang);
            //Console.WriteLine("请输入列号：");
            //Int32.TryParse(Console.ReadLine(), out int lie);
            //ToCorton(hang, lie);
            Random ran = new Random();
            Stopwatch sw = new Stopwatch();
            sw.Start();
            for (int i = 0; i < 1000000; i++)
            {
                int hangR = ran.Next(1000, 10000);
                int lieR = ran.Next(1000, 10000);
                ToMorton(hangR, lieR);

                //Corton 00:00:01.6402866
                //Morton 00:00:02.0941597(1和0都二次方运算)
                //Morton 00:00:01.3598750（加了条件语句之后）

                //次方运算改位移
                //Corton 00:00:00.1458368
                //Morton 00:00:00.7839517




            }
            sw.Stop();
            Console.WriteLine(sw.Elapsed);


            Console.ReadKey();
        }

        public static void ToMorton(int hang,int lie)
        {

            #region 位运算求二进制
            int num = 0;
            int temp = 0;
            int sum = 0;
            if (hang <= 15 || lie <= 15)
                num = 4;
            else if (hang <= 255 || lie <= 255)
                num = 8;
            else if (hang <= 65355 || lie <= 65355)
                num = 16;
            else
                num = 32;

            int[] hang1 = new int[num];
            int[] lie1 = new int[num];
            int[] corton = new int[num * 2];

            for (int i = 0; i < num; i++)
            {
                temp = hang & (1 << (num - 1 - i));
                temp = temp >> (num - 1 - i);
                hang1[i] = temp == 0 ? 0 : 1;
            }
            for (int i = 0; i < num; i++)
            {
                temp = lie & (1 << (num - 1 - i));
                temp = temp >> (num - 1 - i);
                lie1[i] = temp == 0 ? 0 : 1;
            }
            for (int i = 0, j = 0; i < num; i++, j += 2)
            {
                corton[j] = hang1[i];
                corton[j + 1] = lie1[i];
            }
            for (int i = 0; i < num * 2; i++)
            {
                if (corton[i] == 0)
                {
                    continue;
                }
                sum += corton[i] * (1 << (num * 2 - 1 - i));//(int)Math.Pow(2, num * 2 - 1 - i);
            }

            //Console.WriteLine(sum);
            //foreach (int item in corton)
            //{
            //    Console.Write(item);
            //}
            //Console.WriteLine();
            #endregion
        }

        public static void ToCorton(int hang, int lie)


        {

            int sum = 0;
            int tmpLie = lie;
            int tmpHang = hang;
            //int bitLie=1, bitHang=1;
            //while (tmpLie > 0)
            //{
            //    tmpLie >>= 1;
            //    if (tmpLie > 0)
            //        bitLie += 1;
            //}
            int num = 0;

            if (hang <= 15 || lie <= 15)
                num = 4;
            else if (hang <= 255 || lie <= 255)
                num = 8;
            else if (hang <= 65355 || lie <= 65355)
                num = 16;
            else
                num = 32;

            //while (tmpHang > 0)
            //{
            //    tmpHang >>= 1;
            //    if (tmpHang > 0)
            //        bitHang += 1;
            //}

            for (int i = 0; i < num; i++)
            {
                sum += ((lie << i) & (1 << (2 * i)));//((int)Math.Pow(2, 2 * i))) ;
            }

            for (int i = 0; i < num; i++)
            {
                sum += ((hang << (i + 1)) & (1 << (2 * i+1)));//((txint)Math.Pow(2, 2 * i + 1)));
            }
            //Console.WriteLine(sum);
        }

        public static void ToMorton0(int hang ,int lie)
        {
            #region 求余算二进制
            //int[] hang1 = new int[16];
            //int[] lie1 = new int[16];
            //int[] corton = new int[32];
            int num = 0;
            if (hang <= 15 || lie <= 15)
                num = 4;
            else if (hang <= 255 || lie <= 255)
                num = 8;
            else if (hang <= 65355 || lie <= 65355)
                num = 16;
            else
                num = 32;

            int[] hang1 = new int[num];
            int[] lie1 = new int[num];
            int[] corton = new int[num * 2];

            for (int i = 0; i < num; i++)
            {
                int y = 0, yuShu = 0;
                while (y <= num-1)
                {
                    yuShu = hang % 2;
                    hang /= 2;
                    hang1[num-1 - y] = yuShu;
                    y++;

                }
                if (i == 0)
                {
                    for (int k = 0, j = 0; k < num; k++, j += 2)
                    {

                        corton[j] = hang1[k];


                    }
                    hang = lie;
                }
                else
                {
                    for (int k = 0, j = 0; k < num; k++, j += 2)
                    {
                        corton[j + 1] = hang1[k];
                    }
                }
            }
            int sum=0;
            for (int i = 0; i < num*2; i++)
            {
                if (corton[i] == 0)
                {
                    continue;
                }
                sum += corton[i] * (int)Math.Pow(2, 31- i);
            }

            //foreach (int item in corton)
            //{
            //    Console.Write(item);
            //}
            //Console.WriteLine();
            //StringBuilder corton2 = new StringBuilder();
            //for (int i = 0; i < corton.Length; i++)
            //{
            //    corton2.Append(corton[i]);
            //}
            //int corton3 = Convert.ToInt32(corton2.ToString(), 2);
            //Console.WriteLine(corton3);
            #endregion
        }












        /// <summary>
        /// </summary>
        /// 将二进制数补为四位
        /// <param name="curentValue">传入的二进制不完整码</param>
        /// <returns>四位的二进制码</returns>
        public static StringBuilder ToTwo2(string currentValue)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 4 - currentValue.Length; i++)
            {
                sb.Append("0");
            }

            sb.Append(currentValue);
            int len = 8 - currentValue.Length;

            // string str =  sb.ToString();

            return sb;
        }


        /// <summary>
        /// corton算法
        /// </summary>
        /// <param name="hang">行的字符数组类型的二进制值</param>
        /// <param name="lie">列的字符数组类型的二进制值</param>
        /// <returns>行和列的Corton的二进制值</returns>
        public static StringBuilder ToCorton1(char[] hang, char[] lie)
        {
            StringBuilder sb2 = new StringBuilder();
            for (int i = 0; i < 4; i++)
            {

                sb2.Append(hang[i].ToString());
                sb2.Append(lie[i].ToString());

            }
            return sb2;
        }


        /// <summary>
        /// 将二进制转换为十进制
        /// </summary>
        /// <param name="corton">二进制码</param>
        /// <returns>十进制码</returns>
        public static int ToTen(string corton)
        {

            int corton2 = Convert.ToInt32(corton, 2);
            return corton2;
        }
    }
}
