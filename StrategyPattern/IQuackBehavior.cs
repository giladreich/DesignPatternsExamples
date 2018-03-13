using System;

namespace StrategyPattern
{
    public interface IQuackBehavior
    {
        void Quack();
    }

    public class SimpleQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack quack quack...");
        }
    }

    public class NoQuack : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("No quack...");
        }
    }
}