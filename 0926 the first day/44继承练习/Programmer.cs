using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44继承练习
{
    class Programmer:Person 
    {
        private int _worktime;
        public int Worktime
        {
            get { return _worktime; }
            set { _worktime = value; }
        }
        public void ProgrammerSayhello()
        {
            Console.WriteLine("大家好,我是一名{0},今年{1}岁了,我是{2}生,我已经工作了{3}年",this.Name ,this.Age,this.Gender,this.Worktime );
        }

        public Programmer(string name,int age,char gender,int worktime):base(name,age,gender)
        {
            Worktime = worktime;
        }
    }
}
