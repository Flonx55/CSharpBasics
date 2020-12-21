using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _78密封类
{
    class Program
    {
        static void Main(string[] args)
        {
            //sealed:不能够被其他类继承,但是可以继承其他类
        }
    }
    public sealed class Person:Test
    {

    }
    public class Test
    {

    }
}
