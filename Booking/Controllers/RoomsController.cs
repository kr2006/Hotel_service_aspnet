using Booking.Core;
using Microsoft.AspNetCore.Mvc;


namespace Booking.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RoomsController : ControllerBase
    {
        private readonly IRoomServices _roomServices;
        public RoomsController(IRoomServices roomServices)
        {
            _roomServices = roomServices;
        }

        [HttpGet]
        public IActionResult GetRooms()
        {
            return Ok(_roomServices.GetRooms());
        }
        [HttpGet("{id}", Name = "GetRoom")]
        public IActionResult GetBook(string id)
        {
            return Ok(_roomServices.GetRoom(id));
        }
        

        [HttpPost]
        public IActionResult AddRoom(Room room)
        {
            _roomServices.AddRoom(room);
            return CreatedAtRoute("GetRoom", new { id = room.Id }, room);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteRoom(string id)
        {
            _roomServices.DeleteRoom(id);
            return NoContent();
        }

        [HttpPut]
        public IActionResult UpdateRoom(Room room)
        {
            return Ok(_roomServices.UpdateRoom(room));  
        }

    }
}
