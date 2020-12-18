using System;
using static System.Console;
namespace _Product
{
    class Program
    {
        static void Main(string[] args)
        {

            IProductFactory pizzaFactory = new PizzaFactory();
            IProductFactory toycarFactory = new ToyCarFactory();
            //ProductFactory productFactory = new ProductFactory();
            WrapFactory wrapFactory = new WrapFactory();

            // Func<Product> func1 = new Func<Product>(productFactory.MakePizza);
            //Func<Product> func2 = new Func<Product>(productFactory.MakeToyCar);

            //Box box1 = wrapFactory.WrapProduct(func1);
            //Box box2 = wrapFactory.WrapProduct(func2);

            Box box1 = wrapFactory.WrapProduct(pizzaFactory);
            Box box2 = wrapFactory.WrapProduct(toycarFactory);

            Console.WriteLine(box1.Product.Name);
            Console.WriteLine(box2.Product.Name);

        }
    }

    interface IProductFactory
    {
        Product Make();
    }


    class PizzaFactory : IProductFactory
    {
        public Product Make()
        {
            Product product = new Product();
            product.Name = "Pizza";
            return product;
        }
    }

    class ToyCarFactory : IProductFactory
    {
        public Product Make()
        {
            Product product = new Product();
            product.Name = "ToyCar";
            return product;
        }
    }

    class Product
    {
        public string Name { get; set; }
    }
    class Box
    {
        public Product Product { get; set; }
    }

    class WrapFactory
    {
        public Box WrapProduct(Func<Product> getProduct)
        {
            Box box = new Box();
            Product product = getProduct.Invoke();
            box.Product = product;
            return box;
        }
        public Box WrapProduct(IProductFactory productFactory)
        {
            Box box = new Box();
            Product product = productFactory.Make();
            box.Product = product;
            return box;
        }
    }
    class ProductFactory
    {
        public Product MakePizza()
        {
            Product product = new Product();
            product.Name = "Pizza";
            return product;
        }
        public Product MakeToyCar()
        {
            Product product = new Product();
            product.Name = "ToyCar";
            return product;
        }

    }
}