using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using project.Shared.Domain;

namespace project.Server.Configurations.Entities
{
    public class FlightSeedConfiguration : IEntityTypeConfiguration<Flights>
    {
        public void Configure(EntityTypeBuilder<Flights> builder)
        {
            builder.HasData(
                new Flights
                {
                    Id = 1,
                    LeavingFrom = "Singapore",
                    GoingTo = "japan",
                    Price = 780.00,
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    CreatedBy = "System",
                    UpdatedBy = "System"
                },
                 new Flights
                 {
                     Id = 2,
                     LeavingFrom = "Singapore",
                     GoingTo = "USA",
                     Price = 1780.00,
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 },
                  new Flights
                  {
                      Id = 3,
                      LeavingFrom = "Singapore",
                      GoingTo = "china",
                      Price = 580.00,
                      DateCreated = DateTime.Now,
                      DateUpdated = DateTime.Now,
                      CreatedBy = "System",
                      UpdatedBy = "System"
                  }
            );
        }             
    }
}
