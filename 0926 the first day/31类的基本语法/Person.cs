using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31类的基本语法
{
    public class Person
    {
        private string _name;
        //private:只能在当前类的内部访问
        public string Name
        {
            //当你输出属性的值的时候,会执行get方法
            get { return _name; }//控制取值
            //当你给属性赋值的时候,首先会执行set方法
            set { _name = value; }//控制赋值
        }


        //属性的作用就是保护字段,对字段的赋值和取值进行限定
        //属性(Property)的本质就是两个方法,一个get,一个set
        //既有set()也有get()我们称之为可读可写属性
        //知有get()没有set()我们称之为只读属性
        //只有set()没有get()我们称之为只写属性
        private int _age;
        public int Age
        {
            get { return _age; }
            set {
                if(value < 0||value >100)
                {
                    value = 0;
                }
                _age = value; }
        }
        private char _gender;
        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        //字段(Fields)
        //字段就是女人;属性就是男人
        

        public void CHLSS()
        {
            Console.WriteLine("我叫{0},我今年{1}岁了,我是{2}生,我可以吃喝拉撒睡哦",this._name,this._age,this._gender );
        }
        //方法(Methods)


    }
    //写好了一个类之后,我们需要创建这个类的对象
    //那么,我们管创建这个类的对象过程称之为类的实例化
    //使用关键字 new.
    //this:表示当前这个类的对象
    //类是不占内存的,而对象是占内存的
}
