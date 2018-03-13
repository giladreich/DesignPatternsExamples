namespace DecoratorPattern
{
    public class Caramel : AddonDecorator
    {
        public Caramel(Beverage beverage) : base(beverage)
        {
        }

        public override string GetDescription()
        {
            return "Caramel";
        }

        public override double Cost()
        {
            return Beverage.Cost() + 2;
        }
    }
}