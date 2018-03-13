
namespace FactoryMethodPattern
{
    public class AnimalFactory : IAnimalFactory
    {
        public Animal CreateAnimal(AnimalType animalType = AnimalType.Unknown)
        {
            switch (animalType)
            {
                case AnimalType.Cat:
                    return new Cat();;
                    
                case AnimalType.Dog:
                    return new Dog();

                case AnimalType.Cow:
                    return new Cow();

                case AnimalType.Unknown: default:
                    return AnimalRandomFactory.CreateAnimalInstance();
            }
        }

        // Optionally if the consumer don't want to instiate the class on the client.
        public static Animal CreateAnimalInstance(AnimalType animalType = AnimalType.Unknown)
        {
            return new AnimalFactory().CreateAnimal(animalType);
        }
    }
}
