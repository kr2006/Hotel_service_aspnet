using MongoDB.Bson.Serialization.Attributes;


namespace Booking.Core
{
  public class Client
    {
        [BsonId]
        [BsonRepresentation(MongoDB.Bson.BsonType.ObjectId)]
        public string Id { get; set; }
        public string Name { get; set; }    
        public string Surname { get; set; }
        public string Passport { get; set; }
    }
}
