using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017IndexerAndConstant
{
    class Program
    {
        static void Main(string[] args)
        {
            Student stu = new Student();
            stu["Math"] = 90;
            stu["Math"] = 100;
            var mathScore = stu["Math"];
            Console.WriteLine(mathScore);
        }
    }
    class Student
    {
        private Dictionary<string, int> scoreDictionary = new Dictionary<string, int>();
        //声明一个Dictionary类型的变量,存储string类型和int类型的参数
        
        public int? this[string subject]//创建一个返回int类型并且可以接受null的索引函数
        {
            get {
                if (this.scoreDictionary.ContainsKey(subject))
                {
                    return this.scoreDictionary[subject];
                }
                else
                {
                    return null;
                }
                }
            set
            {
                if (value.HasValue==false)
                {
                    throw new Exception("Score cannot be null");
                }
                if (this.scoreDictionary.ContainsKey(subject))
                {
                    this.scoreDictionary[subject] = value.Value;
                }
                else
                {
                    this.scoreDictionary.Add(subject, value.Value);
                }
            }
        }
    }
    /*
        什么是常量
            ●常量(constant)用来表示常量值,(即,可以在编译时计算的值)的类成员
            ●常量隶属于类型而不是对象,即没有"实例常量"
                    "实例常量"的角色通常由只读字段来担当

            ●注意区分成员常量与局部常量

            常量的声明
            各种"只读"的应用场景
                ●为了提高程序的可读性和执行效率---常量
                ●为了防止对象的值被改变-------只读字段
                ●向外暴露不允许修改的数据----只读属性(静态或非静态),功能与常量有一些重叠
                ●当希望成为常量的值其类型不能被常量声明接受时(类/自定义结构体)----静态只读字段

    */
    class WASPEC
    {
        public const string WebsiteURL = "http://www.WASPEC.org";
    }
}
