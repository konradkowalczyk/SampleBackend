using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleBackend.BusinessLayer
{
    public class FlightCalculationService
    {
        public FlightCalculationResult CalculateFlight(string origin, string destination)
        {
            var routeServiceClient = new FlightRouteService.FlightRouteRetrievalServiceClient();

            var routeData = routeServiceClient.GetFlightRoute(
                new FlightRouteService.FlightRouteRequest() {Origin = origin, Destination = destination });

            return new FlightCalculationResult() { Distance = routeData.Distance,
                EstimatedLengthInHrs = routeData.EstimatedLengthInHrs ,Success = routeData.Success };
        }

    }
}
