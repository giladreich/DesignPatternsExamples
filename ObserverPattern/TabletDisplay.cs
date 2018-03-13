using System;

namespace ObserverPattern
{
    public class TabletDisplay : IObserver
    {
        private WeatherStation weatherStation;
        public TabletDisplay(WeatherStation weatherStation)
        {
            this.weatherStation = weatherStation;
        }
        public void Update()
        {
            Console.WriteLine($"{nameof(TabletDisplay)} temperatur is : {weatherStation.Temperatur}");
        }
    }
}