using data.Infrastructure;
using domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.Repositories
{
    public class TimetableRepository : RepositoryBase<timetable>, ITimetableRepository
    {
        public TimetableRepository(DatabaseFactory dbFactory) : base(dbFactory)
        {

        }

       
    }

    public interface ITimetableRepository : IRepository<timetable>
    {

    }
}
