using MongoDB.Driver;

namespace Booking.Core
{
    public interface IDbClient
    {
        IMongoCollection<Room> GetRoomsCollection();
        IMongoCollection<Client> GetClientsCollection();
        IMongoCollection<Worker> GetWorkersCollection();

    }
}
