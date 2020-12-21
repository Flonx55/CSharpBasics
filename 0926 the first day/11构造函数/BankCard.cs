using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11构造函数
{
    class BankCard
    {
        private string _id;
        private decimal _money;

        public BankCard()
        {
            _money = 10;
        }

        public BankCard (string s)
        {
            _id = s;
        }
    }
}
