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
        public string LeavingFrom { get; set; }
        [Required]
        public string GoingTo { get; set; }
        [Required]
        public double Price { get; set; }
    }
}
