using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Shared.Domain
{
    public class Flights : BaseDomainModel
    {
        public string LeavingFrom { get; set; }
        public string GoingTo { get; set; }
        public DateTime Departing { get; set; }
        public DateTime Returning { get; set; }
    }
}
