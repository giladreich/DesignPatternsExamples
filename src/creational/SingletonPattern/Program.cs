using System;

namespace SingletonPattern
{
    /// <summary>
    /// The singleton pattern ensures the class has only one instance and provides global point of access to it.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            DonaldTrump trump = DonaldTrump.GetInstance();
            trump.Speak();

            // OR
            DonaldTrump.GetInstance().Speak();

            Console.ReadKey();
        }
    }
}
