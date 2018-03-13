
namespace FactoryMethodPattern
{
    public interface IAnimalFactory
    {
        Animal CreateAnimal(AnimalType animalType = AnimalType.Unknown);
    }

    public enum AnimalType
    {
        Cat,
        Dog,
        Cow,
        Unknown
    }
}
