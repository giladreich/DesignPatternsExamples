using System;
using System.Collections.Generic;
using System.Linq;

namespace FactoryMethodPattern
{
    public class AnimalRandomFactory : IAnimalFactory
    {
        private static readonly Random Random;

        static AnimalRandomFactory()
        {
            Random = new Random(DateTime.Now.Millisecond);
        }

        public Animal CreateAnimal(AnimalType animalType = AnimalType.Unknown)
        {
            if (animalType != AnimalType.Unknown)
                throw new InvalidOperationException("Using the random factory only allows Unknown animal type.");

            // Getting all classes that inherit Animal using reflection.
            List<Type> animals = typeof(Animal).Assembly.GetTypes()
                                    .Where(t => t.IsSubclassOf(typeof(Animal)))
                                    .ToList();

            int index = Random.Next(animals.Count);

            return (Animal) Activator.CreateInstance(animals[index]);
        }

        // Optionally if the consumer don't want to instiate the class on the client.
        public static Animal CreateAnimalInstance()
        {
            return new AnimalRandomFactory().CreateAnimal();
        }
    }
}
