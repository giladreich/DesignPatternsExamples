using System;

namespace ObserverPatternTheMicrosoftWay
{
    public class LocationReporter : IObserver<Location>
    {
        private IDisposable unsubscriber;
        public string Name { get; }

        public LocationReporter(string name)
        {
            Name = name;
        }

        public virtual void Subscribe(IObservable<Location> provider)
        {
            if (provider != null)
                unsubscriber = provider.Subscribe(this);
        }

        public virtual void OnCompleted()
        {
            Console.WriteLine($"The Location Tracker has completed transmitting data to {Name}.");
            Unsubscribe();
        }

        public virtual void OnError(Exception e)
        {
            Console.WriteLine($"{Name}: The location cannot be determined.");
        }

        public virtual void OnNext(Location value)
        {
            Console.WriteLine($"{Name}: The current location is {value.Latitude}, {value.Longitude}");
        }

        public virtual void Unsubscribe()
        {
            unsubscriber.Dispose();
        }
    }
}