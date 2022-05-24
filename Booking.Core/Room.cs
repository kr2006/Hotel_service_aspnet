using MongoDB.Bson.Serialization.Attributes;

namespace Booking.Core
{
    
    public class Room
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public int RoomNumber  { get; set; }
        public int RoomFloor { get; set; }
        public int RoomCapacity { get; set; }
        public int RoomPrice { get; set; }
        public string RoomType { get; set; }

    }
}
