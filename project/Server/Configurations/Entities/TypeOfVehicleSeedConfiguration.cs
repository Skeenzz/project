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
                    Seat = 4,
                    Capacity = 2,
                    Price = 40,
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
                    Seat = 5,
                    Capacity = 2,
                    Price = 60,
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
                     Seat = 5,
                     Capacity = 3,
                     Price = 75,
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
                     Seat = 5,
                     Capacity = 3,
                     Price = 80,
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
                     Seat = 5,
                     Capacity = 4,
                     Price = 85,
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 },
                 new Vehicle
                 {
                     Id = 6,
                     Name = "Ford Mustang Convertible",
                     TypeOfVehicles = "Convertible Car",
                     Seat = 4,
                     Capacity = 2,
                     Price = 90,
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 },
                 new Vehicle
                 {
                     Id = 7,
                     Name = "Dodge Challenger",
                     TypeOfVehicles = "Sporty Car",
                     Seat = 4,
                     Capacity = 2,
                     Price = 120,
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 },
                 new Vehicle
                 {
                     Id = 8,
                     Name = "INFINITI Q50",
                     TypeOfVehicles = "Full Size Elite Car",
                     Seat = 5,
                     Capacity = 2,
                     Price = 150,
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 },
                 new Vehicle
                 {
                     Id = 9,
                     Name = " Audi A5 Sportback",
                     TypeOfVehicles = "Full Size Elite Car",
                     Seat = 5,
                     Capacity = 2,
                     Price = 180,
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 },
                 new Vehicle
                 {
                     Id = 10,
                     Name = "BMW 228i Gran Coupe",
                     TypeOfVehicles = "Standard Elite Car",
                     Seat = 5,
                     Capacity = 2,
                     Price = 180,
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 },
                 new Vehicle
                 {
                     Id = 11,
                     Name = "Tesla Model S",
                     TypeOfVehicles = "Luxury Elite Electric Car",
                     Seat = 5,
                     Capacity = 4,
                     Price = 180,
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 },
                 new Vehicle
                 {
                     Id = 12,
                     Name = "Chevrolet Impala",
                     TypeOfVehicles = "Premium Special Car",
                     Seat = 5,
                     Capacity = 4,
                     Price = 180,
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 },
                 new Vehicle
                 {
                     Id = 13,
                     Name = "BMW 5 Series ",
                     TypeOfVehicles = "Premium Elite Car",
                     Seat = 5,
                     Capacity = 4,
                     Price = 180,
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 },
                 new Vehicle
                 {
                     Id = 14,
                     Name = "Nissan Maxima ",
                     TypeOfVehicles = "Premium Car",
                     Seat = 5,
                     Capacity = 4,
                     Price = 180,
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 },
                 new Vehicle
                 {
                     Id = 15,
                     Name = "Chrysler 300",
                     TypeOfVehicles = "Luxury Car",
                     Seat = 5,
                     Capacity = 4,
                     Price = 190,
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 },
                 new Vehicle
                 {
                     Id = 16,
                     Name = "Maserati Ghibli",
                     TypeOfVehicles = "Executive Luxury Car",
                     Seat = 5,
                     Capacity = 3,
                     Price = 190,
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 },
                  new Vehicle
                  {
                      Id = 17,
                      Name = "Mercedes AMG E53",
                      TypeOfVehicles = "Executive Luxury Car",
                      Seat = 5,
                      Capacity = 3,
                      Price = 200,
                      DateCreated = DateTime.Now,
                      DateUpdated = DateTime.Now,
                      CreatedBy = "System",
                      UpdatedBy = "System"
                  },
                 new Vehicle
                 {
                     Id = 18,
                     Name = "BMW 7 Series",
                     TypeOfVehicles = "Large Executive Luxury Car",
                     Seat = 5,
                     Capacity = 4,
                     Price = 250,
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 },
                 new Vehicle
                 {
                     Id = 19,
                     Name = "Mercedes Benz S Class",
                     TypeOfVehicles = "Large Executive Luxury Car",
                     Seat = 5,
                     Capacity = 4,
                     Price = 250,
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 },
                 new Vehicle
                 {
                     Id = 20,
                     Name = "Porsche Panamera",
                     TypeOfVehicles = "Large Executive Luxury Car",
                     Seat = 5,
                     Capacity = 4,
                     Price = 250,
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 },
                  new Vehicle
                  {
                      Id = 21,
                      Name = "Nissan Kicks",
                      TypeOfVehicles = "Compact SUV",
                      Seat = 5,
                      Capacity = 3,
                      Price = 120,
                      DateCreated = DateTime.Now,
                      DateUpdated = DateTime.Now,
                      CreatedBy = "System",
                      UpdatedBy = "System"
                  },
                 new Vehicle
                 {
                     Id = 22,
                     Name = "Nissan Rogue",
                     TypeOfVehicles = "MidSize SUV",
                     Seat = 5,
                     Capacity = 4,
                     Price = 150,
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 },
                  new Vehicle
                  {
                      Id = 23,
                      Name = "Ford Edge ",
                      TypeOfVehicles = "Standard SUV",
                      Seat = 5,
                      Capacity = 5,
                      Price = 180,
                      DateCreated = DateTime.Now,
                      DateUpdated = DateTime.Now,
                      CreatedBy = "System",
                      UpdatedBy = "System"
                  },
                 new Vehicle
                 {
                     Id = 24,
                     Name = "Chevrolet Tahoe ",
                     TypeOfVehicles = "Full Size SUV",
                     Seat = 7,
                     Capacity = 3,
                     Price = 200,
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 },
                 new Vehicle
                 {
                     Id = 25,
                     Name = "Infiniti QX80",
                     TypeOfVehicles = "Luxury SUV",
                     Seat = 7,
                     Capacity = 3,
                     Price = 250,
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 },
                 new Vehicle
                 {
                     Id = 26,
                     Name = "Cadillac XT4",
                     TypeOfVehicles = "Standard Elite SUV",
                     Seat = 5,
                     Capacity = 3,
                     Price = 180,
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 },
                 new Vehicle
                 {
                     Id = 27,
                     Name = "Volkswagen Atlas",
                     TypeOfVehicles = "Premium Crossover",
                     Seat = 7,
                     Capacity = 3,
                     Price = 180,
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 },
                 new Vehicle
                 {
                     Id = 28,
                     Name = "Mercedes Benz GLE",
                     TypeOfVehicles = "Luxury Elite SUV",
                     Seat = 5,
                     Capacity = 3,
                     Price = 220,
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 },
                  new Vehicle
                  {
                      Id = 29,
                      Name = "Chevy Suburban",
                      TypeOfVehicles = "Premium SUV",
                      Seat = 8,
                      Capacity = 7,
                      Price = 220,
                      DateCreated = DateTime.Now,
                      DateUpdated = DateTime.Now,
                      CreatedBy = "System",
                      UpdatedBy = "System"
                  },
                 new Vehicle
                 {
                     Id = 30,
                     Name = "BMW X3 ",
                     TypeOfVehicles = "Premium Elite SUV",
                     Seat = 5,
                     Capacity = 4,
                     Price = 250,
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 },
                  new Vehicle
                  {
                      Id = 31,
                      Name = "Chrysler Pacifica ",
                      TypeOfVehicles = "7 Passenger Minivan",
                      Seat = 7,
                      Capacity = 5,
                      Price = 200,
                      DateCreated = DateTime.Now,
                      DateUpdated = DateTime.Now,
                      CreatedBy = "System",
                      UpdatedBy = "System"
                  },
                 new Vehicle
                 {
                     Id = 32,
                     Name = "Toyota Sienna",
                     TypeOfVehicles = "8 Passenger Minivan",
                     Seat = 8,
                     Capacity = 5,
                     Price = 220,
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 },
                  new Vehicle
                  {
                      Id = 33,
                      Name = "Ford Transit Wagon",
                      TypeOfVehicles = "12 Passenger Van",
                      Seat = 12,
                      Capacity = 12,
                      Price = 230,
                      DateCreated = DateTime.Now,
                      DateUpdated = DateTime.Now,
                      CreatedBy = "System",
                      UpdatedBy = "System"

                  },
                 new Vehicle
                 {
                     Id = 34,
                     Name = "Ford Transit Wagon",
                     TypeOfVehicles = "15 Passenger Van",
                     Seat = 15,
                     Capacity = 2,
                     Price = 250,
                     DateCreated = DateTime.Now,
                     DateUpdated = DateTime.Now,
                     CreatedBy = "System",
                     UpdatedBy = "System"
                 }
            );
        }
    }
}
