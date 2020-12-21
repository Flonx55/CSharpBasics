using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _100委托
{

    public delegate void GreetingDelegate(string name);
    class Program
    {
        //public enum Language
        //{
        //    English,Chinese
        //}
        static void Main(string[] args)
        {
            //GreetPeople("Jimmy Zhang", EnglishGreeting);
            //GreetPeople("张子扬",ChineseGreeting);

            //string name1 = "Jimmy Zhang";
            //string name2 = "张子扬";
            //GreetPeople(name1, EnglishGreeting);
            //GreetPeople(name2, ChineseGreeting);

            //GreetingDelegate delegate1, delegate2;
            //delegate1 = EnglishGreeting;
            //delegate2 = ChineseGreeting;
            //GreetPeople("Jimmy Zhang", delegate1);
            //GreetPeople("张子扬",delegate2);

            //GreetingDelegate delegate1;
            //delegate1 = EnglishGreeting;//先给委托类型的变量赋值
            //delegate1 += ChineseGreeting;//给此委托变量再绑定一个方法
            //GreetPeople("Jimmy Zhang",delegate1);

            //实际上,我们也可以绕过GreetPeople方法,通过委托来直接调用EnglishGreeting和ChineseGreeting

            //GreetingDelegate delegate1;
            //delegate1 = EnglishGreeting;
            //delegate1 += ChineseGreeting;

            ////先后调用EnglishGreeting与ChineseGreeting方法
            //delegate1("Jimmy Zhang");


            //GreetingDelegate delegate1 = new GreetingDelegate(EnglishGreeting);
            //delegate1 += ChineseGreeting;//如果第一次就是用"+=",将出现使用了未赋值的局部变量的编译错误

            //GreetingDelegate delegate1 = new GreetingDelegate();
            //delegate1 += EnglishGreeting;
            //delegate1 += ChineseGreeting;//错误

            //Heater ht = new Heater();
            //ht.BoilWater();

            Heater heater = new Heater();
            Alarm alarm = new Alarm();
            heater.BoilEvent += alarm.MakeAlert;//注册方法
            heater.BoilEvent += (new Alarm()).MakeAlert;//给匿名对象注册方法
            heater.BoilEvent += Display.ShowMsg;    //注册静态方法
            heater.BoilWater();
            Console.ReadKey();
        }
        public static void GreetPeople(string name,GreetingDelegate MakeGreeting)
        {
            //做些额外的事情，比如初始化之类

            //switch(lang)
            //{
            //    case Language.English:
            //        EnglishGreeting(name);
            //        break;
            //    case Language.Chinese:
            //        ChineseGreeting(name);
            //        break;
            //}
            //EnglishGreeting(name);


            

            MakeGreeting(name);
        }
        public static void EnglishGreeting(string name)
        {
            Console.WriteLine("Moring," + name);
        }
        public static void ChineseGreeting(string name)
        {
            Console.WriteLine("早上好，"+name);
        }
        
        /*summary

            委托是一个类，它定义了方法的类型，使得可以将方法当作另一个方法的参数来进行传递，这种将方法动态的赋给参数的做法，可以避免
        在程序中大量使用if-else（switch）语句，同时使程序具有更好的可拓展性

            委托不同于string的一个特性:可以将多个方法绑定到同一个委托,当调用这个委托的时候,将依次调用其所绑定的方法


            声明委托的目的就是为了把他暴露在类的客户端进行方法的注册，若把他声明为private了，客户端对他不可见
            但如果把delegate1声明为public，在客户端可以对他进行随意的赋值等操作，严重破坏对象的封装性

            声明一个事件只不过类似于声明一个进行了封装的委托类型的变量而已
        */

    }
    //热水器
    public class Heater
    {
        private int temperature;//水温
        public delegate void BoilHander(int param);//声明委托
        public event BoilHander BoilEvent;//声明事件
        public void BoilWater()//烧水
        {
            for (int i = 0; i < 100; i++)
            {
                temperature = i;
                //if (temperature >95)
                //{
                //    MakeAlert(temperature);
                //    ShowMsg(temperature);
                //}//它们来自于不同厂商并进行了组装,那么,;应该是热水器仅仅负责烧水,它不能发出警报也不能显示水温,在水烧开时由警报器发出警报
                //显示器显示提示和水温
                if (temperature >95)
                {
                    if (BoilEvent !=null)//如果有对象注册
                    {
                        BoilEvent(temperature);//调用所有注册对象的方法
                    }
                }
            }
        }
    
        
//警报器
    }
    public class Alarm
    {
        public void MakeAlert(int param)//发出语音警报
        {
            Console.WriteLine("Alarm:嘀嘀嘀，水已经{0}度了", param);
        }
    }
//显示器
    public class Display
    {
        public static void ShowMsg(int param)//显示水温
        {
            Console.WriteLine("显示:水快开了,当前温度:{0}度", param);
        }

    }


    /*
    observer设计模式
        1)Subject:监视对象,它往往包含着其他对象所感兴趣的内容.在本范例中,热水器就是一个监视对象,它包含的其他对象所感兴趣的内容
          ,就是temperature字段,当这个字段的值快到100时,会不断把数据发给监视它的对象
        2)Observer:监视者,它监视Subject,当Subject中的某件事发生的时候,会告知Observer,而Observer则会采取相应的行动.
          在本范例中,Observer有警报器和显示器,它们采取的行动分别是发出警报和显示水温

        Observer设计模式是为了定义对象间的一种一对多的依赖关系,以便于当一个对象的状态改变时,其他依赖于它的对象会被自动告知
        并更新.Obeserver模式是以一种松耦合的设计模式

    在本实例中,事情发生的顺序:
        1)警报器和显示器告诉热水器,他对他的温度比较感兴趣(注册)
        2)热水器知道后保留对警报器和显示器的引用
        3)热水器进行烧水这一动作,当水温超过95度时,通过对警报器和显示器的引用,自动调用警报器的MakeAlert()方法,显示器的ShowMsg()方法
    */
}
