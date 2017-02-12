using data.Infrastructure;
using domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.Repositories
{
    class DemandeRepository : RepositoryBase<demande>, IDemandeRepository
    {
            public DemandeRepository(DatabaseFactory dbFactory) : base(dbFactory)
            {

            }

        }

        public interface IDemandeRepository : IRepository<demande>
        {

        }
    }

