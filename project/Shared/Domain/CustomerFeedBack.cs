using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project.Shared.Domain;

namespace project.Server.Domain
{
    public class CustomerFeedBack : BaseDomainModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Text { get; set; }
    }
}