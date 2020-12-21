using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _37命名空间
{
    class Program
    {
        static void Main(string[] args)
        {
            //A-->projectA-->顾客类
            //B-->projectB-->顾客类
            //C-->projectC-->顾客类
            //可以解决类的重名问题
           
            List<int> list = new List<int>();
            
            //命名空间:可以认为类是属于命名空间的
            //如果在当前项目中没有这个类的命名空间，需要我们手动的导入这个类所在的命名空间
            //1，鼠标;2,alt+shift+F10
            //3，记住命名空间，手动的去引用

            //在一个项目中去引用另一个项目的类
            //1）添加引用
            //2）引用命名空间
        }
    }
}
