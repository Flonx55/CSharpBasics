using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43继承
{
    class Student : Person
    {
        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }

        }
        public Student(string name, int age, char gender, int id)
            : base(name, age, gender)
        {
            //this.Name = name;
            //this.Age = age;
            //this.Gender = gender;
            this.Id = id;
        }

    }
}
