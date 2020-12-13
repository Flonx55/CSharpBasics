using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013Expression
{
    class _014Statement
    {
        /*
        ●In computer programming a statement is the smallest standalone element of an imperative programming language
        which expresses some action to be carried out.A program written in such a language is formed by a sequence of one 
        or more statements.A statement will have internal components(expressions).
        ● Statements are the syntax of high-level languages -- assembly and machine languages have only instructions
        (expressions in high-level languages correspond to instructions in low-level languages), and statements are equivalent
        to one or a group of Instructions that are clearly logically related.
        ●Function:
        State the algorithm idea, control the logic direction, and complete the meaningful action
       ●How to distinguish statement?(Not all sentence ending with a semicolon can be called statement)
                It must be in the body of a method.

        */
        static void Main(string[] args)
        {//Show the flow of control or flow of execution
            string input = Console.ReadLine();
            try
            {
                double score = double.Parse(input);
                if (score>=60)
                {
                    Console.WriteLine("pass");
                }
                else
                {
                    Console.WriteLine("failed");
                }
            }
            catch 
            {

                Console.WriteLine("Not a number");
            }

        }
        static double getCylinderVolume(double r, double h)
        {
            double area = 3.1416 * r * r; //A variable is declared with its initializer appended.
            double volume = area * h;
            return volume;
        }

    }

}
