using System;

namespace StrategyPattern
{
    class Program
    {
        /// <summary>
        /// Definition:
        /// The strategy pattern defines a family of algorithms, encapsulates each one and makes them interchangeable.
        /// Strategy lets the algorithm very independently from clients that use it.
        /// </summary>
        static void Main(string[] args)
        {
            WildDuck wildDuck = new WildDuck();
            CityDuck cityDuck = new CityDuck();
            Console.WriteLine("\n--- The wild duck ---");
            wildDuck.Quack();
            wildDuck.Fly();
            wildDuck.Display();

            Console.WriteLine("\n--- The city duck ---");
            cityDuck.Quack();
            cityDuck.Fly();
            cityDuck.Display();


            Console.ReadKey();
        }
    }
}
