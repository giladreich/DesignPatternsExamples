using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPatternTheMicrosoftWay
{
    // https://msdn.microsoft.com/en-us/library/dd990377(v=vs.110).aspx
    class Program
    {
        /// <summary>
        /// Definition:
        /// The observer pattern defines a one to many dependencies between objects so that when one object changes state,
        /// all of it's dependencies are notified and updated automatically.
        /// </summary>
        static void Main(string[] args)
        {
            LocationTracker provider = new LocationTracker();
            LocationReporter reporter1 = new LocationReporter("FixedGPS");
            reporter1.Subscribe(provider);
            LocationReporter reporter2 = new LocationReporter("MobileGPS");
            reporter2.Subscribe(provider);

            provider.TrackLocation(new Location(47.6456, -122.1312));
            reporter1.Unsubscribe();
            provider.TrackLocation(new Location(47.6677, -122.1199));
            provider.TrackLocation(null);
            provider.EndTransmission();

            Console.ReadKey();
        }
    }
}
