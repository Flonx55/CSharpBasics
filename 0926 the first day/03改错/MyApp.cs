using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03改错
{
    public class MyApp
    {
        static void Main()
        {
            Car car1 = new Car()
            {
                doorN = 2,
                color = 0,
                speed = 100
            };
            Car car2 = new Car
            {
                doorN = 4,
                color = 1,
                speed = 80
            };
            Furniture f = new Furniture("aaa","001",1.2);
            Console.WriteLine(f.CalcSalesTax(1));//传参
            Console.WriteLine(Furniture.salesTax);//private不能访问,改public
            f.PurchPrice = 10;//赋值--字段private 添加属性--only set();
            string str = f.MyVendor;//取值--only get()




        }
    }
}
