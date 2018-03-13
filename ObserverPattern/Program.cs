using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        /// <summary>
        /// Definition:
        /// The observer pattern defines a one to many dependencies between objects so that when one object changes state,
        /// all of it's dependencies are notified and updated automatically.
        /// </summary>
        static void Main(string[] args)
        {
            WeatherStation station = new WeatherStation();
            TabletDisplay tabletDisplay = new TabletDisplay(station);
            PhoneDisplay phoneDisplay = new PhoneDisplay(station);

            station.Add(tabletDisplay);
            station.Add(phoneDisplay);
            station.Notify();
            station.Remove(tabletDisplay);
            station.Notify();
            station.Add(tabletDisplay);
            station.Notify();

            Console.WriteLine("\n--- Let's update the temperatur --- ");
            station.UpdateTemperatur(50);


            Console.ReadKey();
        }
    }
}
