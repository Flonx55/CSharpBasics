using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32复习
{
    class Person
    {
        //字段,属性,方法
        //字段:存储数据
        //属性:保护 限制字段的取值 赋值
        //方法:描述对象的行为
        string _name;
        public string Name
        {
            get { return _name; }//取值
            set { _name = value; }//赋值
        }
        int _age;
        public int Age
        {
            get { return _age; }
            set {
                if(value <0||value>100)
                {
                    value = 0;
                }
                _age = value; }
        }
        char _gender;
        public char Gender
        {
            get {
                if(_gender!='男'&&_gender != '女')
                {
                    return _gender  = '男';
                }
                    return _gender; }
            //set()里面判断value的值
            //get()里面判断字段的值
            set { _gender = value; }
        }
        public void SayHello()
        {
            Console.WriteLine("我叫{0},我今年{1}岁了,我是{2}生",this.Name,this.Age,this.Gender);
            //this:当前这个类的对象
            //凡是跟外界打交道,用属性去打交道
        }
    }
}
