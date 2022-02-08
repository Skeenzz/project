﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.Shared.Domain
{
    public class Vehicle : BaseDomainModel
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string TypeOfVehicles { get; set; }
        [Required]
        public string imgName { get; set; }
        [Required]
        public int Seat { get; set; }
        [Required]
        public int Capacity { get; set; }
        [Required]
        public double Price { get; set; }
        [Required]
        public string Babyfriendly { get; set; }
        [Required]
        public string Petfriendly { get; set; }

    }
}
