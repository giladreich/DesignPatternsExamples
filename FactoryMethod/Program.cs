using System;

namespace FactoryMethodPattern
{
    class Program
    {
        /// <summary>
        /// Definition:
        /// The factory method pattern define an interface for creating an object, 
        /// but let the subclasses decide which class to instantiate. The Factory 
        /// method lets a class defer instantiation to subclasses
        /// 
        /// When to use?:
        /// Client doesn't know what concrete classes it will be required to create at runtime, 
        /// but just wants to get a class that will do the job.
        /// </summary>
        static void Main(string[] args)
        {
            Console.WriteLine("--- The random factory ---");
            for (int i = 0; i < 10; i++)
            {
                Animal animal = AnimalFactory.CreateAnimalInstance();
                Console.WriteLine($"[{animal.GetName()}] - {animal.MakeSound()}");
            }

            Console.WriteLine("\n\n\n--- The factory ---");
            Animal dog = AnimalFactory.CreateAnimalInstance(AnimalType.Dog);
            Console.WriteLine($"[{dog.GetName()}] - {dog.MakeSound()}");

            Console.ReadKey();
        }
    }
}
