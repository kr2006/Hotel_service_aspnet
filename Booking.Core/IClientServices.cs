using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking.Core
{
    public interface IClientServices
    {
        List<Client> GetClients();
        Client AddClient(Client client);

        Client GetClient(string id);

        void DeleteClient(string Id);
        Client UpdateClient(Client client);



    }
}
