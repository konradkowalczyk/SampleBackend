using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleBackend.DataLayer
{
    public interface IFlightRepository
    {
        IEnumerable<Flight> GetFlightsByLocations(string origin, string destination);
    }
}
