using data.Infrastructure;
using domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.Repositories
{
  public  class StaffRepository : RepositoryBase<staff>, IStaffRepository
    {
        public StaffRepository(DatabaseFactory dbFactory) : base(dbFactory)
        {

        }

    }
    public interface IStaffRepository : IRepository<staff>
    {

    }
}
