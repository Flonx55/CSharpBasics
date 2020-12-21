using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06程序清单6_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(50);
            Account acc2 = new Account(100);
            acc2 = new Account(200);
            
            
        }
    }
    public class Account
    {
        private string _id;
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        private decimal _money;
        public decimal Money
        {
            get { return _money; }
            set { _money = value; }
        }

        private static int _objects = 0;
        private static int _classes = 0;

        public Account (decimal money)
        {
            Money = money;
            _objects++;
            Console.WriteLine("对象数量:"+_objects );
            _id = _objects.ToString();
        }

        ~Account ()
        {
            _objects--;
            Console.WriteLine("对象数量:"+_objects );
            Console.ReadKey();



        }
        //与教材的区别是Main函数末尾的Console.ReadKey()的有无  该代码不打印_objects--效果;
        //如若去掉,程序快速退出  如若在析构函数末尾加上Console.ReadKey();
        //~Account()只执行一次(对象数量:2 (3-1) ),界面停留几秒自动关闭(释放资源的影响 ? )
        //,无法再执行下去使_objects=1
        static  Account ()
        {
            _classes++;
            Console.WriteLine("类数量:"+_classes );
        }
    }
}
