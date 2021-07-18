using Rental.Data.Models;
using Rental.Data.Repositories;
using Xunit;

namespace Rental.Data.Tests
{
    public class VehicleRepositoryTests
    {
        [Fact]
        public void When_add_new_vehicle_Then_client_can_be_retrived()
        {
            var repo = new VehicleRepository();
            var vehicle = new Vehicle
            {
                Brand = "BMW",
                Model = "i5",
                HorsePower = 250,
                Client = ClientRepositoryTests.CreateDefaultClient()
            };

            repo.Add(vehicle);

            var vehicleFromRepository = repo.Get(vehicle.Id);
            Assert.NotNull(vehicleFromRepository);
        }
    }
}
