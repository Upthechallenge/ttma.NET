using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using System.Data.Entity;

using data.Models;

namespace data.Infrastructure
{
    public abstract class RepositoryBase<T> where T : class
    {
        private jpadbContext dataContext;
        private IDbSet<T> dbset;
        IDatabaseFactory databaseFactory;

        
        protected RepositoryBase(DatabaseFactory dbFactory)
        {
            this.databaseFactory = dbFactory;
            dbset = DataContext.Set<T>();


        }
        protected jpadbContext DataContext
        {
            get { return dataContext ??( dataContext = databaseFactory.Get()); }
        }

        public virtual void Edit(T entity)
        {
            dbset.Attach(entity); dataContext.Entry(entity).State = EntityState.Modified;
        }




        public virtual void Add(T entity)
        {
            dbset.Add(entity);
        }
        public virtual void Update(T entity)
        {
            dbset.Attach(entity);
            dataContext.Entry(entity).State = EntityState.Modified;
        }
        public virtual void Delete(T entity)
        {
            dbset.Remove(entity);
        }

       

        public virtual void Delete(Expression<Func<T, bool>> where)
        {
            IEnumerable<T> objects = dbset.Where<T>(where).AsEnumerable();
            foreach (T obj in objects)
                dbset.Remove(obj);
        }
        public virtual T GetById(long id)
        {
            return dbset.Find(id);
        }


        public virtual T GetById(string id)
        {
            return dbset.Find(id);
        }


        public virtual IEnumerable<T> GetAll()
        {
            return dbset.ToList();
        }

        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> where = null, Expression<Func<T, bool>> orderBy = null)
        {
            IQueryable<T> Query = dbset;
            if (where != null)
            {
                Query = Query.Where(where);
            }
            if (orderBy != null)
            {
                Query = Query.OrderBy(orderBy);
            }
            return Query;
        }
        public T Get(Expression<Func<T, bool>> where)
        {
            return dbset.Where(where).FirstOrDefault<T>();
        }

        public int count() {
            return dbset.Count();
        }
        


        


        public async Task<int> CountAsync()
        {
            return await dbset.CountAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await dbset.ToListAsync();
        }

        public async Task<T> FindAsync(Expression<Func<T, bool>> match)
        {
            return await dbset.SingleOrDefaultAsync(match);
        }

        public async Task<List<T>> FindAllAsync(Expression<Func<T, bool>> match)
        {
            return await dbset.Where(match).ToListAsync();
        }
      
    }
}
