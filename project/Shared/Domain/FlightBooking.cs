using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Tasks;

namespace project.Shared.Domain
{
    public class FlightBooking : BaseDomainModel
    {
        
        [Required]
        public int Passenger { get;set; }
        [Required]
        public int? FlightsId { get; set; }
        public virtual Flights Flights { get; set; }
        [Required]
        public DateTime Departing { get; set; }
        [Required]
        public DateTime Returning { get; set; }
    }
}
