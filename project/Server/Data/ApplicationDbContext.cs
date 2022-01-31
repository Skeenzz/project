using IdentityServer4.EntityFramework.Options;
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
        public DbSet<TypeOfVehicle> TypeOfVehicles { get; set; }
        public DbSet<Card> Card { get; set; }
        public DbSet<Booking> Booking { get; set; }
        public DbSet<BookingDetails> BookingDetails { get; set; }
        public DbSet<Flights> Flights { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new TypeOfVehicleSeedConfiguration());

            builder.ApplyConfiguration(new CardSeedConfiguration());

            builder.ApplyConfiguration(new FlightSeedConfiguration());
 
            builder.ApplyConfiguration(new RoleSeedConfiguration());

            builder.ApplyConfiguration(new UserSeedConfiguration());

            builder.ApplyConfiguration(new UserRoleSeedConfiguration());
        }

    }
}
