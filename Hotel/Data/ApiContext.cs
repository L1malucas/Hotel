using Microsoft.EntityFrameworkCore;
using Hotel.Models;

namespace Hotel.Data
{
    public class ApiContext : DbContext 
    {
        public DbSet<HotelBooking> Bookings { get; set; }   

        public ApiContext(DbContextOptions<ApiContext> options) : base(options) { }
    }
}
