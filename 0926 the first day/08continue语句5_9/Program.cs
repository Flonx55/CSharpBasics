using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08continue语句5_9
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
                return;
            string str = args[0];
            Console.Write(str[0]);
            int i = 0;
            while(i<str.Length -1)
            {
                if (str[i] == str[++i])
                    continue;
                else
                    Console.Write(str[i]);
            }
            Console.ReadKey();
        }

    }
}
