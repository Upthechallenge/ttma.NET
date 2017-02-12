using data.Infrastructure;
using domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.Repositories
{
    public class DoctorRepository : RepositoryBase<doctor>, IDoctorRepository
    {
        public DoctorRepository(DatabaseFactory dbFactory) : base(dbFactory)
        {

        }

    }

    public interface IDoctorRepository : IRepository<doctor>
    {

    }
}
