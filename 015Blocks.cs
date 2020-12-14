using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _015Block
{
    class Program
    {
        static void Main(string[] args)
        {/*
            ● Label statement:
            hello: Console.WriteLine("Hello World");
            goto hello;

            ●ragardless of how many statements they have,blocks would be viewed as just one statement 
            */



            //int x = 100;
            //int y = 300;
            //if (x>y)
            //{
            //    Console.WriteLine("Hello");
            //    Console.WriteLine("World");
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("World");
            //    Console.WriteLine("No");
            //}




            //int score = 95;
            //if (score>=0&&score<=100)
            //{
            //    if (score>=60)
            //    {
            //        //Console.WriteLine("Pass");
            //        if (score>=80)
            //        {
            //            Console.WriteLine("A");
            //        }
            //        else
            //        {
            //            Console.WriteLine("B");
            //        }
            //    }
            //    else
            //    {
            //        if (score >=40)
            //        {
            //            Console.WriteLine("C");
            //        }
            //        else
            //        {
            //            Console.WriteLine("D");
            //        }
            //    }
            //    if (score>=0&&score <=59)
            //    {
            //        Console.WriteLine("Failed");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Input Error");
            ////}
            //int score = 95;
            //if (score>=80&&score<=100)
            //{
            //    Console.WriteLine("A");
            //}
            //else
            //{//ctrl + ]
            //    if (score>=60)
            //    {
            //        Console.WriteLine("B");
            //    }
            //    else
            //    {
            //        if (score>=40)
            //        {
            //            Console.WriteLine("C");
            //        }
            //        else
            //        {
            //            if (score >=0)
            //            {
            //                Console.WriteLine("D");
            //            }
            //            else
            //            {
            //                Console.WriteLine("Input Error");
            //            }
            //        }
            //    }
            //}
            //{

            //}


            //int score = 100;
            //if (score >=80&&score <=100)
            //{
            //    Console.WriteLine("A");
            //}
            //else if (score >=60)
            //{
            //    Console.WriteLine("B");
            //}
            //else if (score >=40)
            //{
            //    Console.WriteLine("C");
            //}
            //else
            //{
            //    Console.WriteLine("Input Error");
            //}


            //int score = 101;
            //switch (score / 10)
            //{
            //    case 10:
            //        if (score==100)
            //        {
            //            goto case 8;
            //        }
            //        else
            //        {
            //            goto default;
            //        }
            //    case 8:
            //    case 9:
            //        Console.WriteLine("A");
            //        break;
            //    case 6:
            //    case 7:
            //        Console.WriteLine("B");
            //        break;
            //    case 4:
            //    case 5:
            //        Console.WriteLine("C");
            //        break;
            //    case 0:
            //    case 1:
            //    case 2:
            //    case 3:
            //        Console.WriteLine("D");
            //        break;

            //    default:
            //        Console.WriteLine("Input Error");
            //        break;
            //}


            //Level myLevel = Level.High;
            //switch (myLevel)
            //{
            //    case Level.High:
            //        Console.WriteLine("High level");
            //        break;
            //    case Level.Mid:
            //        Console.WriteLine("Mid level");
            //        break;
            //    case Level.Low:
            //        Console.WriteLine("Low level");
            //        break;
            //    default:Console.WriteLine("Input Error");
            //        break;
            //  }



            Calculator cal = new Calculator();
            int r = 0;
            try
            {
                r = cal.Add("999999999999999", "100");
            }
            catch(OverflowException oe)
            {
                Console.WriteLine(oe.Message);
            }
            Console.WriteLine(r);
        }//method body

    }//class body
    class Calculator
    {
        public int Add(string arg1,string arg2)
        {
            int a = 0;
            int b = 0;
           // bool hasError = false;
            try
            {
                a = int.Parse(arg1);
                b = int.Parse(arg2);
            }
            catch (ArgumentException ane)
            {
                //Console.WriteLine("Your argument(s) are null");
                Console.WriteLine(ane.Message);
                //hasError = true;
            }
            catch(FormatException fe)
            {
                //Console.WriteLine("Your argument(s) are not number.");
                Console.WriteLine(fe.Message);
                //hasError = true;
            }
            catch(OverflowException oe)
            {
                //Console.WriteLine("out of range!");
                Console.WriteLine(oe.Message);
                throw;
                //hasError = true;
            }
            //finally
            //{
            //    if (hasError)
            //    {
            //        Console.WriteLine("Execution has error!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Done!");
            //    }
            //}
            int result = a + b;
            return result;
        }
    }
    enum Level
    {
        High,
        Mid,
        Low
    }

}//Namespace body(not a block)