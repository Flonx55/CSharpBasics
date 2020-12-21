using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01绪论
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            计算机系统的组成：
                1）应用软件
                2）操作系统
                3)硬件

            结构化程序设计-->面向对象的程序设计
            桌面应用-->网络应用-->Internet应用

                命名空间就像在文件系统中一个文件夹容纳多个文件一样,可以看作某些类的一个容器.
            通过把类放入命名空间可以把相关的类组织起来,并且可以避免命名冲突.命名空间既用作程序的"内部"组织
            系统,也用作"外部"组织系统(一种向其他程序公开自己拥有的程序元素的方法)
                使用命名空间:using
                类似#include
                System.Drawing---处理图形和绘图,包括打印
                System.Data------处理数据存取和管理,在定义ADO.NET技术中扮演重要角色
                System.IO--------管理对文件和流的同步和异步访问
                System.Windows---处理基于窗体的窗口的创建
                System.Reflection包含从程序集读取元数据的类
                System.Thereading包含用于多线程编程的类
                System.Collections包含定义各种对象集的接口和类


           Main方法
                1)static表示Main方法是一个全局方法
                2)void表示Main方法没有任何返回值,即返回值是空
                3)参数放在小括号中定义.此处括号内没有内容,表示Main方法没有任何参数

            语句
                1)在C#中要执行的指令
                2)语句间用;分隔,编译器通过分号来区分多个语句
                3)使用大括号{}标识某个代码块的开始和结束,从而可以对语句进行组合.大括号必须成对匹配

            C#程序的基本结构
                1)源程序组织:命名空间
                2)物理程序组织:程序集
                    ·可执行文件exe
                    ·动态链接dll
                3)引用外部程序集
                    c#编译器:/reference
                    visual Studio:项目-->添加引用

            */
        }
    }
}
