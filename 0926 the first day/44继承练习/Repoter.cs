using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44继承练习
{
    class Repoter:Person 
    {
        private string _hobby;
        public string Hobby
        {
            get { return _hobby; }
            set { _hobby = value; }
        }

        private string _job;
        public string Job
        {
            get { return _job; }
            set { _job = value; }
        }
        public void ReporterSayhello()
        {
            Console.WriteLine("大家好,我是一名{0},我的爱好是{1},我的年龄是{2},我性别是{3}",this.Name ,this.Hobby ,this.Age ,this.Gender );
        }

        public Repoter (string name,string hobby,int age,char gender):base(name,age,gender)
        {
            Hobby = hobby;
            
        }
    }
}
