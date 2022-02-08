using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Shared.Domain
{
    public class PackageBooking : BaseDomainModel
    {
        public string Address { get; set; }
        public string Destination { get; set; }
        public int Amount { get; set; }
        public int? PackageId { get; set; }
        public DateTime PickUpDate { get; set; }
      
        public virtual Package packages { get; set; }
    }
}
