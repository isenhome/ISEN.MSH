using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Collections;

namespace ISEN.MSH.Framework.Service.Base.Service
{
    public abstract class GenericManagerBase<T> : IGenericManager<T> where T : class
    {
        public Dao.IRepository<T> CurrentRepository { get; set; }

        public virtual T Get(object id)
        {
            if (id == null)
            {
                return null;
            }
            return this.CurrentRepository.Get(id);
        }

        public virtual T Load(object id)
        {
            if (id == null)
            {
                return null;
            }
            return this.CurrentRepository.Load(id);
        }

        public virtual object Save(T entity)
        {
            if (entity == null)
            {
                return null;
            }
            return this.CurrentRepository.Save(entity);
        }

        public virtual void Update(T entity)
        {
            if (entity == null)
            {
                return;
            }

            this.CurrentRepository.Update(entity);
        }

        public virtual void Delete(object id)
        {
            if (id == null)
            {
                return;
            }

            this.CurrentRepository.Delete(id);
        }
  
        public virtual IList<T> LoadAll()
        {
            return this.CurrentRepository.LoadAll().ToList();
        }

        public virtual IList<T> LoadAllWithPage(out long count, int pageIndex, int pageSize)
        {
            return this.CurrentRepository.LoadAllWithPage(out count, pageIndex, pageSize).ToList();
        }


        public virtual void Delete(IList<object> idList)
        {
            if (idList == null || idList.Count == 0)
            {
                return;
            }

            this.CurrentRepository.Delete(idList);
        }

        public virtual void SaveOrUpdate(T entity)
        {
            if (entity == null)
            {
                return;
            }

            this.CurrentRepository.SaveOrUpdate(entity);
        }
    }
}
