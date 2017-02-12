using data.Infrastructure;
using domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.Repositories
{
    public class CongeRepository : RepositoryBase<conge>, ICongeRepository
    {
        public CongeRepository(DatabaseFactory dbFactory) : base(dbFactory)
        {

        }

       
    }

    public interface ICongeRepository : IRepository<conge>
    {

    }
}
