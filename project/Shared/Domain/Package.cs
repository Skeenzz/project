using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Shared.Domain
{
    public class Package : BaseDomainModel
    {
        [Required]
        public string PackageName { get; set; }
        [Required]
        public int PackageCapacity { get; set; }
        [Required]
        public int Price { get; set; }
    }
}
