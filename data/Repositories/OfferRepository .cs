using data.Infrastructure;
using domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.Repositories
{
    public class OfferRepository : RepositoryBase<operation>, IOfferRepository
    {
        public OfferRepository(DatabaseFactory dbFactory) : base(dbFactory)
        {

        }

    }

    public interface IOfferRepository : IRepository<operation>
    {

    }
}
