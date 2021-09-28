using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML
{
    class Program
    {
        abstract class Pizza
        {
            public string Name { get; set; }
            public double Price { get; set; }
            public Pizza(string name, double price)
            {
                Name = name;
                Price = price;
            }
            public abstract void getPrice();
        }

        class FrenchPizza : Pizza
        {
            public FrenchPizza(string name, double price) : base(name, price)
            {

            }

            public override void getPrice()
            {
                Console.WriteLine($"Price: {Price}");
            }
        }
        abstract class BaseDecorator : Pizza
        {
            public Pizza Pizza { get; set; }
            public BaseDecorator(string name, double price) : base(name, price)
            {

            }
        }

        class MushroomDecorator : BaseDecorator
        {
            public MushroomDecorator(Pizza Pizza) : base(Pizza.Name += " Mushroom", Pizza.Price += 15)
            {

            }

            public override void getPrice()
            {
                Console.WriteLine($"Price: {Price}");
            }
        }

        class CheeseDecorator : BaseDecorator
        {
            public CheeseDecorator(Pizza Pizza) : base(Pizza.Name += " Cheese", Pizza.Price += 12)
            {

            }

            public override void getPrice()
            {
                Console.WriteLine($"Price: {Price}");
            }
        }


        static void Main(string[] args)
        {

            Pizza Mypizza = new FrenchPizza("French", 5.20);
            Mypizza = new MushroomDecorator(Mypizza);
            Mypizza = new CheeseDecorator(Mypizza);
            Console.Write($"Name:{Mypizza.Name}\n");
            Mypizza.getPrice();
        }
    }
}
