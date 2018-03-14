using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        /// <summary>
        /// Definition:
        /// The decorator pattern, ataches additional responsibility to an object dynamically. Decorators provides a flexible
        /// alternative to subclassing for extending functionality.
        /// </summary>
        static void Main(string[] args)
        {
            Beverage espressoWithCaramelAndSoy = new Caramel(new Soy(new Espresso()));
            Beverage espressoWithCaramel = new Caramel(new Espresso());
            Beverage decafWithSoyAndCaramel = new Soy(new Caramel(new Decaf()));

            Console.WriteLine($"Espresso with caramel and soy {espressoWithCaramelAndSoy.Cost()}$");
            Console.WriteLine($"Espresso with caramel {espressoWithCaramel.Cost()}$");
            Console.WriteLine($"Decaf with soy and caramel {decafWithSoyAndCaramel.Cost()}$");

            Console.ReadKey();
        }
    }
}
