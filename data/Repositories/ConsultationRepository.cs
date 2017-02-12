using data.Infrastructure;
using domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.Repositories
{
    public class ConsultationRepository : RepositoryBase<demandeconsultationenligne>, IConsultationRepository
    {
        public ConsultationRepository(DatabaseFactory dbFactory) : base(dbFactory)
        {

        }

    }

    public interface IConsultationRepository : IRepository<demandeconsultationenligne>
    {

    }
}
