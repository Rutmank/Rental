using Rental.Data.Models;
using Rental.Data.Repositories;
using System;
using Xunit;

namespace Rental.Data.Tests
{
    public class ClientRepositoryTests
    {
        public static Client CreateDefaultClient()
        {
            return new Client
            {
                Name = "John",
                Surname = "Balodis",
                BirthDate = new DateTime(1992, 1, 15),
                CountryCode = "LV",
                IsMale = true
            };
        }

        [Fact]
        public void When_add_new_client_Then_client_can_be_retrived()
        {
            var repo = new ClientRepository();
            var client = CreateDefaultClient();

            repo.Add(client);

            var clientFromRepository = repo.Get(client.Id);
            Assert.NotNull(clientFromRepository);
            Assert.Equal(client.Name, clientFromRepository.Name);
            Assert.Equal(client.IsMale, clientFromRepository.IsMale);
        }
    }
}
