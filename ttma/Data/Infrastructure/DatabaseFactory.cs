using Data;
using Data.Interfaces;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private jpadbContext dataContext;
        public jpadbContext DataContext
        {
            get { return dataContext; }
        }

        public DatabaseFactory()
        {
            dataContext = new jpadbContext();
        }
        protected override void DisposeCore()
        {
            if (DataContext != null)
                DataContext.Dispose();
        }

    }
}
