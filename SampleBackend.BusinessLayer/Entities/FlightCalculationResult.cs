using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleBackend.BusinessLayer
{
    public class FlightCalculationResult
    {
        public decimal Distance { get; set; }
        public decimal EstimatedLengthInHrs { get; set; }
        public decimal EstimatedCost { get; set; }
        public bool Success { get; set; }
    }
}
