using data.Infrastructure;
using domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.Repositories
{
    class UserRepository : RepositoryBase<user>, IUserRepository
    {
        public UserRepository(DatabaseFactory dbFactory) : base(dbFactory)
        {

        }

    }

    public interface IUserRepository : IRepository<user>
    {

    }
}
