using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36复习
{
    class Program
    {
        static void Main(string[] args)
        {
            Person zsPerson = new Person("张三",18,'男');
            zsPerson.SayHello();
            Person.SayHelloTwo();
            Console.ReadKey();
        }
    }
}
