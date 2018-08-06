using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightRouteService
{
    public static class FlightRouteToResponceMapper
    {
        public static FlightRouteResponse MapRouteToResponse(FlightRoute flightRoute)
        {
            return new FlightRouteResponse()
            {
                Origin = flightRoute.Origin,
                Destination = flightRoute.Destination,
                Distance = flightRoute.Distance,
                StopOverAt = flightRoute.StopOverAt,
                EstimatedLengthInHrs = flightRoute.EstimatedLengthInHrs,
                Success = true
            };
        }
    }
}
