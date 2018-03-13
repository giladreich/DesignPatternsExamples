
namespace FactoryMethodPattern
{
    public abstract class Animal
    {
        public virtual string MakeSound()
        {
            return "Unknown sound...";
        }

        public virtual string GetName()
        {
            return "Animal";
        }
    }

    public class Cat : Animal
    {
        public override string MakeSound()
        {
            return "Meoww...";
        }

        public override string GetName()
        {
            return "Cat";
        }
    }

    public class Dog : Animal
    {
        public override string MakeSound()
        {
            return "Waff waff...";
        }

        public override string GetName()
        {
            return "Dog";
        }
    }

    public class Cow : Animal
    {
        public override string MakeSound()
        {
            return "Moooo...";
        }

        public override string GetName()
        {
            return "Cow";
        }
    }
}
