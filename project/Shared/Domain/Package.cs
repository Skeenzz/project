using System.ComponentModel.DataAnnotations;
using System;
namespace project.Shared.Domain
{
    public class Package : BaseDomainModel
    {
        [Required]
        public string PackageName { get; set; }
        [Required]
        public int PackageCapacity { get; set; }
        [Required]
        [DataType(DataType.Currency)]
        public int Price { get; set; }
    }
}
