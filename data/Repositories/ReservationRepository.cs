using data.Infrastructure;
using domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.Repositories
{
    class ReservationRepository : RepositoryBase<reservation>, IReservationRepository
    {
        public ReservationRepository(DatabaseFactory dbFactory) : base(dbFactory)
        {

        }

    }

    public interface IReservationRepository : IRepository<reservation>
    {

    }
}
