using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09结构
{
    public struct Person
    {
        public string _Name;//字段，存储数据，在这一方面和变量是相同的，但是，变量只能存储一个值
        public int _Age;//而字段可以存储多个值
        public Gender _Gender;
    }
    public struct MyColor
    {
        public int _red;
        public int _green;
        public int _blue;
    }
    public enum Gender
    {
        男,
        女,
    }
    class Program
    {

        static void Main(string[] args)
        {
            //xx大学管理系统
            //姓名，性别，年龄，年级  //5000  20000
            //string zsName = "张三";
            //int zsAge = 21;
            //char zsGender = '男';
            //int zsGrade = 3;
            //结构：可以帮助我们一次性声明多个不同类型的变量
            //语法：
            //【public】 struct 结构名
            //{
            //      成员；//字段
            //}

            //Person zsPerson;
            //zsPerson._Name = "张三";
            //zsPerson._Age = 21;
            //zsPerson._Gender = Gender.男;

            //Person lsPerson;
            //lsPerson._Name = "李四";
            //lsPerson._Age = 22;
            //lsPerson._Gender = Gender.女;

            //定义一个结构叫MyColor,有三个成员，分别定义为int类型的red，green，blue
            //声明一个MyColor类型的变量，并对其成员赋值，使MyColor可以表示成一个红色
            MyColor mc;
            mc._red = 255;
            mc._green = 0;
            mc._blue = 0;

            //定义一个结构类型Person，有三个成员，分别为姓名，年龄，性别用枚举类型
            //声明两个Person类型的变量，分别表示 张三 男 18岁/小兰 女 16岁
            Person zsPerson;
            zsPerson._Name = "张三";
            zsPerson._Gender = Gender.男;
            zsPerson._Age = 18;

        }
    }
}
