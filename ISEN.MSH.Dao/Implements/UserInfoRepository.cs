using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Dynamic;
using ISEN.MSH.Nhibernate.Models;
using ISEN.MSH.Dao.Interfaces;

namespace ISEN.MSH.Dao.Implements
{
    public class UserInfoRepository : RepositoryBase<UserInfo>, IUserInfoRepository
    {
        public IQueryable<UserInfo> LoadAllByPage(out long total, int page, int rows, string order, string sort)
        {
            var list = this.LoadAll();

            total = list.LongCount();

            list = list.OrderBy(sort + " " + order);
            list = list.Skip((page - 1) * rows).Take(rows);

            return list;
        }
        
        public UserInfo Get(string account)
        {
            return this.LoadAll().FirstOrDefault(f => f.Account == account);
        }
    }
}