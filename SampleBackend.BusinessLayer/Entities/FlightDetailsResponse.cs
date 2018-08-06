using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleBackend.BusinessLayer
{
    public class FlightDetailsResponse
    {
        public decimal Distance { get; set; }
        public decimal EstimatedLengthInHrs { get; set; }
        public DateTime NearestFlightDate { get; set; }
        public int FreeSeatsCount { get; set; }
        public bool Success { get; set; }
    }
}
