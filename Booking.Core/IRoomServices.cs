using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Core
{
    public interface IRoomServices
    {
        List<Room> GetRooms();
        Room GetRoom(string id);
        Room AddRoom(Room room);    

        void DeleteRoom(string Id);

        Room UpdateRoom(Room room); 

     
    }
}
