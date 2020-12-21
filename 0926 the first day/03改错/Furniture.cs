using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03改错
{

    public class Furniture
    {
        public const double salesTax = .065;
        private double _purchPrice;//添加_
        public double PurchPrice
        {
            set { _purchPrice = value; }//可被赋值
        }
        private string _vendor, _inventoryID;
        public Furniture(string vendor, string inventID, double purchPrice)
        {
            this._vendor = vendor;
            this._inventoryID = inventID;
            this._purchPrice = purchPrice;
        }
        public string MyVendor
        {
            get { return _vendor; }
        }
        public double CalcSalesTax(double salePrice)
        {
            return salePrice * salesTax;
        }


    }

}
