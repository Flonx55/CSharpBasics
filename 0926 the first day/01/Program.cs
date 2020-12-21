using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01
{
    class Program
    {
        static void Main(string[] args)  //main function 
        {

            #region c#基本知识点

            // .net plaform ----------A kichen
            //.net平台  一个厨房
            // .net framework---------some materials and tools for cooking
            //.net框架  一些材料和工具,为了烹饪
            // applications-----------delicious foods
            //软件 美味的食物
            // .net platform----------China mobile internet platform
            //.net平台 中国移动互联网平台
            // CMIP------------------surf the internet, communication, playing games
            // CMIP------------------ - need some signal towers--provide a stabilized
            //                        circumstance to gaurantee the operation of CMIP
            // .net framework has the relationship with.net platform like the relation
            //                        between CMIP and signal towers
            //   .net framework consists of CLR(common language runtime) and.net class
            //libraries
            // c#--------------an language which can communicate with computers would 
            //                help us to translate
            // the usages of.net-----1 winform applications
            //                        2 Internet applications
            //                        3 moblie phone development
            //                        4 unity3D game development or virtual reality
            // two interactive models of.net:
            //   C/S:Client or Server
            //   B/S:Browser or Server
            // /*properties  属性
            //  *.cs  class file
            //  *the relationship of solution project class:
            //  * solution:company
            //  * project :department
            //  * class   :staff
            //  * reference namespace:
            //  *  JD---->shopping project---->consumer class
            //  *  TB---->shopping project---->consumer class
            //  *      

            //  * *  sln----solution files
            //  *  csproj------c sharp project-----project files

            //strings can be stored empty;
            //string可以存储空
            //char gender = 'sl';//it is wrong;
            //char a = '';//chars can not be stored empty;
            //char类型不可以存储空


            //Console.ReadKey();
            //let this routine suspend,wait user to press any key
            //and this key's letter will be revealed on the corresponding console
            //ctrl+shift+B ---build the solution
            //tools---->import and export Settings------restore facotry setting
            //virate virate virate 

            // int number;         //create a space which can store integers 开辟一块能存储整型的空间
            //assign values to variables  给整型变量赋值
            //number = 100;//this means 100 is stored in the space

            //int number1;//a variable of integer type is defined or declared
            //Console.WriteLine(number1);
            //Console.Read();//if your code appear red breakline,you should understand that something wrong 
            //regarding grammar
            //if your code appear green breakline,you just notice that something wrong may be 
            //happen,but it is just of possibility.it is the warning line
            //first-declared     second-use

            //naming scheme:
            //The first thing to make sure is that the name of the corresponding integer must be of meaning


            //two principles:
            //camel:damand that the integer's name's first letter must be lowercase and every other word
            //      must be uppercase.for instance:
            //  highSchoolStudent
            //To name for integers
            //Pascal:demand that every word's first letter must be uppercase and every letter word must be
            //      lowercase
            //To name for classes and methods

            //int Number_1 = 10;//N isn't n!! it's sensitive bettween 'a' n 'A';


            //Console.WriteLine("hello," + Number_1);//the usage of '+':1,link;2,addition
            //Console.WriteLine(5 + 5);
            //Console.WriteLine(5 + "5");
            //Console.WriteLine(5 + '5');

            //viriate:store data
            //placeholder:First dig a hole,then fill the hole;
            //overfilling doesn't work,
            //lessfilling cause an exception .


            //escape character:the sign of changing meanings is a '\'+a special sign 
            //\n:function is to wrapping lines
            //\":show double quotation marks
            //\b is of the function that escaping effect
            //\b:it is a backspace
            //\t: indicated as a space for the table key
            //@:1,cancel escape effect
            //  2,keep the original format

            //priority:multiply-divide>add and subtract,let's do the parentheses first,
            //the same level is calculated from left to right

            ////implicit type conversion:from small to big
            ////explicit type conversion:from big to small
            ////grammar:(the type to be converted)the value to be converted


            //Console.WriteLine("{0:0.00}",d);Two Places Behind The Decimal Point

            //convert a string to an int or a double
            //it is not compatible
            //under this circumstances
            //double d = Convert.ToDouble(s);//use a double to receive
            //int n = Convert.ToInt32(s);
            //Console.WriteLine(d);
            //Console.WriteLine(n);//using convert need a condition
            //123--OK;123abc--abnormal
            #endregion

            #region 无第三方变量使变量存储的值交换

            //int n1;//20
            //int n2;//10

            //n1 = int.Parse(Console.ReadLine());
            //n2 = int.Parse(Console.ReadLine());
            ////n1 = n1 - n2;//n1=-10;n2=20;    
            ////n2 = n1 + n2;//n1=-10;n2=10;
            ////n1 = n2 - n1;//n1=20;n2=10;

            //n1 = n1 - n2;//n1=-10;n2=20;    
            //n2 = n1 + n2;
            //n1 = n2 - n1;


            //Console.WriteLine("n1={0},n2={1}", n1, n2);
            //Console.ReadKey();


            #endregion

            #region 天数转化为周数加天数

            //int day = 46;
            //int weeks;
            //int remainder;
            //weeks = day / 7;
            //remainder = day % 7;
            //Console.WriteLine("the {0} week and {1} days", weeks, remainder);
            //Console.ReadKey();
            #endregion

            #region 秒数转化为天数,小时,分钟,秒数
            //int seconds = 107653;
            //int days = seconds / 86400;//get the day
            //int secs = seconds % 86400;//remanent seconds after getting the day's number
            //int hours = secs / 3600;   //get the hours
            //secs = secs % 3600;        //remanent seconds after getting the hour's number
            //int mins = secs / 60;      //get the minute
            //secs = secs % 60;
            //Console.WriteLine("{0}days,{1}hours,{2}minutes,{3}seconds", days, hours, mins, secs);
            //Console.ReadKey();
            #endregion

            #region 字符串转化为int double类型例题
            //Console.WriteLine("请输入一个整数字符串");
            //int i = Convert.ToInt32(Console.ReadLine());
            //int j = Int32.Parse(Console.ReadLine());
            //Int32.TryParse(Console.ReadLine(), out int m);
            //m = m + i + j;
            //Console.WriteLine(m);
            //Console.ReadKey();

            #endregion

            #region 提示用户输入一个数字然后打印它的两倍到控制台上
            //Console.WriteLine("请输入一个数字,我将打印它的两倍");
            //Int32.TryParse(Console.ReadLine(), out int i);
            //Console.WriteLine(i * 2);
            //Console.ReadKey();
            #endregion

            #region ++ -- 运算符

            //int i = 1;
            //i++;
            //Console.WriteLine(i);
            //Console.ReadKey();


            //int number = 10;
            //number++;

            //--number;
            //number--;
            //++number;  == number = number + 1;

            //int result = 10 + number++;
            //==int result = 10  number;
            //  number++;

            //int result = 10 + ++number;
            //==number++;
            //  int result = 10 + number;

            //Console.WriteLine(number);
            //Console.WriteLine(result);

            //distinction:if it is front ++,this variable will be added one firstly,then,the 
            //variable after being added would go to calculate
            //            if it is behind ++,this variable will go to calculate firstly,then 
            //it will be added one

            //int number = 10;
            //int result = 10 + --number;
            //Console.WriteLine(number);
            ////Console.WriteLine(result);

            //int a = 5;
            //int b = a++ + ++a * 2 + --a + a++;
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //unary operator:finishing a count only need one operand
            //binary operator:finishing a count needs two operands
            //priority:unary>binary



            //ralational operator:
            //>  <  == !=  >=  <=
            //in c#,we use bool to describe something right or wrong


            #endregion
            //11.07
            #region 闰年
            //leap year jugdement: 闰年条件
            //Years are divisible by 400;
            //Years are divisible by 4 but can't be divised by 100
            //Console.WriteLine("please input a year number");
            //int year = Convert.ToInt32(Console.ReadLine());
            //bool a = (year % 400 == 0) || (year % 4 == 0 && year % 100 != 0);
            #endregion

            #region ...结构
            //sequence structure:The program enters from main function and executes line by
            //line from top to bottom without dropping any lines
            //顺序结构:程序从主函数进入并逐行进行,从上到下,不落下任何一行
            //branch structure:if if-else
            //分支结构
            //case structure: if else-if switch-case
            //选择结构
            //loop structure: while do-while for foreach
            //循环结构

            //if statement:
            //judgement condition:usually is relational expression or bool type value
            //implementation:judge firstly,then execute

            //流程控制：控制程序代码的执行流程
            //if语句：根据布尔表达式是否为真来选择执行语句
            //if(i%2==0)
            //{
            //    statement
            //}
            //Console.WriteLine();
            //选择结构：if语句：根据布尔表达式是否为真来选择执行语句
            //int x = int.Parse(Console.ReadLine());
            //循环结构：while循环：只要表达式的值为真，就一直执行循环体
            //do-while循环：一直执行循环体，只要表达式的值为真
            //for循环：只要循环变量再指定的范围内，就一直执行循环体
            //foreach循环语句：对集合中的每一个元素执行循环体

            #endregion

            #region 用if-else 判断分数等级
            //Console.WriteLine("please input your score");
            //int score = Convert.ToInt32(Console.ReadLine());
            //if (score >= 90)
            //{
            //    Console.WriteLine("A");
            //}
            //else
            //{
            //    if (score >= 80)
            //    {
            //        Console.WriteLine("B");
            //    }
            //    else
            //    {
            //        if (score >= 70)
            //        {
            //            Console.WriteLine("C");
            //        }
            //        else
            //        {
            //            if (score >= 60)
            //            {
            //                Console.WriteLine("D")；
            //            }
            //            else
            //            {
            //                Console.WriteLine("E");
            //            }
            //        }
            //    }
            //}
            #endregion

            #region if else-if语句介绍 
            //if else-if:deal with interval judgement of multiple conditions
            //执行过程：程序首先判断第一个if所带的小括号中的判断条件，如果条件成立，也就是返回一个true，则执行
            //该if所带的大括号中的代码，执行完成后，立即跳出if-else结构
            //如果第一个if所带的的判断条件不成立，也就是返回一个false，则继续向下进行判断，依次地判断每一个if所带的
            //判断条件，如果成立，就执行该if所带地大括号中的代码，如果不成立，则继续向下判断，如果每个if所带地
            //判断条件都不成立，就看当前这个if else-if结构中是否存在else。
            //如果有else的话，则执行else中所带的代码如果没有else，则整个if -else if什么都不做
            #endregion

            #region 用if else-if 判断分数等级

            //Console.WriteLine("please input your score:");
            //int score = Convert.ToInt32(Console.ReadLine());
            ////the best way to deal with that
            //if (score >= 90)
            //{
            //    Console.WriteLine("A");
            //}
            //else if (score >= 80)
            //{
            //    Console.WriteLine("B");
            //}
            //else if (score >= 70)
            //{
            //    Console.WriteLine("C");
            //}
            //else if (score >= 60)
            //{
            //    Console.WriteLine("D");
            //}
            //else
            //{
            //    Console.WriteLine("E");
            //}
            #endregion

            #region 比较数字的大小,而不考虑相等
            //compare the size of numbers without considering equality
            //double a = Convert.ToDouble(Console.ReadLine());
            //double b = Convert.ToDouble(Console.ReadLine());
            //double c = Convert.ToDouble(Console.ReadLine());
            //分别地提示用户输入三个数字，我们接受并且转\换成double类型
            //if numberone bigger than numbertwo and numberthree
            #region if else-if 
            //if (a > b && a > c)
            //{
            //    Console.WriteLine("a");
            //}
            ////if numbertwo bigger than numberone and numberthree
            //else if (b > a && b > c)
            //{
            //    Console.WriteLine("b");
            //}
            ////anything else ,c must be bigger
            //else
            //{
            //    Console.WriteLine("c");
            //}
            #endregion

            #region if语句
            //if (a > b)
            //{
            //    if (a > c)
            //    {
            //        Console.WriteLine("A");
            //    }
            //    else
            //    {
            //        Console.WriteLine("C");
            //    }
            //}
            //if (b > a)
            //{
            //    if (b > c)
            //    {
            //        Console.WriteLine("B");
            //    }
            //    else
            //    {
            //        Console.WriteLine("C");
            //    }
            //}
            #endregion

            #endregion
            //11-09

            #region 密码的判定 if-else
            //Console.WriteLine("please input your code:");
            //string code = Console.ReadLine();
            //if (code == "abc1")
            //{
            //    Console.WriteLine("right!");
            //}
            //else
            //{
            //    Console.WriteLine("wrong!please input again!");
            //}
            //Console.ReadKey();
            #endregion

            #region 根据年龄段执行不同语句 if else-if

            //Console.WriteLine("please input your age:");
            //int age = Convert.ToInt32(Console.ReadLine());
            //if(age>=18)
            //{
            //    Console.WriteLine("you can see it");
            //}
            //else if(age<10)
            //{
            //    Console.WriteLine("do your homework");
            //}
            //else
            //{
            //    Console.WriteLine("whether you still enter?");
            //    string reply1 = Console.ReadLine();
            //    if (reply1 == "yes")
            //        Console.WriteLine("you can see it");
            //    else if (reply1 == "no")
            //        Console.WriteLine("good boy");
            //    else
            //    {
            //        Console.WriteLine("please confirm quikly!");

            //    }
            //}
            //Console.ReadKey();

            #endregion

            #region try catch异常捕获
            //声明后未赋值:语法上没有错误，在程序运行过程中，由于某些原因程序出现了错误，不能再正常的运行
            //int number = 0;//声明
            //bool b = true;
            //Console.WriteLine("请输入一个数字：");
            //try
            //{
            //    number = Convert.ToInt32(Console.ReadLine());//赋值

            //}
            //catch
            //{
            //    Console.WriteLine("输入的内容不能转化成文字");
            //    b = false;//如果实现catch，说明try里面发生异常，应停止条件语句的编译
            //    //通过bool语句实现对条件语句是否执行的判定

            //}
            //异常捕获：
            //我们在程序中经常会出现各种各样的异常，你如果想要你的程序变得坚强一些，
            //在代码中应该经常性地使用try-catch来进行异常捕获
            //try
            //{
            //        可能会出现异常的代码

            //}
            //执行过程：如果try中的代码没有出现异常，那么catch中的代码不会执行
            //如果try中的代码出现异常，哪怕这行出现异常的代码后面还有一百行都不会执行了
            //而是直接跳到catch中执行代码
            //try和catch之间不能有其他代码
            #endregion

            #region 变量的作用域
            //变量的作用域：
            //变量的作用域就是你能够使用到这个变量的范围
            //一般从声明它的那个括号开始到那个括号所对应的结束的括号结束，在
            //这个范围内，我们可以访问并使用变量，超出这个范围就访问不到了
            #endregion

            #region switch-case语句

            //switch-case
            //用来处理多条件的定值的判断
            //switch(变量或者表达式的值)
            //{
            //      case 值1：要执行的代码
            //      break；
            //      case值2：要执行的代码
            //      break；
            //      ……
            //      default：要执行的代码；
            //      break；
            //}
            //程序过程：程序执行到switch处，首先将括号中变量或表达式的值计算出来，然后拿着这个值依次跟每个case后面所带的值进行匹配
            //          ，一旦匹配成功，则执行该case所带的代码，执行完成后，遇到break，跳出switch-case结构
            //如果跟每个case所带的值都不匹配，就看当前这个switch-case结构中是否存在default
            //如果有default，则执行default中的语句如果没有default，则该switch-case结构什么都不做

            #endregion

            #region 例题
            //李四的年终工作评定，如果定为A级，则工资涨500元，如果定为B级，
            //则工资涨200元，如果定为C级，工资不变，如果定为D级工资降200
            //如果定为E级工资降500元
            //设李四的原工资为5000，请用户输入李四的评级，然后显示李四来年的工资

            //double salary = 5000;
            //bool b = true;
            //Console.WriteLine("please input lisi's class");//a b c d e 乱七八糟
            //string Class = Console.ReadLine();
            //Class = Class.ToUpper();

            #region 使用if else-if 来做

            ////string Class = Class.ToUpper(Console.ReadLine());错误的
            //if (Class == "A")
            //{
            //    salary += 500;
            //}
            //else if (Class == "B")
            //{
            //    salary += 200;
            //}
            //else if (Class == "C")
            //{

            //}
            //else if (Class == "D")
            //{
            //    salary -= 200;
            //}
            //else if (Class == "E")
            //{
            //    salary -= 500;
            //}
            //else//输入的不是a b c d e
            //{
            //    Console.WriteLine("输入有误，程序退出");
            //    b = false;
            //}
            //if (b == true)
            //{
            //    Console.WriteLine(salary);
            //}
            #endregion

            #region 使用switch-case来做

            //switch(Class)
            //{
            //    case "A":salary += 500;
            //        break;
            //    case "B":salary += 200;
            //        break;
            //    case "C":
            //        break;
            //    case "D":salary -= 200;
            //        break;
            //    case "E":salary -= 500;
            //        break;
            //    default: Console.WriteLine("输入有误，程序退出");
            //        b = false;
            //        break;

            //}
            //if (b)
            //{
            //    Console.WriteLine("李四明年的工资是{0}", salary);
            //}
            //Console.ReadKey();
            #endregion

            #endregion

            #region 练习:让用户输入姓名，然后显示出这个人上辈子是什么职业

            //Console.WriteLine("请输入一个姓名，我们将显示出来这个人上辈子的职业");
            //string name = Console.ReadLine();
            ////老杨、老苏、老蒋、老牛、老虎、老赵
            //switch(name)
            //{
            //    case "老杨":Console.WriteLine("上辈子是抽大烟的");
            //        break;
            //    case "老苏":Console.WriteLine("上辈子是个老鸨子");
            //        break;
            //    case "老马":Console.WriteLine("上辈子是老苏手下的头牌");
            //        break;
            //    case "老蒋":Console.WriteLine("上辈子是拉皮条的");
            //        break;
            //    case "老牛":Console.WriteLine("上辈子是一坨翔");
            //        break;
            //    case "老虎":Console.WriteLine("上辈子是个大病猫");
            //        break;
            //    case "老赵":Console.WriteLine("上辈子是光芒万丈救苦救难的菩萨呀");
            //        break;
            //    default:Console.WriteLine("不认识，估计是一坨翔");
            //        break;

            //}
            #endregion

            #region 用switch-case判定范围型条件:分数
            //score>=90:A
            //90>score>=80:B
            //80>score>=70:C
            //70>score>=60:D
            //score<60:E

            //Console.WriteLine("please input a score:");
            //int score = 0;
            //try
            //{
            //    score = Convert.ToInt32(Console.ReadLine());//0-100

            //    switch (score / 10)//你要把范围 变成一个定值
            //    {
            //        case 10:
            //            break;
            //        case 9:
            //            Console.WriteLine("A");
            //            break;
            //        case 8:
            //            Console.WriteLine("B");
            //            break;
            //        case 7:
            //            Console.WriteLine("C");
            //            break;
            //        case 6:
            //            Console.WriteLine("D");
            //            break;
            //        default:
            //            Console.WriteLine("复读去吧！");
            //            break;
            //    }
            //}
            //catch
            //{
            //    Console.WriteLine("输入错误，程序退出");
            //}
            #endregion

            #region 请用户输入年份，再输入月份，输出该月的天数，（结合之前如何判断闰年来做）

            //Console.WriteLine("please input the year:");
            //try
            //{
            //    int year = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine("please input the month:");
            //    try
            //    {

            //        int month = Convert.ToInt32(Console.ReadLine());
            //        if (month >= 1 && month <= 12)
            //        {
            //            int day = 0;//声明一个变量用来存储天数
            //            switch (month)
            //            {
            //                case 1:
            //                case 3:
            //                case 5:
            //                case 7:
            //                case 8:
            //                case 10:
            //                case 12:
            //                    day = 31;
            //                    break;
            //                case 2:
            //                    //由于二月有平年和闰年的不同，所以先要判断一下当年是不是闰年
            //                    if ((year % 400 == 0) || (year % 4 == 0 && year % 100 != 0))
            //                    {
            //                        day = 29;
            //                    }
            //                    else
            //                    {
            //                        day = 28;
            //                    }
            //                    break;
            //                default:
            //                    day = 30;
            //                    break;
            //            }
            //            Console.WriteLine("{0}年{1}月有{2}天", year, month, day);
            //        }//if 判断的括号
            //        else
            //        {
            //            Console.WriteLine("输入的月份不符合要求，程序退出");
            //        }
            //    }//try月份括号
            //    catch//跟月份配对
            //    {
            //        Console.WriteLine("输入的月份有误，程序退出");
            //    }
            //}//try年份的括号
            //catch//跟年份的try配对
            //{
            //    Console.WriteLine("输入的年份有误，程序退出");
            //}
            //Console.ReadKey();

            #endregion

            #region while循环

            //while(循环条件)
            //{
            //  循环体
            //}
            //执行过程：程序运行到while处，首先判断while所带的小括号内的循环条件是否成立
            //如果成立的话，也就是返回下一个true，则执行循环体，执行完一遍循环体后，再次回到循环条件
            //进行判断，如果依然成立，则继续执行循环体，如果不成立，则跳出while循环

            //在while循环中，一般总会有那么一行代码，能够改变循环条件，使之终有一天不再成立，如果没有
            //那么一行代码能够改变循环条件，也就是循环条件永远都成立，我们称之为这种循环叫做死循环


            //while(true)
            //{

            //}
            //循环体：console.writeline("下次考试我一定要细心！");
            //循环条件：打印的次数小于100遍
            //需要定义一个循环变量用来记录循环的次数，每循环一次，循环变量都应该自身+1
            //int i = 0;
            //while(i<100)
            //{
            //    Console.WriteLine("下次考试我一定要细心！\t{0}",i);
            //    i++;//每循环一次都要自身加1，否则陷入死循环
            //}
            #endregion

            #region 求1-100之间所有整数的和

            //int i = 1;
            //int sum = 0;//用来存储总和
            //while(i<=100)
            //{
            //    sum += i;
            //    i++;

            //}
            //Console.WriteLine(sum);

            #endregion

            #region 求1-100之间所有偶数的和

            //int i = 2;
            //int sum = 0;
            //while(i<=100)
            //{
            //    sum += i;
            //    i += 2;
            //}
            //Console.WriteLine(sum);
            #endregion

            #region break,return,continue用法区别

            //break 的用法
            //1、可以跳出switch-case结构
            //2、可以跳出当前while循环
            //break一般不单独使用，而是跟着if判断一起使用，表示，当满足某些条件时，就不再循环了。

            //int i = 1;
            //int j = 1;
            //while (i <= 10)
            //{
            //    while (j <= 10)
            //    {
            //        Console.WriteLine("我是里面的while循环");
            //        j++;
            //        break;
            //    }
            //    Console.WriteLine("我是外面的while循环");
            //    i++;
            //}

            //return关键字
            //并不是专门用来跳出循环的,return 的功能是结束一个方法.一旦在循环体内执行到一个return语句,
            //return语句将结束该方法,循环自然也随之结束.与continue与break不同的是,return直接结束整个
            //方法,不管这个return处于多少层循环之内

            //continue的功能与break有点类似,区别是continue只是中止本次循环,接着开始下一次循环.
            //而break是完全中止循环

            //break用于完全结束一个循环,跳出循环体.不管是哪种循环,一旦在循环体中遇到break,系统将完全
            //结束循环,开始执行循环之后的代码.break不仅可以结束其所在的循环,还可以结束其外层循环.
            //此时需要在break后紧跟一个标签,这个标签用于标识一个外层循环.java中的标签就是一个紧跟
            //着英文冒号(:)的标识符.且它必须放在循环语句之前才有作用



            //break:跳出当前循环，转到循环结束
            //continue：跳出当前循环，继续下一次循环
            //return:方法返回，如在循环中则终止循环
            //goto：无条件转移
            #endregion

            #region 要求用户输入用户名和密码 用户名只要不是admin 密码不是888888 重复提示

            //循环体：提示用户输入用户名，我们接受，密码，接受，判断是否登录成功
            //循环条件：用户名或密码输入错误
            //string username = "";
            //string usercode = "";
            //while(username!="admin"||usercode!="888888")
            //{
            //    Console.WriteLine("请输入用户名");
            //    username = Console.ReadLine();
            //    Console.WriteLine("请输入密码");
            //    usercode = Console.ReadLine();
            ////}
            ////Console.WriteLine("输入成功！");
            ////Console.ReadKey();
            #endregion

            #region 输入班级人数，然后依次输入学员成绩，计算班级学员的平均成绩和总成绩
            //int i = 1;
            //int score = 0;
            //double sum = 0;
            //Console.WriteLine("please input number:");
            ////循环体：学员成绩
            ////循环条件：班级人数
            //int number = Convert.ToInt32(Console.ReadLine());
            //while (i <= number)
            //{
            //    Console.WriteLine("please input student's score:");
            //    score = Convert.ToInt32(Console.ReadLine());
            //    sum += score;
            //    i++;
            //}
            //double avarage = sum / number;
            //Console.WriteLine("平均成绩是{0},总成绩是{1}", avarage, sum);
            //Console.ReadKey();

            #endregion

            #region 类与对象

            //类与对象
            //类的定义：类使用class关键字声明，有对象，有方法,有字段,有属性
            //形式【类修饰符】class类名称【：基类以及实现的接口列表】
            //{
            // 类体
            //}
            //声明一个对象引用：类名引用名Student student
            //创建一个对象：new 类构造函数
            //student=new Student（）;//如果缺少这一步编译器会报错
            //使用对象：引用名，变量名/方法名（参数）
            //类的成员：字段，属性，方法，事件，索引器，运算符，构造函数，折构函数
            //字段：字段存储类设计所需要的数据，亦称为数据成员
            //属性：避免字段再对象不知道的情况下被更改，可以为类字段提供保护，是类中可以像字段一样被访问的方法
            //方法：方法定义类可以执行的操作，方法可以接受提供输入数据的参数
            //事件：事件是向其他对象提供有关事件发生的一种方式
            //索引器：索引器允许以类似于数组的方式为对象建立索引
            //运算符：运算符是对操作数执行运算的术语或符号，如+，*，《
            //构造函数：构造函数是在第一次创建对象时调用的方法，他们通常用于初始化对象的数据，没有返回值
            //析构函数：折构函数时当对象即将从内存中移除时由运行库执行调用的方法
            //public：公有成员，提供了类的外部界面，允许类的使用者从外部进行访问
            //private：私有成员，仅限于类中的成员可以访问，从类的外部访问私有成员是不合法的，如果再声明中没有出现
            //          成员的访问修饰符，按照默认方式成员为私有的
            //protected：保护成员，这类成员不允许外部访问，但允许其派生类成员访问
            //internal：内部成员，允许同一个命名空间中的类访问
            //readonly：只读成员，这类成员的值只能读，不能写。也就是说，除了赋予初始值外，在程序的任何部分将无法盖这个成员的值

            //类或结构的默认访问类型时internal
            //类中所有的成员，默认均为private
            #endregion

            #region 只读字段(readonly)和常量(const)
            /* 1) 两者最大的相同之处是,都不允许在类方法或属性中更改它们的值.最大的不同在于,
            对于const需要在编写代码的时候给它们赋值,而readonly的字段的值可以在类的构造函数
            中动态地设置
                常量值总是被编译器替换成文字值.如果查看编译后的代码,将永远看不出在使用常量
            .只可以对值类型(原始的数据类型:int,char,float,bool等)使用const关键字,而不能在
            引用类型中使用.(值类型:int double bool char decimal struct enum//枚举
            引用类型:string 自定义类 接口 委托 数组)
                readonly不用关心值类型,并且它们可以在类的构造函数中被初始化.静态的readonly
            只能在静态的构造函数中被初始化,实例化的readonly也只能在静态的构造函数中被初始化,
            
                ********注意,将引用类型设置为readonly字段,只有该引用是保持只读的,但在对象的内部数据
            仍能修改*********


                2)【const是静态的,由类型访问,不能与static同用】;readonly不是静态的,由对象来访问,可以与
            static一起使用
                const须在声明时初始化,readonly可以在声明时初始化,也可以在构造器中初始化.如果是
            static readonly,可以在静态构造器中初始化
               ************** const可以定义字段和局部常量,readonly只能是字段*************
                const中用于值类型和字符串,引用类型初始化为null

                3)const常量是编译时常量,后者是运行时常量
                static表示被修饰的对象的生命周期与当前的应用程序域相同,因此可以在多个实例中共享
                const表示常量且只能在声明时赋值,因此const的常量在编译时就能确定,它如果没有被static
            修饰并不能在多个实例中共享(【通常static会和const一起使用以作为标志位来用,但不是必须的】)
                readonly只能用来修饰成员字段,且它所修饰的字段可以在声明时和构造函数结束后就能再
            赋值，因此他在运行时确定
                【const常量都是默认static，所以const不可以和static混用】
                【readonly常量既可以是静态的，也可以是非静态的。所以,readonly可以和static混用】

                4)const是不变常量,在编译的时候就需要有确定的值,只能用于数值和字符串,或者引用类型只能
            为null(这里为什么要把字符串单独拿出来?是因为字符串string是引用类型,但是使用的时候却感觉是
            值类型,它是一种特殊的引用类型),struct也不能用const标记.const可以修饰class的字段或者局部变量
            ,不能修饰属性.
                而readonly仅仅用于修饰class的字段,不能修饰属性.const是属于类级别而不是实例对象级别,不能
            跟static一起使用.而readonly既可以是类级别也可以是实例级别,它可以和static一起使用


                5)静态常量:编译器在编译时会对常量进行解析,并将常量的值替换成初始化的那个值.
                  动态常量:其值是在运行的那一刻才获得的,编译器编译期间将其标示为只读常量,而不用常量的值代替,
                          这样动态常量不必在声明的时候就初始化,而可以延迟到构造函数中初始化
                  const修饰的常量是静态常量,而readonly是动态常量:
                  1,const修饰的常量在声明的时候必须初始化;readonly修饰的常量则可以延迟到构造函数初始化
                  2,const修饰的常量在编译期间就被解析,即常量值被替换成初始化的值,readonly修饰的常量则延迟
            到运行的时候  
                    此外【**********const常量既可以声明在类中也可以声明在函数体内但是staitic readonly常量只能声
                    明在类中*********】

                const只能赋值一次:CLR对于const变量做了特殊处理,是将const的值直接嵌入在生成的IL码中,在执行的
            时候不会再去请求dll加载.

                总结const和readonly的最大区别(除语法外)

                const的变量是嵌入在IL代码中,编译时就加载好,不依赖外部dll(这也是为什么不能在构造方法中赋值)
                const在程序集更新时容易产生版本不一致的bug
                readonly的变量是在运行时加载,需请求加载dll,每次都能获取最新的值 
            */

            #endregion

            #region 斐波那契数列
            //int i, n;
            //int t1 = 0;
            //int t2 = 1;
            //int nextTerm;
            //Console.WriteLine("n的值是：");
            //n = Convert.ToInt32(Console.ReadLine());
            //for (i = 1; i <= n; ++i)
            //{
            //    nextTerm = t1 + t2;
            //    t1 = t2;
            //    t2 = nextTerm;
            //}
            //Console.WriteLine("第n项的值为：{0}", t2);
            //Console.ReadKey();
            #endregion

            #region 判断一个正整数是否为素数，若不是，则输出其所有约数  doing

            //int count = 0;
            //int[] yueShu = new int[10];
            //Console.WriteLine("输入一个正整数：");
            //while (true)
            //{


            //    try
            //    {
            //        int num = Convert.ToInt32(Console.ReadLine());
            //        if (num > 0)
            //        {
            //            for (int i = 2; i < num; i++)
            //            {
            //                if (num % i == 0)
            //                {
            //                    yueShu[count] = i;
            //                    count++;
            //                }
            //            }
            //            if (count == 0)
            //            {
            //                Console.WriteLine("该数为素数");
            //                break;
            //            }
            //            else
            //            {
            //                Console.WriteLine("该数不为素数");
            //                for (int i = 0; i < count; i++)
            //                {
            //                    Console.WriteLine("约数有1");
            //                    Console.WriteLine("约数有{0}",yueShu[i]);
            //                    Console.WriteLine("约数有{0}",num);
            //                }
            //                break;
            //            }
            //        }//if
            //        else
            //        {
            //            Console.WriteLine("请输入一个正整数！");

            //        }
            //    }//try
            //    catch
            //    {
            //        Console.WriteLine("请输入一个正整数！");
            //    }
            //}

            //Console.ReadKey();




            #endregion

            #region 输入班级人数，然后依次输入学员的成绩，计算班级学员的平均成绩和总成绩

            //循环体：提示输入学员成绩，接受，并转换成整数类型，累加到总成绩当中
            //循环条件：循环的次数小于等于班级人数

            //Console.WriteLine("请输入班级人数：");
            //int count = Convert.ToInt32(Console.ReadLine());
            //double sum = 0.0; //用来存放总成绩
            //int i = 1;//声明一个循环变量用来记录循环的次数
            //while(i <= count)
            //{
            //    Console.WriteLine("请输入第{0}个学员的考试成绩：",i);
            //    int score = Convert.ToInt32(Console.ReadLine());
            //    //表示把每一个学员的成绩累加到总成绩当中
            //    sum += score;
            //    i++;
            //}
            //Console.WriteLine("{0}个人的班级总成绩是{1}，平均成绩是{2}",count,sum,sum/count);
            //Console.ReadKey();

            #endregion

            #region 老师问学生，这道题你会做了吗,直到学生会或老师给他讲了10遍还不会，都要放学

            //放学的两个条件：
            //1、会了
            //2、讲完第十遍，不管你会不会，我都放学
            //循环体：老师不停的提问，学生不停的回答，老师还要不停的讲
            //循环条件：学生不会；讲的次数<=10


            //string answer = "";
            //int i = 0;
            //while(answer != "yes" && i < 10)
            //{
            //    Console.WriteLine("这是我第{0}遍给你讲，你会了吗？yes/no",i+1);
            //    answer = Console.ReadLine();//yes no
            //    //如果学生回答的是 会了 此时应该跳出循环
            //    if(answer == "yes")
            //    {
            //        Console.WriteLine("会了那就放学！！！");
            //        break;
            //    }
            //    i++;

            //}

            #endregion

            #region 2006年培养学员80000人，每年增长25% 请问按此增长速度，到那一年培训学员人数将达到20万人？

            //循环体：人数每年增长25%
            //循环条件：人数>=20万

            //double people = 80000;
            //int year = 2006;
            //while (people < 200000)
            //{
            //    people *= 1.25;
            //    year++;
            //}
            //Console.WriteLine("到第{0}年的时候人数将达到20万人",year);
            //Console.ReadKey();

            #endregion

            #region 提示用户输入yes或no 要求：只能输入yes或no，只要不是yes或no就要求用户一直重新输入
            //循环体：提示用户输入 我们接受并且判断
            //循环条件：输入的不能是yes 或者 no
            //string input = "";//halhah
            //while(input != "yes" && input != "no")
            //{
            //    Console.WriteLine("请输入yes或者no");
            //    input = Console.ReadLine();
            //}
            #endregion

            #region 提示用户输入用户名和密码，要求用户名等于admin密码等于888888 只要用户名错误或者密码错误就重新输入 但是 最多只能输入3次

            //循环体：提示用户输入用户名和密码 我们接受 判断
            //循环条件：用户名或者密码错误， 最多只能错三次

            //int i = 1;
            //string userName = "";
            //string userPwd = "";
            //while((userName != "admin" || userPwd != "888888")&&i<3)
            //{
            //    Console.WriteLine("请输入用户名：");
            //    userName = Console.ReadLine();
            //    Console.WriteLine("请输入密码：");
            //    userPwd = Console.ReadLine();
            //    i++;
            //}
            #endregion

            #region 写两个循环 第一个循环提示用户A输入用户名 要求A的用户名不能为空，只要为空，就要求A一直重新输入 用户B不能与A相同

            //循环体：提示用户A输入用户名 接收 判断
            //循环条件：用户名为空
            //string userNameA = "";
            //while (userNameA == "")
            //{
            //    Console.WriteLine("请输入用户名，不能为空");
            //    userNameA = Console.ReadLine();
            //}

            ////循环体：提示用户B输入用户名，接收判断
            ////循环条件：用户名为空或者跟A相同
            //string userNameB = "";
            //Console.WriteLine("请输入用户名，不能跟A相同，并且不能为空");
            //userNameB = Console.ReadLine();
            //while (userNameB == "" || userNameB == userNameA)
            //{
            //    if (userNameB == "")
            //    {
            //        Console.WriteLine("用户名不能为空，请重新输入");
            //        userNameB = Console.ReadLine();
            //    }
            //    else
            //    {
            //        Console.WriteLine("用户名B不能跟A的用户名相同，请重新输入");
            //        userNameB = Console.ReadLine();
            //    }
            //}

            //Console.ReadKey();
            #endregion

            #region 力矩实验求角加速度
            //int b = Convert.ToInt32(Console.ReadLine());


            //Console.WriteLine("请输入一个数字");
            //Console.WriteLine("ljgs");
            //string f = Console.ReadLine();

            //int c, d, e;
            //Console.WriteLine("{0},{1},{2}", c = b / 100, d = b % 100 / 10, e = b % 10);

            //Console.ReadKey();
            #endregion
        }
    }
}
