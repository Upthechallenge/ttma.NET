using data.Infrastructure;
using domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.Repositories
{
    public class Insurance_offerRepository : RepositoryBase<insurance_offer>,
   IInsurance_offerRepository
    {
        public Insurance_offerRepository(DatabaseFactory dbFactory)
        : base(dbFactory)
        {
        }
    }
    public interface IInsurance_offerRepository : IRepository<insurance_offer> { }
}
