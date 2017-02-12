using data.Infrastructure;
using domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.Repositories
{
    public class TransportCompagnieRepository : RepositoryBase<transportcompagnie>, ITransportCompagnieRepository
    {
        public TransportCompagnieRepository(DatabaseFactory dbFactory) : base(dbFactory)
        {

        }

    }

    public interface ITransportCompagnieRepository : IRepository<transportcompagnie>
    {

    }
}
