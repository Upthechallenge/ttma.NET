using data.Infrastructure;
using domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.Repositories
{
    public class AuthentificationRepository : RepositoryBase<staff>, IAuthentificationRepository
    {
        public AuthentificationRepository(DatabaseFactory dbFactory) : base(dbFactory)
        {

        }

    }

    public interface IAuthentificationRepository : IRepository<staff>
    {

    }
}
