using project.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        IGenericRepository<TypeOfVehicle> TypeOfVehicle { get; }
        IGenericRepository<VehicleBooking> VehicleBookings { get; }
        IGenericRepository<Flights> Flights { get; }
        IGenericRepository<Card> Card { get; }
        IGenericRepository<FlightBooking> FlightBookings { get; }
    }
}