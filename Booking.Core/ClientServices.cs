using MongoDB.Driver;
using System.Collections.Generic;

namespace Booking.Core
{
    public class ClientServices : IClientServices
    {
        private readonly IMongoCollection<Client> _clients;
        public ClientServices(IDbClient dbClient)
        {
            _clients = dbClient.GetClientsCollection();
        }

        public Client AddClient(Client client)
        {
            _clients.InsertOne(client);
            return client;
        }

        public List<Client> GetClients()
        {
            return _clients.Find(client => true).ToList();  
        }

        public Client GetClient(string id)
        {
            return _clients.Find(client => client.Id == id).First();
        }

        public void DeleteClient(string id)
        {
            _clients.DeleteOne(client => client.Id == id);
        }

        public Client UpdateClient(Client client)
        {
            GetClient(client.Id);
            _clients.ReplaceOne(c => c.Id == client.Id, client);
            return client;
        }
    }
}
