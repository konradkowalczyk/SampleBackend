using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace FlightRouteService
{
    [ServiceContract]
    public interface IFlightRouteRetrievalService
    {
        [OperationContract]
        FlightRouteResponse GetFlightRoute(FlightRouteRequest flightRouteRequest);
    }

    [DataContract]
    public class FlightRouteResponse
    {
        [DataMember]
        public long Id { get; set; }

        [DataMember]
        public string Origin { get; set; }

        [DataMember]
        public string Destination { get; set; }

        [DataMember]
        public decimal Distance { get; set; }

        [DataMember]
        public string StopOverAt { get; set; }

        [DataMember]
        public decimal EstimatedLengthInHrs { get; set; }

        [DataMember]
        public bool Success { get; set; }
    }

    [DataContract]
    public class FlightRouteRequest
    {
        [DataMember]
        public string Origin { get; set; }

        [DataMember]
        public string Destination { get; set; }
    }
}
