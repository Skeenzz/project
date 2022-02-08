using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Shared.Domain
{
    public class Flights : BaseDomainModel
    {
        
        [Required]
        public string GoingTo { get; set; }
        public string imgName_flight { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public double Price { get; set; }
    }
}
