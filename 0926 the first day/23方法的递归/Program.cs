using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23方法的递归
{
    class Program
    {
        static void Main(string[] args)
        {
            //递归:方法自己调用自己
            //找出一个文件夹中所有的文件
            //需要一个方法需要一个指定文件夹下所有的文件
            //C:\文件夹1
            TellStory();
            Console.ReadKey();
        }
        public static int i = 0;
        public static void TellStory()
        {
        //    
            Console.WriteLine("从前有座山");
            Console.WriteLine("山里有座庙");
            Console.WriteLine("庙里有个老和尚和小和尚");
            Console.WriteLine("有一天,小和尚哭了,老和尚给小和尚讲了一个故事");
            i++;
            if(i>=10)
            {
                return;
            }
            TellStory();
        }
    }
}
