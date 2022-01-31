using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Shared.Domain
{
    public class Booking : BaseDomainModel
    {
        public int Passenger { get;set; }
        public int LeavingFromId { get; set; }
        public virtual Flights LeavingFrom { get; set; }
        public int GoingToId { get; set; }
        public virtual Flights GoingTo { get; set; }
        public int PriceId { get; set; }
        public virtual Flights Price { get; set; }
        public DateTime Departing { get; set; }
        public DateTime Returning { get; set; }
    }
}
