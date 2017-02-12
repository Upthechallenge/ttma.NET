using data.Infrastructure;
using domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.Repositories
{
    public class EventRepository : RepositoryBase<evenement>, IEventRepository
    {
        public EventRepository(DatabaseFactory dbFactory) : base(dbFactory)
        {

        }

    }

    public interface IEventRepository : IRepository<evenement>
    {

    }
}
