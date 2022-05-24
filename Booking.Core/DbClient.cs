
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace Booking.Core
{
    public class DbClient : IDbClient
    {
        private readonly IMongoCollection<Room> _rooms;
        private readonly IMongoCollection<Client> _clients;
        private readonly IMongoCollection<Worker> _workers;

        public DbClient(IOptions<BookingDbConfig> bookingDbConfig)
        {
            var client = new MongoClient(bookingDbConfig.Value.Connection_String);
            var database = client.GetDatabase(bookingDbConfig.Value.Database_Name);
            _rooms = database.GetCollection<Room>(bookingDbConfig.Value.Rooms_Collection_Name);
            _clients = database.GetCollection<Client>(bookingDbConfig.Value.Clients_Collection_Name);
            _workers = database.GetCollection<Worker>(bookingDbConfig.Value.Workers_Collection_Name);
        }

        public IMongoCollection<Client> GetClientsCollection()
        {
            return _clients;
        }

        public IMongoCollection<Room> GetRoomsCollection()
        {
            return _rooms;
        }

        public IMongoCollection<Worker> GetWorkersCollection()
        {
            return _workers;
        }
    }
}
