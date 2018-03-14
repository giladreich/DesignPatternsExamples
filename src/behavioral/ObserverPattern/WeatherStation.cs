using System.Collections.Generic;

namespace ObserverPattern
{
    public class WeatherStation : IObservable
    {
        private List<IObserver> observers;
        public WeatherStation()
        {
            observers = new List<IObserver>();
        }

        public void Add(IObserver observer)
        {
            if (observer != null && !observers.Contains(observer))
                observers.Add(observer);
        }

        public void Remove(IObserver observer)
        {
            if (observers.Contains(observer))
                observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IObserver observer in observers)
                observer.Update();
             
        }

        public void UpdateTemperatur(int temp)
        {
            Temperatur = temp;
            Notify();
        }

        public int Temperatur { get; private set; }
    }
}