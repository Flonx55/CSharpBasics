using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013Expression
{
    class Student
    {
        public int _id;
        public string _name;
    }
    class Program
    {
        static void Main(string[] args)
        {
            /*
              To all language:
                ●Expressions,together with commands and declarations,are one of the basic 
            components of every programming language.We can say that expressions are 
            the essential component of every language.
                ●An expression is a syntatic entity whose evaluation either produces a value
            or fails to terminate,in which case the expression is undefined.
                ●An entity specifically used for evaluation


             To c#:
                ●An expression is a sequence of one or more operands and zero or more 
            operators that can be evaluated to a single value,object,method,or namespace.
            Simple names can be the name of a variable,type member,method parameter,
            namespace or type.
                ●The most basic (minimum) element of algorithm logic, which expresses 
            certain algorithm intention.
                ●Because the operator has a priority,the expression also has it.
            */

            //The meaning of  "operators that can be evaluated to a single value,object,method,or namespace."
            int x;
            x = 10; //a single value
            int y = 10;
            ++y;     //a single value
            y++;     //a single value

            //Get a object ->new 
            Student stu = new Student(); //"new" is a operator."Student" is a operand ."()" is a constructor
            //a object

            Action myAction = new Action(Console.WriteLine);
            //a method

            //(System.Windows) 
            //Both sides of the operator are namespaces, and Windows namespace is returned
            //a namespace



            //The meaning of    "Simple names can be the name of a variable,type member,method parameter,
            //namespace or type."

            int z;
            z = 100;
            string name;
            name = "Flonx";
            double d = Math.Pow(2, 3);
            int e = 3 + 4;
            //literal

            int m;
            m = z;
            //variable 

            Type myType = typeof(Int64);
            //Consists of two simple names:typeof and Int64
            Console.WriteLine(myType.FullName);
            //type member


            //●Classificaton of expressions

            //A value.Every value has an associated type.
            var h = 3 < 5     //a value of bool type

           Student stu1 = new Student();
            var id = stu1._id;//integer
            var name1 = stu1._name;//string

            var b = Math.Pow(2, 3);
            Console.WriteLine(b.GetType().Name);//double

            List<int> intList = new List<int>() { 1, 2, 3, 4 };
            double[] doubleArray = new double[] { 1, 2, 3, 4 };
            var i = intList[1];
            Console.WriteLine(i);
            var j = doubleArray[1];
            Console.WriteLine(j);// variables'type is decided by arrays' type.

        
            int c= 100;
            Console.WriteLine(++c);
            Console.WriteLine(c);

            Nullable<int> n = null;
            var f = n ?? 100;
            Console.WriteLine(f.GetType().FullName);

            Action a = delegate () { Console.WriteLine("Hello World!"); };//anonymous method expression

           

        } 
    }
}
