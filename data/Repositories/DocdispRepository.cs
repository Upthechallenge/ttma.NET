﻿using data.Infrastructure;
using domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.Repositories
{
    public class DocdispRepository : RepositoryBase<doctordisponibility>, IDocdispRepository
    {
        public DocdispRepository(DatabaseFactory dbFactory) : base(dbFactory)
        {

        }

    }

    public interface IDocdispRepository : IRepository<doctordisponibility>
    {

    }
}
