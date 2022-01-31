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
        public static readonly string BookingdetailEndpoint = $"{Prefix}/Bookingdetails";
        public static readonly string BookingEndpoint = $"{Prefix}/Booking";
        public static readonly string TypeOfVehiclesEndpoint = $"{Prefix}/TypeOfVehicle";
        public static readonly string CardEndpoint = $"{Prefix}/Card";
    }
}
