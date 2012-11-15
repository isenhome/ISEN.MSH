using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISEN.MSH.Framework.Service.Base.Util;
using ISEN.MSH.Framework.Service.Base.Dao;
using ISEN.MSH.Nhibernate.Model.Users;

namespace ISEN.MSH.APP.Service.Base.User.Dao
{
    public class UserRepository : RepositoryBase<UserModel>, IUserRepository
    {
        public IQueryable<UserModel> LoadAllByPage(out long total, int page, int rows, string order, string sort)
        {
            var list = this.LoadAll();

            total = list.LongCount();
            list = list.OrderBy(sort + " " + order);
            list = list.Skip((page - 1) * rows).Take(rows);

            return list;
        }
        
        public UserModel Get(string account)
        {
            return this.LoadAll().FirstOrDefault(f => f.Account == account);
        }
    }
}