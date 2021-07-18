using Rental.Data.Models;
using System;
using System.Linq;


namespace Rental.Data.Repositories
{
    public class ClientRepository
    {
        public void Add(Client client)
        {
            using (var db = new RentalDbContext())
            {
                db.Clients.Add(client);
                db.SaveChanges();
            }
        }

        public Client Get(int clientId)
        {
            using (var db = new RentalDbContext())
            {
               return db.Clients.Find(clientId);
            }
        }

        public Client[] Get()
        {
            using (var db = new RentalDbContext())
            {
                return db.Clients.ToArray();
            }
        }

        public void Update(Client client)
        {
            using (var db = new RentalDbContext())
            {
                db.Clients.Update(client);
                db.SaveChanges();
            }
        }
    }
}
