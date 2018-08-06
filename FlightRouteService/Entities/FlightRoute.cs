using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightRouteService
{
    public class FlightRoute
    {
        public long Id { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public decimal Distance { get; set; }
        public string StopOverAt { get; set; }
        public decimal EstimatedLengthInHrs { get; set; }
    }
}

