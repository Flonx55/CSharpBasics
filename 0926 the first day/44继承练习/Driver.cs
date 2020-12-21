using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44继承练习
{
    class Driver:Person
    {
        private int _drivetime;
        public int Drivetime
        {
            get { return _drivetime; }
            set { _drivetime = value; }
        }
        public void DriverSayHello()
        {
            Console.WriteLine("大家好,我是一名{0},我的年龄是{1},我是{2}生,我的驾龄是{3}",this.Name ,this.Age ,this.Gender ,this.Drivetime );
        }
        public Driver(string name,int age,char gender,int drivetime):base(name,age,gender)
        {
            Drivetime = drivetime;
        }
    }
}
