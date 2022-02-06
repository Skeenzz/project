using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Shared.Domain
{
    public class VehicleBooking : BaseDomainModel
    {
        public DateTime Date { get; set; }
        public int Passenger { get; set; }
        public int luggage { get; set; }
        public string Destination { get; set; }
        public string Address { get; set; }
        public int? TypeOfVehicleId { get; set; }
        public virtual Vehicle TypeOfVehicle { get; set; }
        public int? PriceId { get; set; }
        public virtual Vehicle Price { get; set; }
    }
}
