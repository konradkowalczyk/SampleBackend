using log4net;
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
        private readonly ILog _log;

        public FlightsService(FlightRepository flightRepository, ILog log)
        {
            _flightRepository = flightRepository;
            _log = log;
        }

        public FlightDetailsResponse GetFlightDetails(string origin, string destination)
        {
            var routeData = GetRouteData(origin, destination);
            var nearestFlight = GetNearestFlight(origin, destination);
            if (routeData.Success && nearestFlight != null)
            {
                return CombineResponse(routeData, nearestFlight);
            }
            else
                return new FlightDetailsResponse() { Success = false };
        }

        private Flight GetNearestFlight(string origin, string destination)
        {
            Flight nearestFlight = null;
            try
            {
                var flights = _flightRepository.GetFlightsByLocations(origin, destination);
                return flights.OrderBy(x => x.FlightDate).FirstOrDefault();
            }
            catch (Exception e)
            {
                _log.Error(e.Message);
                return nearestFlight;
            }
        }

        private FlightRouteResponse GetRouteData(string origin, string destination)
        {
            FlightRouteResponse routeData = null;
            try
            {
                var routeServiceClient = new FlightRouteService.FlightRouteRetrievalServiceClient();
                routeData = routeServiceClient.GetFlightRoute(
                    new FlightRouteRequest() { Origin = origin, Destination = destination });
                return routeData;
            }
            catch (Exception e)
            {
                _log.Error(e.Message);
                return new FlightRouteResponse() { Success = false };
            }
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
