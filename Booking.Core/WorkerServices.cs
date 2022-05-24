using MongoDB.Driver;
using System.Collections.Generic;

namespace Booking.Core
{
    public class WorkerServices : IWorkerServices
    {
        private readonly IMongoCollection<Worker> _workers;

        public WorkerServices()
        {
        }

        public WorkerServices(IDbClient dbClient)
        {
            _workers = dbClient.GetWorkersCollection();
        }

        public Worker AddWorker(Worker worker)
        {
            _workers.InsertOne(worker);
            return worker;

        }

        public void DeleteWorker(string id)
        {
            _workers.DeleteOne(worker => worker.Id == id);
        }

        public Worker GetWorker(string id)
        {
            return _workers.Find(worker => worker.Id == id).First();
        }

        public List<Worker> GetWorkers()
        {
            return _workers.Find(worker => true).ToList();
        }

        public Worker UpdateWorker(Worker worker)
        {
            GetWorker(worker.Id);
            _workers.ReplaceOne(w => w.Id == worker.Id, worker);
            return worker;
        }
    }
}
