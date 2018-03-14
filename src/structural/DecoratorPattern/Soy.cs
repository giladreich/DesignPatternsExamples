namespace DecoratorPattern
{
    public class Soy : AddonDecorator
    {
        public Soy(Beverage beverage) : base(beverage)
        {
        }

        public override string GetDescription()
        {
            return "Soy";
        }

        public override double Cost()
        {
            return Beverage.Cost() + 1;
        }
    }
}