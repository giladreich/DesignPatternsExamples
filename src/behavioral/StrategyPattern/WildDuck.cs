namespace StrategyPattern
{
    public class WildDuck : Duck
    {
        public WildDuck() : 
            base(new NoQuack(), new CrazyDisplayBehavior(), new SimpleFlying())
        {
        }
    }
}