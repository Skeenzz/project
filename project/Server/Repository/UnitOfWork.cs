using project.Server.Data;
using project.Server.IRepository;
using project.Server.Models;
using project.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace project.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private IGenericRepository<Vehicle> _vehicle;
        private IGenericRepository<VehicleBooking> _VehicleBooking;
        private IGenericRepository<Flights> _flights;
        private IGenericRepository<Card> _card;
        private IGenericRepository<FlightBooking> _FlightBooking;

        private UserManager<ApplicationUser> _userManager;
        public UnitOfWork(ApplicationDbContext context,
        UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IGenericRepository<Vehicle> Vehicle
            => _vehicle ??= new GenericRepository<Vehicle>(_context);
        public IGenericRepository<VehicleBooking> VehicleBooking
            => _VehicleBooking ??= new GenericRepository<VehicleBooking>(_context);
        public IGenericRepository<Flights> Flights
            => _flights ??= new GenericRepository<Flights>(_context);
        public IGenericRepository<Card> Card
            => _card ??= new GenericRepository<Card>(_context);
        public IGenericRepository<FlightBooking> FlightBooking
            => _FlightBooking ??= new GenericRepository<FlightBooking>(_context);

       

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(HttpContext httpContext)
        {
            //To be implemented
            // string user = "System";

            var userId = httpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var user = await _userManager.FindByIdAsync(userId);

            var entries = _context.ChangeTracker.Entries()
                .Where(q => q.State == EntityState.Modified ||
                    q.State == EntityState.Added);

            foreach (var entry in entries)
            {
                ((BaseDomainModel)entry.Entity).DateUpdated = DateTime.Now;
                ((BaseDomainModel)entry.Entity).UpdatedBy = user.UserName;
                if (entry.State == EntityState.Added)
                {
                    ((BaseDomainModel)entry.Entity).DateCreated = DateTime.Now;
                    ((BaseDomainModel)entry.Entity).CreatedBy = user.UserName;
                }
            }

            await _context.SaveChangesAsync();
        }
    }
}