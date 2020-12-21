using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13委托
{
    class Program
    {
        static void Main(string[] args)
        {
            //Heater heater = new Heater();
            //Alarm alarm = new Alarm();
            //heater.BoilEvent += alarm.MakeAlert;//注册方法
            //heater.BoilEvent += (new Alarm()).MakeAlert;//给匿名对象注册方法
            //heater.BoilEvent += Display.ShowMsg;    //注册静态方法
            //heater.BoilWater();
            //Console.ReadKey();
            BookStore store = new BookStore();
            Customer c1 = new Customer();
            
            BookHandler bookhandler = new BookHandler(c1.store_OnNewBook );
            Customer c = new Customer ()
            
            Console.ReadKey();

        }


    }

    public delegate void BookHandler(string book);//委托定义原型


    public class BookStore
    {
        public event BookHandler OnNewBook;
        public void NewBook(string book)
        {
            OnNewBook(book);//事件引发方法
        }
    }
    public class Customer
    {
        private string _name;
        public Customer (string name)
        {
            _name = name;
        }
        public void Register(BookStore store)
        {
            store.OnNewBook += new BookHandler(store_OnNewBook);
        }
        public void store_OnNewBook(string book)
        {
            Console.WriteLine("书店新到新书" + book);
        }
    }
}
