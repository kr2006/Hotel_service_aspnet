using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Core
{
    public interface IWorkerServices
    {
        List<Worker> GetWorkers();
        Worker AddWorker(Worker worker);

        Worker GetWorker(string id);

        void DeleteWorker(string Id);
        Worker UpdateWorker(Worker worker);


    }
}
