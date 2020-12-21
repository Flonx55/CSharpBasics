using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _79重写ToString方法
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Console.WriteLine(p.ToString ());
            Console.ReadKey();
        }
    }
    public class Person
    {
        public override string ToString()//虚方法
        {
            return "Hello World";
        }
    }

}
