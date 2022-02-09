using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Shared.Domain
{
    public class PaymentConfirmation : BaseDomainModel
    {
        public int PaymentId { get; set; }
        public virtual Payments Payment { get; set; }
        public int VehiclePriceId { get; set; }
        public virtual VehicleBooking vehiclebooking { get; set; }
        public int FlightPriceId { get; set; }
        public virtual FlightBooking flightbooking { get; set; }
        public int totalPrice { get; set; }

    }
}
