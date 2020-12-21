using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08枚举
{ 

    //public enum Gender
    //{
    //    男,
    //    女,
    //}

    //声明了一个枚举，Gender
    //变量类型 变量名 = 值

    //将枚举声明到命名空间的下面，类的外面，表示这个命名空间的下面，所有的类都可以使用这个枚举


    //public enum Season
    //{
    //    春,
    //    夏,
    //    秋,
    //    冬,
    //}
    //public enum QQstate
    //{
    //    Online,
    //    Offline,
    //    Leave,
    //    Busy,
    //    Qme,
    //}
    public enum QQState
    {
        OnLine=1,
        OffLine,
        Leave,
        Busy,
        QMe,
    }
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //Season s = Season.冬;
    //        //QQstate state = QQstate.Busy;

    //        //Gender gender = Gender.男;

    //        //枚举语法：
    //        //【public】 enum 枚举名//public可以省略
    //        //{

    //        //  值1，
    //        //  值2，
    //        //  值3，
    //        //   ……
    //        //}
    //        //public：访问修饰符，公开的公共的，哪都可以访问，
    //        //enum：关键字，声明枚举的关键字
    //        //枚举名：要符合pascal命名规范
    //        //为什么会有枚举这个东西
    //        //**大学管理系统
    //        //姓名 年龄 性别 系别 年级
    //        //性别
    //        //char gender = '男';
    //        //string s1 = "female";
    //        //string ss1 = "爷们";
    //        //规范我们的开发
            
    //        //枚举就是一个简单的变量类型，int double decimal string 
    //        //只是枚举声明 赋值 使用的方式跟那些普通的变量类型不一样


    //        //枚举和int以及string类型之间的转换

         
    //    }
    //}
    public enum Gender
    {
        男,
        女,
    }
    class Program
    {
        static void Main(string[] args)

        {
            #region 将枚举类型强转成int类型
            //QQState state = QQState.OnLine;
            ////枚举类型默认可以跟int类型互相转换，枚举类型跟int类型是兼容的
            //int n = (int)state;
            //Console.WriteLine(n);
            //Console.WriteLine((int)QQState.OffLine);
            //Console.WriteLine((int)QQState.Leave);
            //Console.WriteLine((int)QQState.Busy);
            //Console.WriteLine((int)QQState.QMe);
            //Console.ReadKey();
            #endregion
            #region 将int类型强转为枚举类型
            //int n1 = 3;
            //QQState state = (QQState)n1;
            //Console.WriteLine(state);
            //Console.ReadKey();
            #endregion
            #region 将枚举类型转换为字符串类型
            //所有的类型都能够转换成string类型
            //调用tostring
            //double n1 = 3.14;
            //decimal n1 = 5000m;
            //string s = n1.ToString();
            //Console.WriteLine(s);
            //Console.ReadKey();

            //QQState state = QQState.OnLine;
            //string s = state.ToString();
            ////Console.WriteLine(state.ToString());
            //Console.WriteLine(s);
            //Console.ReadKey();
            #endregion
            #region 将字符串类型转换成枚举类型
            //string s = "0";
            ////将s转换成枚举类型
            //QQState state = (QQState) Enum.Parse(typeof(QQState), s);
            ////QQState state = (QQState)s;
            ////调用parse方法的目的就是为了让他帮助我们将一个字符串转换成对应的枚举类型
            //Console.WriteLine(state);
            //Console.ReadKey();
            //我们可以将一个枚举类型的变量跟int类型和string类型互相转换
            //枚举类型默认是跟int类型相互兼容的，所以可以通过强制类型转换的语法互相转换
            //当转换一个枚举中没有的值的时候，不会抛异常，而是直接将数字显示出来

            //枚举同样也可以跟string类型互相转换，如果将枚举类型转换成string类型，则直接调用ToString（）
            //如果将字符串转换成枚举类型则需要下面这样一行代码
            //（要转换的枚举类型）Enum.Parse(typeof(要转换的枚举类型),“要转换的字符串”)
            //如果要转换的字符串是数字，则就算枚举中没有，也会 不会抛异常
            //如果转换的字符串是文本，如果枚举中没有，则会抛出异常
            #endregion


            //枚举练习
            //提示用户选择一个在线状态，我们接受，并将用户的输入转换成枚举类型
            //再次打印到控制台中

            //Console.WriteLine("请选择您的qq状态1-OnLine 2-OffLine 3-Leave 4-Busy");
            //string input = Console.ReadLine();
            //switch(input)
            //{
            //    case "1":QQState s1 = (QQState)Enum.Parse(typeof(QQState), input);
            //        Console.WriteLine("您选择的在线状态是{0}",s1);
            //        break;
            //    case "2":QQState s2 = (QQState)Enum.Parse(typeof(QQState),input);
            //        Console.WriteLine("您选择的在线状态是{0}",s2);
            //        break;
            //    case "3":QQState s3 = (QQState)Enum.Parse(typeof(QQState),input);
            //        Console.WriteLine("您选择的在线状态是{0}",s3);
            //        break;
            //    case "4":QQState s4 = (QQState)Enum.Parse(typeof(QQState), input);
            //        Console.WriteLine("您选择的在线状态是{0}",s4);
            //        break;

            //}
            //Console.ReadKey();
        }
    }
    

    

}
