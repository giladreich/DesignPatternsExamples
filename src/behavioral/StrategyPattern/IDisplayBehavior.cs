using System;

namespace StrategyPattern
{
    public interface IDisplayBehavior
    {
        void Display();
    }

    public class NoDisplayBehavior : IDisplayBehavior
    {
        public void Display()
        {
            Console.WriteLine("I got nothing to display.");
        }
    }

    public class CrazyDisplayBehavior : IDisplayBehavior
    {
        public void Display()
        {
            Console.WriteLine("I look very crazy...");
        }
    }

    public class UglyDisplayBehavior : IDisplayBehavior
    {
        public void Display()
        {
            Console.WriteLine("I'm so ugly!");
        }
    }
}