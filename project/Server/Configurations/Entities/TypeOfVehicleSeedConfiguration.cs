using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using project.Shared.Domain;

namespace project.Server.Configurations.Entities
{
    public class TypeOfVehicleSeedConfiguration : IEntityTypeConfiguration<TypeOfVehicle>
    {
        public void Configure(EntityTypeBuilder<TypeOfVehicle> builder)
        {
            builder.HasData(
                new TypeOfVehicle
                {
                    Id = 1,
                    Name = "BMW 318i",
                    TypeOfVehicles = "Sedan",
                    Seat = 5,
                    Capacity = 5,
                    Details = "Barely on the road and the BMW 3 Series Sedan is already leaving everything behind it, including conventions and expectations. Once again the icon displays how to reinvent itself. ",
                    Price = 50.50,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                new TypeOfVehicle
                {
                    Id = 2,
                    Name = "Mercedes S-Class",
                    TypeOfVehicles = "limo",
                    Seat = 8,
                    Capacity = 2,
                    Details = "There is no denying the high-quality performance, comfort and complete privacy of the Pullman Deluxe Edition Mercedes-Benz Limousine. Luxury is at its peak with this full-stretch service vehicle, custom-extended 100″(+250 cm) and cruising toward greatness at every turn. A very spacious and accommodating all-leather seating configuration, deep window tinting, rear-cabin/cockpit privacy divider, and hands-free intercom features make the Pullman Deluxe a compelling option for groups of politicians, entertainers, corporate outings or a VIP entourage seeking ultimate luxury and style on the road.",
                    Price = 40.40,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                 new TypeOfVehicle
                 {
                     Id = 3,
                     Name = "Mercedes GLB SUV",
                     TypeOfVehicles = "Hatchbacks",
                     Seat = 7,
                     Capacity = 6,
                     Details = "When it comes to SUVs, we’re spoilt for choice. There are small ones, big ones, rugged ones, fast ones, hybrids and even fully electric ones. But with such a great variety, it’s surprising that there are so few seven-seat SUVs with a premium badge – at least ones that aren’t the size of an aircraft carrier. That's where the Mercedes GLB steps in.",
                     Price = 45.13,
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 },
                 new TypeOfVehicle
                 {
                     Id = 4,
                     Name = "Chrysler Pacifica",
                     TypeOfVehicles = "minivan",
                     Seat = 7,
                     Capacity = 5,
                     Details = "The Chrysler Pacifica offers the only fully automatic All-Wheel-Drive System in the segment capable of transferring 100% of the available engine torque to the rear wheels or whichever wheels have more available traction.",
                     Price = 30.30,
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 }

            );
        }
    }
}
