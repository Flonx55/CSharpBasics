using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13复习
{
    public enum Gender
    {
        男,
        女,
    }
    public struct Person
    {
        public string _name;
        public int _age;
        public Gender _gender;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //常量 枚举 结构 数组
            //常量不允许被重新赋值
            //const int number = 10;

            //Gender gender = Gender.男;
            //string s = "男";
            //Gender g = (Gender)Enum.Parse(typeof(Gender), s);

            //Person zsPerson;
            //zsPerson._name = "张三";
            //zsPerson._age = 10;
            //zsPerson._gender = Gender.女;

            //数组 可以一次性的存储多个相同类型的变量
            //int[] numbers = new int[10];
            //numbers[2] = 3;

            //冒泡排序

            int[] numbers = { 11, 2, 55, 64, 3, 9, 17 };
            //升序排列
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length - 1 - i; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }

            }
            //Array.Sort(numbers);
            //Array.Reverse(numbers);

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
            Console.ReadKey();
        }
    }
}
