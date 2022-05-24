using Booking.Core;
using Microsoft.AspNetCore.Mvc;

namespace Booking.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ClientsController : ControllerBase
    {
        private readonly IClientServices _clientServices;
        public ClientsController(IClientServices clientServices)
        {
            _clientServices = clientServices;
        }

        [HttpGet]
        public IActionResult GetClients()
        {
            return Ok(_clientServices.GetClients());
        }

        [HttpGet("{id}", Name = "GetClient")]
        public IActionResult GetClient(string id)
        {
            return Ok(_clientServices.GetClient(id));
        }

        [HttpPost]
        public IActionResult AddClient(Client client)
        {
            _clientServices.AddClient(client);
            return Ok(client);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteClient(string id)
        {
            _clientServices.DeleteClient(id);
            return NoContent();
        }

        [HttpPut]
        public IActionResult UpdateClient(Client client)
        {
            return Ok(_clientServices.UpdateClient(client));
        }
    }
}


