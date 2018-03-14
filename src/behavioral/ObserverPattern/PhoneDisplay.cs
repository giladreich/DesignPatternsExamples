using System;

namespace ObserverPattern
{
    public class PhoneDisplay : IObserver
    {
        private WeatherStation weatherStation;
        public PhoneDisplay(WeatherStation weatherStation)
        {
            this.weatherStation = weatherStation;
        }
        public void Update()
        {
            Console.WriteLine($"{nameof(PhoneDisplay)} temperatur is : {weatherStation.Temperatur}");
        }
    }
}