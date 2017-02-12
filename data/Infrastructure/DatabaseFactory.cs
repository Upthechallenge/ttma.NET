using data.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace data.Infrastructure
{
    public class DatabaseFactory : Disposable, IDatabaseFactory
    {
        private jpadbContext dataContext = null;
        public jpadbContext Get()// ou public TestContext DataContext { get { return dataContext; } }
        {
            return dataContext ?? (dataContext = new jpadbContext());
        }

        /*public DatabaseFactory()
        {
            dataContext = new TestContext();
        }*/

        protected override void DisposeCore()
        {
            if (dataContext != null)
                dataContext.Dispose();
        }
    }

}
