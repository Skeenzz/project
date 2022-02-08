using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using project.Shared.Domain;

namespace project.Server.Configurations.Entities
{
    public class TypeOfVehicleSeedConfiguration : IEntityTypeConfiguration<Vehicle>
    {
        public void Configure(EntityTypeBuilder<Vehicle> builder)
        {
            builder.HasData(
                new Vehicle
                {
                    Id = 1,
                    Name = "Mitsubishi Mirage",
                    TypeOfVehicles = "Economy Car",
                    imgName = "data:image/jpeg;base64,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",
                    Seat = 4,
                    Capacity = 2,
                    Price = 40,
                    Babyfriendly = "Yes",
                    Petfriendly = "Yes",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new Vehicle
                {
                    Id = 2,
                    Name = "Nissan Versa",
                    TypeOfVehicles = "Compact Car",
                    imgName = "Url",
                    Seat = 5,
                    Capacity = 2,
                    Price = 60,
                    Babyfriendly = "Yes",
                    Petfriendly = "No",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                 new Vehicle
                 {
                     Id = 3,
                     Name = "Toyota Corolla",
                     TypeOfVehicles = "MidSize Car",
                     imgName = "Url",
                     Seat = 5,
                     Capacity = 3,
                     Price = 75,
                     Babyfriendly = "Yes",
                     Petfriendly = "Yes",
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 },
                 new Vehicle
                 {
                     Id = 4,
                     Name = "Volkswagen Jetta",
                     TypeOfVehicles = "Standard Car",
                     imgName = "Url",
                     Seat = 5,
                     Capacity = 3,
                     Price = 80,
                     Babyfriendly = "Yes",
                     Petfriendly = "Yes",
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 },
                 new Vehicle
                 {
                     Id = 5,
                     Name = "Chevy Malibu",
                     TypeOfVehicles = "Full Size Car",
                     imgName = "Url",
                     Seat = 5,
                     Capacity = 4,
                     Price = 85,
                     Babyfriendly = "Yes",
                     Petfriendly = "Yes",
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 }
            );
        }
    }
}
