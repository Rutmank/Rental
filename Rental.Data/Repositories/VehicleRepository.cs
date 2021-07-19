using Rental.Data.Models;
using System.Linq;

namespace Rental.Data.Repositories
{
    public class VehicleRepository
    {
        public void Add(Vehicle vehicle)
        {
            using (var db = new RentalDbContext())
            {
                db.Vehicles.Add(vehicle);
                db.SaveChanges();
            }
        }

        public Vehicle Get(int vehicleId)
        {
            using (var db = new RentalDbContext())
            {
                return db.Vehicles.Find(vehicleId);
            }
        }

        public Vehicle[] Get()
        {
            using (var db = new RentalDbContext())
            {
                return db.Vehicles.ToArray();
            }
        }

        public void Update(Vehicle vehicle)
        {
            using (var db = new RentalDbContext())
            {
                db.Vehicles.Update(vehicle);
                db.SaveChanges();
            }
        }

        public void Delete(Vehicle vehicle)
        {
            using (var db = new RentalDbContext())
            {
                db.Vehicles.Remove(vehicle);
                db.SaveChanges();
            }
        }
    }
}
