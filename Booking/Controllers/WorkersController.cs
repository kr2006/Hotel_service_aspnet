using Booking.Core;
using Microsoft.AspNetCore.Mvc;

namespace Booking.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class WorkersController : ControllerBase
    {
        private readonly IWorkerServices _workerServices;
        public WorkersController(IWorkerServices workerServices)
        {
            _workerServices = workerServices;
        }

        [HttpGet]
        public IActionResult GetWorkers()
        {
            return Ok(_workerServices.GetWorkers());
        }

        [HttpGet("{id}", Name = "GetWorker")]
        public IActionResult GetWorker(string id)
        {
            return Ok(_workerServices.GetWorker(id));
        }

        [HttpPost]
        public IActionResult AddWorker(Worker worker)
        {
            _workerServices.AddWorker(worker);
            return Ok(worker);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteWorker(string id)
        {
            _workerServices.DeleteWorker(id);
            return NoContent();
        }

        [HttpPut]
        public IActionResult UpdateWorker(Worker worker)
        {
            return Ok(_workerServices.UpdateWorker(worker));
        }
    }
}


