using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Shared.Domain
{
    public class VehicleBooking : BaseDomainModel
    {
        [Required]
        public DateTime Date { get; set; }
        [Required]
        public string Destination { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Notes { get; set; }
        [Required]
        public int? VehiclesId { get; set; }
        public virtual Vehicle Vehicles { get; set; }
    }
}
