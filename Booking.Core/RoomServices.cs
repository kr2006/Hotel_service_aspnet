using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace Booking.Core
{
    public class RoomServices : IRoomServices
    {
        private readonly IMongoCollection<Room> _rooms;
        public RoomServices(IDbClient dbClient)
        {
            _rooms = dbClient.GetRoomsCollection();
        }
        public List<Room> GetRooms()
        {
            return _rooms.Find(room => true).ToList();
        }

        public Room AddRoom(Room room)
        {
            _rooms.InsertOne(room);
            return room;
        }

        public Room GetRoom(string id)
        {
            return _rooms.Find(room => room.Id == id).First();
        }

        public void DeleteRoom(string id)
        {
            _rooms.DeleteOne(room => room.Id == id);
        }

        public Room UpdateRoom(Room room)
        {
            GetRoom(room.Id);
            _rooms.ReplaceOne(r => r.Id == room.Id, room);
            return room;
        }
    }
}
