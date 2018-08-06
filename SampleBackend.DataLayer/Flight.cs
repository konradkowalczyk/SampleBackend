using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleBackend.DataLayer
{
    public class Flight
    {
        public long Id { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime FlightDate { get; set; }
        public int SeatsTotal { get; set; }
        public int SeatsFree { get; set; }
    }
}
