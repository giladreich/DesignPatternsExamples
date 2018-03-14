namespace StrategyPattern
{
    public abstract class Duck
    {
        private readonly IQuackBehavior quackBehavior;
        private readonly IDisplayBehavior displayBehavior;
        private readonly IFlyBehavior flyBehavior;

        protected Duck(IQuackBehavior quackBehavior, IDisplayBehavior displayBehavior, IFlyBehavior flyBehavior)
        {
            this.quackBehavior = quackBehavior;
            this.displayBehavior = displayBehavior;
            this.flyBehavior = flyBehavior;
        }

        public virtual void Quack()
        {
            quackBehavior.Quack();
        }

        public virtual void Display()
        {
            displayBehavior.Display(); 
        }

        public virtual void Fly()
        {
            flyBehavior.Fly();
        }
    }
}