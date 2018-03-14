namespace DecoratorPattern
{
    public class Decaf : Beverage
    {
        public override string GetDescription()
        {
            return "Decaf";
        }

        public override double Cost()
        {
            return 2;
        }
    }
}