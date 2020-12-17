using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019DelegateExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductFactory productFactory = new ProductFactory();//创建一个制作工厂的实例,为了点出其中的制作方法以被包装
            WrapFactory wrapFactory = new WrapFactory();//创建一个包装工厂的实例,准备将成品包装.

            Func<Product> func1 = new Func<Product>(productFactory.MakePizza);//点出制作工厂的制作披萨的制作方法,被func1所包装
            Func<Product> func2 = new Func<Product>(productFactory.MakeToCar);//点出制作工厂的制作玩具车的制作方法,被func2所包装

            Box box1 = wrapFactory.WrapProduct(func1);//使用包装工厂中的包装方法(其中调用了被包装的制作方法)
            Box box2 = wrapFactory.WrapProduct(func2);
            //包装完毕,出库
            Console.WriteLine(box1.Product.Name);//盒子里面包装了物品,物品具有名字字段.
            Console.WriteLine(box2.Product.Name);
        }
    }
    class Product//创建一个商品类,(赋予名字)
    {
        public string Name { get; set; }
    }

    class Box//准备将商品打包,所以数据成员是Product类
    {
        public Product Product { get; set; }
    }

    class WrapFactory//模板方法   解耦合 //为了减少代码的重复性,
    {
        public Box WrapProduct(Func<Product> getProduct)//创建委拖类型的参数,准备将制作的方法给包装
        {
            Box box = new Box();
             Product product = getProduct.Invoke();//该委托此时已包装了一个制作方法,并为其命名
            box.Product = product;//将其打包
            return box;//返回成品
        }
    }
    
    class ProductFactory//制造不同的商品
    {
        public Product MakePizza()
        {
            Product product = new Product();
            product.Name = "Pizza";
            return product;
        }

        public Product MakeToCar()
        {
            Product product = new Product();
            product.Name = "Toy Car";
            return product;
        }
    }

}
