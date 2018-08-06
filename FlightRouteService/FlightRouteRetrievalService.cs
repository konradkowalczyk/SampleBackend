using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FlightRouteService
{
    public class FlightRouteRetrievalService : IFlightRouteRetrievalService
    {
        public FlightRouteResponse GetFlightRoute(FlightRouteRequest flightRouteRequest)
        {
            var flightRouteRepositoy = new FlightRouteRepository();
            var route = flightRouteRepositoy.GetFlightRoute(flightRouteRequest.Origin, flightRouteRequest.Destination);

            return route == null ? new FlightRouteResponse() { Success = false } :
                FlightRouteToResponceMapper.MapRouteToResponse(route);
        }
    }
}
