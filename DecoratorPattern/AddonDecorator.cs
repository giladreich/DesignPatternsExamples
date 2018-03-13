namespace DecoratorPattern
{
    public abstract class AddonDecorator : Beverage
    {
        protected Beverage Beverage;

        protected AddonDecorator(Beverage beverage)
        {
            Beverage = beverage;
        }
    }
}