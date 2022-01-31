using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Shared.Domain
{
    public class TypeOfVehicles : BaseDomainModel
    {
        public string Name { get; set; }
        public string TypeOfVehicle { get; set; }
        public int Seat { get; set; }
        public int Capacity { get; set; }
        public string Details { get; set; }
    }
}
