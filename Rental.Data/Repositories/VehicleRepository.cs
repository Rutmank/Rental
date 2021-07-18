using Rental.Data.Models;

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
    }
}
