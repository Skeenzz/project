using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Shared.Domain
{
    public class BookingDetails : BaseDomainModel
    {
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public string Destination { get; set; }
        public string Address { get; set; }
    }
}
