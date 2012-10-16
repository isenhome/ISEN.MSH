using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISEN.MSH.Nhibernate.Models;

namespace ISEN.MSH.Dao.Interfaces
{
    public interface IUserInfoRepository : IRepository<UserInfo>
    {
        IQueryable<UserInfo> LoadAllByPage(out long total, int page, int rows, string order, string sort);

        UserInfo Get(string account);
    }
}
