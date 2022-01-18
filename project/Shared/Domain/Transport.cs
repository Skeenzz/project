using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Shared.Domain
{
    public class Transport : BaseDomainModel
    {
        public int AmountOfTransport { get; set; }
        public virtual TypeOfVehicles TypeOfVehicles {get;set;}
    }
}
