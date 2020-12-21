using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05程序清单6_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account("001", "8888");
            acc1.Deposit(800);
            Console.WriteLine("余额{0}",acc1.Money );
            Console.ReadKey();
        }
    }
    public class Account
    {
        private string _id;
        public string Id
        {
            get { return _id; }
        }
        private string _password;
        private decimal _money;
        public decimal Money
        {
            get {
                Console.Write("请输入密码：");
                if(Console.ReadLine() != _password )
                {
                    Console.WriteLine("密码错误");
                    return 0;
                }
                else
                {
                    return _money;
                }
            }
        }
        
        public Account(string s,string p)
        {
            _id = s;
            _password = p;
            

        }
        public void Deposit(decimal x)
        {
            _money += x;
        }

    }
}
