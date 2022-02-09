using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace project.Client.Static
{
    public static class Endpoints
    {
        private static readonly string Prefix = "api";
        public static readonly string FlightsEndpoint = $"{Prefix}/Flights";
        public static readonly string VehicleBookingEndpoint = $"{Prefix}/VehicleBooking";
        public static readonly string FlightBookingEndpoint = $"{Prefix}/FlightBooking";
        public static readonly string TypeOfVehiclesEndpoint = $"{Prefix}/TypeOfVehicle";
        public static readonly string CardEndpoint = $"{Prefix}/Card";
        public static readonly string AccountsEndpoint = $"{Prefix}/accounts";
        public static readonly string PackagesEndpoint = $"{Prefix}/Package";
        public static readonly string PackageBookingEndpoint = $"{Prefix}/PackageBooking";
        public static readonly string ReviewsEndpoint = $"{Prefix}/Reviews";
    }
}
