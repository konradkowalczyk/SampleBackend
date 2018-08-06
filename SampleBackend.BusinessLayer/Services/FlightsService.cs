using SampleBackend.BusinessLayer.FlightRouteService;
using SampleBackend.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleBackend.BusinessLayer
{
    public class FlightsService : IFlightService
    {
        private readonly FlightRepository _flightRepository;

        public FlightsService(FlightRepository flightRepository)
        {
            _flightRepository = flightRepository;
        }

        public FlightDetailsResponse GetFlightDetails(string origin, string destination)
        {
            var routeData = GetRouteData(origin, destination);
            var nearestFlightDetails = GetNearestFlight(origin, destination);

            return CombineResponse(routeData, nearestFlightDetails);
        }

        private Flight GetNearestFlight(string origin, string destination)
        {
            var flights = _flightRepository.GetFlightsByLocations(origin, destination);
            return flights.OrderBy(x => x.FlightDate).FirstOrDefault();
        }

        private static FlightRouteResponse GetRouteData(string origin, string destination)
        {
            var routeServiceClient = new FlightRouteService.FlightRouteRetrievalServiceClient();
            var routeData = routeServiceClient.GetFlightRoute(
                new FlightRouteRequest() { Origin = origin, Destination = destination });

            return routeData;
        }

        private FlightDetailsResponse CombineResponse(FlightRouteResponse routeData, Flight nearestFlightDetails)
        {
            return new FlightDetailsResponse()
            {
                Distance = routeData.Distance,
                EstimatedLengthInHrs = routeData.EstimatedLengthInHrs,
                NearestFlightDate = nearestFlightDetails.FlightDate,
                FreeSeatsCount = nearestFlightDetails.SeatsFree,
                Success = routeData.Success,
            };
        }
    }
}
