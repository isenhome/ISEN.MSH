using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISEN.MSH.Framework.Service.Base.Dao;
using ISEN.MSH.Nhibernate.Model.User;

namespace ISEN.MSH.APP.Service.Base.User.Dao
{
    public interface IUserInfoRepository : IRepository<UserInfo>
    {
        IQueryable<UserInfo> LoadAllByPage(out long total, int page, int rows, string order, string sort);

        UserInfo Get(string account);
    }
}
