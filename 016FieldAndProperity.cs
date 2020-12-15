using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _017Filed_property
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            ●Field:一种与对象或类型(类与结构体)关联的变量:表示的是一块空间:数据存放空间
            ●字段是类型的成员,旧称成员变量
            ●与对象关联的字段也称实例字段:表示对象当前的某种状态
            ●静态字段:static
            ●尽管字段声明带有分号,但他不是语句
            ●字段的名字:一定是名词
            ●字段的初始值:
                ●无显示初始化时,字段获得其类型的默认值,所以字段永远的都不会未被初始化
                ●实例字段初始化的时机---对象创建时
                ●静态字段初始化的时机---类型被加载(load)时.
            ●只读字段
                ●实例只读字段
                ●静态只读字段
            

            ●属性:
                ●什么是属性:
                    ●属性是一种用于访问对象或类型的特征的成员,特征反应了状态
                    ●属性是字段的自然扩展
                        ●从命名上看,field更偏向于实例对象在内存中的布局,property更偏向于反映现实世界对象
                        ●对外:暴露数据,数据可以是存储在字段里的,也可以是动态计算出来的.
                        ●对内:保护字段不被非法值污染
                    ●属性由Get/Set方法对进化而来
                    ●又一个"语法糖"
                ●属性的声明
                    ●完整声明------后台(back)成员变量与访问器(注意使用code snippet和refactor工具)
                    ●简略声明------只有访问器(查看IL代码)
                    ●动态计算值的属性
                    ●注意实例属性和静态属性
                    ●属性的名字一定是名词
                    ●只读属性------只有getter没有setter
                        ●尽管语法上正确,几乎没有人使用"只写"属性,因为属性的目的是通过向外暴露数据而表示对象/类型的状态.


          
            */
            //Student stu1 = new Student();
            //stu1.Age = 40;
            //stu1.Score = 90;

            //Student stu2 = new Student();
            //stu2.Age = 24;
            //stu2.Score = 60;

            //List<Student> stuList = new List<Student>();
            //for (int i = 0; i < 100; i++)
            //{
            //    Student stu = new Student(1);
            //    stu.Age = 24;
            //    stu.Score = i;
            //    stuList.Add(stu);
            //}

            //int totalAge = 0;
            //int totalScore = 0;
            //foreach (var item in stuList)
            //{
            //    totalAge += item.Age;
            //    totalScore += item.Score;
            //}

            //Student.AverageAge = totalAge / Student.Amount;
            //Student.AverageScore = totalScore / Student.Amount;

            //Student.ReportAmount();
            //Student.ReportAverageAge();
            //Student.ReportAverageScore();

            //Console.WriteLine(Brush.DefaultColor.Red);
            //Console.WriteLine(Brush.DefaultColor.Blue);
            //Console.WriteLine(Brush.DefaultColor.Green);


            try
            {
                Student stu1 = new Student(1);
                //stu1.SetAge(20);
                stu1.Age = 20;
                Student stu2 = new Student(1);
                //stu2.SetAge(20);
                stu2.Age = 20;
                Student stu3 = new Student(1);
                //stu3.SetAge(200);
                stu3.Age = 20;
                //int avgAge = (stu1.GetAge() + stu2.GetAge() + stu3.GetAge()) / 3;
                int avgAge = (stu1.Age + stu2.Age + stu3.Age) / 3;
                Console.WriteLine(avgAge);

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
    class Student
    {
        private int age = 0;

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value >= 0 && value <= 120)
                {
                    this.age = value;
                }
                else
                {
                    throw new Exception("Age value has error");
                }
            }
        }

        public int GetAge()
        {
            return this.age;
        }
        public void SetAge(int value)
        {
            if (value >= 0 && value <= 120)
            {
                this.age = value;
            }
            else
            {
                throw new Exception("Age value has error");
            }
        }
        public int Score = 0;
        public readonly int ID;

        public static int AverageAge;
        public static int AverageScore;
        public static int Amount;

        public Student(int ID)
        {
            //Student.Amount++;
            this.ID = ID;
        }
        //static Student()
        //{

        //}

        public static void ReportAmount()
        {
            Console.WriteLine(Student.Amount);
        }

        public static void ReportAverageAge()
        {
            Console.WriteLine(Student.AverageAge);
        }

        public static void ReportAverageScore()
        {
            Console.WriteLine(Student.AverageScore);
        }

        public bool CanWork
        {
            get
            {
                if (this.age >=16)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }

    struct Color
    {
        public int Red;
        public int Green;
        public int Blue;
    }

    class Brush
    {
        public static readonly Color DefaultColor;//= new Color() { Red = 0, Green = 0, Blue = 0 };
        static Brush()
        {
            Brush.DefaultColor = new Color() { Red = 0, Green = 0, Blue = 0 };
        }

    }

}
