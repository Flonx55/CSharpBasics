using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
namespace _20EventExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer();
            timer.Interval = 1000;//one second
            Boy boy = new Boy();
            Girl girl = new Girl();
            timer.Elapsed += boy.Action;
            timer.Elapsed += girl.Action;
            timer.Start();
            Console.ReadLine();
        }
    }


    class Boy//将是事件的响应者
    {
        internal void Action(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Jump!");
        }
    }


    class Girl
    {
        internal void Action(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Sing!");
        }
    }
}
