using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12程序清单3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //string a;
            //Console.WriteLine(a);
            Contact c1 = new Contact() { Name = "王小明", Phone = "321000" };
            PrintContact(c1);
            c1 = null;
            PrintContact(c1);
            Console.ReadKey();
            
        }
        static void PrintContact(Contact c)
        {
            Console.WriteLine("{0},{1}",c.Name ,c.GetGenderChar() );
            Console.WriteLine("pho:{0}",c.Phone );
            Console.WriteLine("Adr:{0}",c.Address );
        }

    }
    class Contact
    {
        
        public string Name;
        public bool Gender;
        public string Phone;
        public string Address;

        public char GetGenderChar()
        {
            if (Gender)
            {
                return '男';
            }
            else
            {
                return '女';
            }
        }
    }
}
