using Microsoft.EntityFrameworkCore;
using Rental.Data.Models;

namespace Rental.Data
{
    public class RentalDbContext: DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=RUTMANK;Initial Catalog=RentalDB;Integrated Security=True;");
        }
    }
}
