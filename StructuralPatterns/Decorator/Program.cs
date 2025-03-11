using StructuralPatterns.Decorator.ConcreteDecorators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator
{
    class Program
    {
        static void Main()
        {
            ICoffee coffee = new SimpleCoffee();
            Console.WriteLine($"{coffee.GetDescription()} - ${coffee.GetPrice()}");

            // Add Milk
            coffee = new MilkDecorator(coffee);
            Console.WriteLine($"{coffee.GetDescription()} - ${coffee.GetPrice()}");

            // Add Sugar
            coffee = new SugarDecorator(coffee);
            Console.WriteLine($"{coffee.GetDescription()} - ${coffee.GetPrice()}");
           
        }
    }
}
