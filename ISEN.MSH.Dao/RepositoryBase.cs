using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Spring.Data.NHibernate.Generic.Support;
using NHibernate.Linq;
using System.Linq.Expressions;

namespace ISEN.MSH.Dao
{
    public abstract class RepositoryBase<T> : HibernateDaoSupport, IRepository<T> where T : class
    {
        public virtual object Save(T entity)
        {
            return this.HibernateTemplate.Save(entity);
        }

        public virtual T Get(object id)
        {
            return this.HibernateTemplate.Get<T>(id);
        }

        public virtual T Load(object id)
        {
            return this.HibernateTemplate.Load<T>(id);
        }

        public virtual IQueryable<T> LoadAll()
        {
            var result = Session.Query<T>();
            return result;
        }

        public virtual void Update(T entity)
        {
            this.HibernateTemplate.Update(entity);
        }

        public virtual void Delete(object id)
        {
            var entity = this.HibernateTemplate.Get<T>(id);
            if (entity == null)
            {
                return;
            }

            this.HibernateTemplate.Delete(entity);
        }

        public virtual IQueryable<T> LoadAllWithPage(out long count, int pageIndex, int pageSize)
        {
            var result = Session.Query<T>();
            count = result.LongCount();

            return result.Skip((pageIndex - 1) * pageSize).Take(pageSize);
        }


        public virtual void Delete(IList<object> idList)
        {
            foreach (var item in idList)
            {
                var entity = this.HibernateTemplate.Get<T>(item);
                if (entity == null)
                {
                    return;
                }

                this.HibernateTemplate.Delete(entity);
            }
        }

        public virtual void SaveOrUpdate(T entity)
        {
            this.HibernateTemplate.SaveOrUpdate(entity);
        }
    }
}
