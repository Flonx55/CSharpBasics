using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            ●什么是委托
                ●委托是函数指针的"升级版"
                    ●实例:c/c++中的函数指针
                ●一切皆地址
                    ●变量(数据)是以某个地址为起点的一段内存中所存储的值
                    ●函数(算法)是以某个地址为起点的一段内存中所存储的一组机器语言指令
                ●直接调用与间接调用
                    ●直接调用:通过函数名来调用函数,CPU通过函数名直接获得函数所在地址并开始执行-->返回
                    ●间接调用:通过函数指针来调用函数,CPU通过读取函数指针存储的值获得函数所在地址并开始执行-->返回
                ●java中没有与委托相对应的功能实体
                ●委托的简单使用
                    ●Action委托
                    ●Func委托

            ●委托的声明
                ●委托是一种类(class),类是数据类型所以委托也是一种数据类型
                ●它的声明方式与一般的类不同,主要是为了照顾可读性和c/c++传统
                ●注意声明委托的位置
                    ●避免写错地方结果声明成嵌套类型
                ●委托与所封装的方法必须"类型兼容"
                    ●返回值的数据类型一致
                    ●参数列表在个数和数据类型上一致(参数名不需要一样)

            ●委托的一般使用
                ●实例:把方法当做参数传给另一个方法
                    ●正确使用1:模板方法,"借用"指定的外部方法来产生结果
                        ●相当于"填空题"
                        ●常位于代码中部
                        ●委托有返回值
                        ●有复用的功效:提高效率
                    ●正确使用2:回调(callback)方法,调用指定的外部方法
                        ●相当于"流水线"
                        ●常位于代码末尾
                        ●委托无返回值
                ●注意:难精通+易使用+功能强大的东西,一旦被滥用,后果非常严重
                    ●这是一种方法级别的紧耦合,现实生活中要慎之又慎
                    ●使可读性下降,debug难度增加
                    ●把委托回调,异步调用和多线程纠缠在一起,会让代码变得难以阅读和维护
                    ●委托使用不当有可能造成内存泄露和程序性能下降
                
            ●委托的高级使用
                ●多播(multicast)委托
                ●隐式异步调用
                    ●同步与异步的简介
                        ●中英文的语言差异
                        ●同步:你做完了我(在你的基础上做)接着做
                        ●异步:咱们两个同时做(相当于汉语的同步进行)
                    ●同步调用与异步调用的对比
                        ●每一个运行的程序都是一个进程(process)
                        ●每个进程可以有一个或多个线程(thread)
                        ●同步调用是在同一线程内
                        ●异步调用的底层机理是多线程
                        ●串行==同步==单线程,并行==异步==多线程

            ●应该适时地使用接口interface取代一些对委托的使用

                        


            */
            Calculator calculator = new Calculator();
            Action action = new Action(calculator.Report);
            calculator.Report();//直接调用
            action.Invoke();//间接调用
            action();//间接调用的简写

            Func<int, int, int> func1 = new Func<int, int, int>(calculator.Add);
            Func<int, int, int> func2 = new Func<int, int, int>(calculator.Sub);

            int x = 100;
            int y = 200;
            int z = 0;

            //z = func1.Invoke(x, y);
            z = func1(x, y);
            Console.WriteLine(z);
            z = func2.Invoke(x, y);
            Console.WriteLine(z);

        }
    }
    class Calculator
    {
        public void Report()
        {
            Console.WriteLine("I have 3 methods:");
        }
        public int Add(int a ,int b)
        {
            int result = a + b;
            return result;
        }
        public int Sub(int a,int b)
        {
            int result = a - b;
            return result;
        }
        
    }
}
