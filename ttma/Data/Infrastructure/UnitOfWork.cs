using Data;
using Data.Interfaces;
using Data.Models;
using Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  Data.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private jpadbContext dataContext;
        protected jpadbContext DataContext
        {
            get
            {
                return dataContext = dbFactory.DataContext;
            }
        }

        IDatabaseFactory dbFactory;
        public UnitOfWork(IDatabaseFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }
        public void Commit()
        {
            DataContext.SaveChanges();
        }



        private ICongeRepository congeRepository;
        public ICongeRepository CongeRepository
        {
            get { return congeRepository = new CongeRepository(dbFactory); }
        }


        public void Dispose()
        {
            DataContext.Dispose();
        }
        
    }
}
