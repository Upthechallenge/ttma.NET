 

using  Data.Infrastructure;
using  Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Data.Models;

namespace  Data.Repositories
{
    public class CongeRepository :RepositoryBase<conge>,ICongeRepository
    {
        public CongeRepository(IDatabaseFactory dbFactory)
            : base(dbFactory)
        {

        }
    }
    public interface ICongeRepository : IRepository<conge>
    {

    }
}
