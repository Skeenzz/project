﻿using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using project.Server.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using project.Shared.Domain;
using project.Server.Configurations.Entities;

namespace project.Server.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Payments> Payments { get; set; }
        public DbSet<FlightBooking> FlightBooking { get; set; }
        public DbSet<VehicleBooking> VehicleBooking { get; set; }
        public DbSet<Flights> Flights { get; set; }
        public DbSet<Package> Packages { get; set; }
        public DbSet<Reviews> Reviews { get; set; }
        public DbSet<PackageBooking> PackageBookings { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new TypeOfVehicleSeedConfiguration());

            builder.ApplyConfiguration(new PaymentSeedConfiguration());

            builder.ApplyConfiguration(new FlightSeedConfiguration());
 
            builder.ApplyConfiguration(new RoleSeedConfiguration());

            builder.ApplyConfiguration(new UserSeedConfiguration());

            builder.ApplyConfiguration(new UserRoleSeedConfiguration());

            builder.ApplyConfiguration(new PackageSeedConfiguration());

            builder.ApplyConfiguration(new ReviewsSeedConfiguration());

        }

    }
}


