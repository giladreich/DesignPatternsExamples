namespace StrategyPattern
{
    public class CityDuck : Duck
    {
        public CityDuck() : 
            base(new SimpleQuack(), new UglyDisplayBehavior(),  new NoFlying())
        {
        }
    }
}