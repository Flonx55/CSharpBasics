using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace _018ArgumentAndParameter
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            ●传值参数(值参数)
                ●值参数创建变量的副本
                ●对值参数的操作永远不影响变量的值
            ●输出参数
                ●输出参数并不创建变量的副本
                ●方法体内必须要有对输出变量的赋值操作,不要求在外面赋值.原因就是其副作用:在方法体里反正都要修改其值将其输出
                  ,只需要在方法体里执行操作之前赋值就可以了
                ●使用out修饰符显示指出-------此方法的副作用是通过参数向外输出值.
            ●引用参数
                ●使用了ref关键字修饰的引用参数
                ●与值形参不同,引用形参并不创建新的存储位置.相反,引用形参表示的存储位置恰是在方法调用中作为实参给出的那个变量所表示的存储位置.
                ●引用参数并不创建变量的副本
                ●使用ref修饰符显示指出---此方法的副作用是改变实际参数的值
            ●数组参数
                ●必须是形参列表中的最后一个,由params修饰
                ●举例:String.Format方法和String.Split方法
            ●具名参数
                ●参数的位置不再受约束
                ●提高我们代码的可读性
                ●还可以不按顺序传入
                ●严格来说,不是参数的种类,而是参数的使用方法
            ●可选参数
                ●参数因为具有默认值而变得"可选"
                ●不推荐使用可选参数
            ●扩展方法(this参数)
                ●当我们无法对一个类型的源码进行修改的时候,可以使用扩展方法,为这种目标数据类型来追加方法
                ●方法必须是公有静态的,即被public static修饰
                ●必须是形参列表中的第一个,由this修饰
                ●必须由一个静态类(一般类名为SomeTypeExtension)来统一收纳对SomeType类型的拓展方法
                ●举例:LINQ方法(语言集成查询)
                
            
            */
            //Student stu = new Student();
            //int y = 100;
            //stu.AddOne(y);
            //Console.WriteLine(y);

            //Student lodStu = new Student() { Name = "Tim"};
            //SomeMethod(lodStu);
            //Console.WriteLine("{0},{1}", lodStu.GetHashCode(), lodStu.Name);

            //Student stu = new Student() { Name = "Tim" };
            //UpdateObject(stu);
            //Console.WriteLine("HashCode = {0},Name = {1}",stu.GetHashCode(),stu.Name);


            //int y = 1;
            //IWantSideEffect(ref y);//要求要写关键字,就是提醒我们明明白白地,显示地,需要这个副作用
            //Console.WriteLine(y);

            //Student outterStu = new Student() { Name = "Tim" };
            //IWantSideEffect(ref outterStu);
            //Console.WriteLine("HashCode = {0},Name = {1}", outterStu.GetHashCode(), outterStu.Name);


            //Console.WriteLine("Please input first number:");
            //string arg1 = Console.ReadLine();
            //double x = 0;
            //bool b1 =  double.TryParse(arg1, out x);
            //if (b1==false)
            //{
            //    Console.WriteLine("Input error!");
            //    return;
            //}
            //Console.WriteLine("Please input second number");
            //string arg2 = Console.ReadLine();
            //double y = 0;
            //bool b2 = double.TryParse(arg2, out y);
            //if (b2 == false)
            //{
            //    Console.WriteLine("Input error!");
            //    return;
            //}
            //double z = x + y;
            //Console.WriteLine("{0}+{1}={2}",x,y,z);


            //double x = 100;
            //bool b = DoubleParser.TryParse("ABC", out x);
            //if (b==true)
            //{
            //    Console.WriteLine(x+1);
            //}
            //else
            //{
            //    Console.WriteLine(x);
            //}


            //Student stu = null;
            //bool b = StudentFactory.Create("Tim", 34, out stu);
            //if (b==true)
            //{
            //    Console.WriteLine("Student {0},age is {1}",stu.Name,stu.Age);
            //}


            //int result = CalculateSum(1,2,3);
            //Console.WriteLine(result);

            //int x = 100;
            //int y = 200;
            //int z = x + y;
            //Console.WriteLine("{0}+{1}={2}",x,y,z);

            //string str = "Tim;Tom;Array;Lisa";
            //string[] result = str.Split(';', '.', ',');
            //foreach (var name in result)
            //{
            //    Console.WriteLine(name);


            //PrintInfo("Tim", 34);//不具名调用
            //PrintInfo(name: "Tim", age: 34);//具名调用

            //PrintInfo1();


            //double x = 3.1415926;
            ////double y = Math.Round(x, 4);
            //double y = x.Round(4);
            //Console.WriteLine(y);



            List<int> myList = new List<int>() { 11, 12, 9, 14, 15 };
            //bool result = AllGreaterThanTen(myList);
            bool result = myList.All(i => i > 10);//All是一个扩展方法
            Console.WriteLine(result);


        }


        static void SomeMethod(Student stu)
        {
            stu = new Student() { Name = "Tom" };
            Console.WriteLine("{0},{1}", stu.GetHashCode(), stu.Name);
        }
        static void UpdateObject(Student stu)
        {
            stu.Name = "Tom";//副作用 side-effect
            Console.WriteLine("HashCode = {0},Name = {1}", stu.GetHashCode(), stu.Name);
        }
        static void IWantSideEffect(ref int x)
        {
            x = x + 100;
        }
        static void IWantSideEffect(ref Student stu)
        {
            stu = new Student() { Name = "Tom" };
            Console.WriteLine("HashCode = {0},Name = {1}", stu.GetHashCode(), stu.Name);
        }
        static int CalculateSum(params int[] intArray)
        {
            int sum = 0;
            foreach (var item in intArray)
            {
                sum += item;
            }

            return sum;
        }
        static void PrintInfo(string name, int age)
        {
            Console.WriteLine("Hello {0},you are {1}", name, age);
        }
        static void PrintInfo1(string name = "Flonx", int age = 18)
        {
            Console.WriteLine("Hello {0},you are {1}", name, age);
        }
        static bool AllGreaterThanTen(List<int> intList)
        {
            foreach (var item in intList)
            {
                if (item<10)
                {
                    return false;
                }

            }
            return true;
            
        }
    }

    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void AddOne(int x)
        {
            x = x + 1;
            Console.WriteLine(x);
        }
    }
    class StudentFactory
    {
        public static bool Create(string stuName, int stuAge, out Student result)
        {
            result = null;
            if (string.IsNullOrEmpty(stuName))
            {
                return false;
            }

            if (stuAge < 20 || stuAge > 80)
            {
                return false;
            }

            result = new Student() { Name = stuName, Age = stuAge };
            return true;
        }
    }//介绍out返回引用类型的多个参数

    class DoubleParser
    {
        public static bool TryParse(string input, out double result)
        {
            try
            {
                result = double.Parse(input);
                return true;
            }
            catch
            {
                result = 0;
                return false;
            }
        }
    }

    static class DoubleExtension
    {
        public static double Round(this double input,int digits)
        {
            double result = Math.Round(input, digits);
            return result;
        }
    }
        
    
}
