using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleBackend.BusinessLayer
{
    public interface IFlightService
    {
        FlightDetailsResponse GetFlightDetails(string origin, string destination);
    }
}
