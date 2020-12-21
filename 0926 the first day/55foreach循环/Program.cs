using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _55foreach循环
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 76, 8, 23 };
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i]);
            }
            Console.WriteLine("=================================");
            foreach (var item in nums)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        }
    }
}
