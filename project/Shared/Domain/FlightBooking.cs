using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Shared.Domain
{
    public class FlightBooking : BaseDomainModel
    {
        public int Passenger { get;set; }
        public int? FlightsId { get; set; }
        public virtual Flights Flights { get; set; }
        public DateTime Departing { get; set; }
        public DateTime Returning { get; set; }
    }
}
