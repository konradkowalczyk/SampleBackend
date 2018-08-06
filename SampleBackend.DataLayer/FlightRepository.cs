using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleBackend.DataLayer
{
    public class FlightRepository : IFlightRepository
    {
        private static List<Flight> FakeFlightList = new List<Flight>()
        {
            new Flight() { Id = 1,Origin = "London", Destination = "Dublin", SeatsTotal = 200, SeatsFree = 50, FlightDate = new DateTime(2018, 09, 01) },
            new Flight() { Id = 1,Origin = "London", Destination = "Dublin", SeatsTotal = 146, SeatsFree = 70, FlightDate = new DateTime(2018, 09, 04) },
            new Flight() { Id = 1,Origin = "London", Destination = "Dublin", SeatsTotal = 180, SeatsFree = 32, FlightDate = new DateTime(2018, 09, 02) },
            new Flight() { Id = 1,Origin = "Los Angeles", Destination = "San Francisco", SeatsTotal = 190, SeatsFree = 55, FlightDate = new DateTime(2018, 09, 15) },
            new Flight() { Id = 1,Origin = "Los Angeles", Destination = "San Francisco", SeatsTotal = 200, SeatsFree = 80, FlightDate = new DateTime(2018, 09, 27) },
            new Flight() { Id = 1,Origin = "Los Angeles", Destination = "San Francisco", SeatsTotal = 146, SeatsFree = 24, FlightDate = new DateTime(2018, 09, 07) },
            new Flight() { Id = 1,Origin = "Melbourne", Destination = "Sydney", SeatsTotal = 180, SeatsFree = 37, FlightDate = new DateTime(2018, 08, 25) },
            new Flight() { Id = 1,Origin = "Melbourne", Destination = "Sydney", SeatsTotal = 146, SeatsFree = 15, FlightDate = new DateTime(2018, 08, 28) },
            new Flight() { Id = 1,Origin = "Melbourne", Destination = "Sydney", SeatsTotal = 200, SeatsFree = 67, FlightDate = new DateTime(2018, 09, 06) },
        };

        public IEnumerable<Flight> GetFlightsByLocations(string origin, string destination)
        {
            return FakeFlightList.Where(x => x.Origin.Equals(origin) && x.Destination.Equals(destination));
        }
    }
}
