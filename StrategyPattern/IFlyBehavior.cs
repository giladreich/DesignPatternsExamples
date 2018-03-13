using System;

namespace StrategyPattern
{
    public interface IFlyBehavior
    {
        void Fly();
    }
    public class NoFlying : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("No flying....");
        }
    }

    public class SimpleFlying : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("Simple flying....");
        }
    }
}