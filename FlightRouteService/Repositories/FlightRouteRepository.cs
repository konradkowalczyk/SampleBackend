using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightRouteService
{
    public class FlightRouteRepository
    {
        private static List<FlightRoute> FakeFlightRouteList = new List<FlightRoute>()
        {
            new FlightRoute() {Id = 1, Origin = "London", Destination = "Dublin", Distance = 463, EstimatedLengthInHrs = 1.5M},
            new FlightRoute() {Id = 2, Origin = "Los Angeles", Destination = "San Francisco",  Distance = 540, EstimatedLengthInHrs = 1},
            new FlightRoute() {Id = 3, Origin = "Melbourne", Destination = "Sydney", Distance = 713, EstimatedLengthInHrs = 2}
        };

        public FlightRoute GetFlightRoute(string origin, string destination)
        {
            return FakeFlightRouteList.FirstOrDefault(x => x.Origin.Equals(origin) && x.Destination.Equals(destination));
        }
    }
}
