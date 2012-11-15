using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISEN.MSH.Framework.Service.Base.Dao;
using ISEN.MSH.Nhibernate.Model.Users;

namespace ISEN.MSH.APP.Service.Base.User.Dao
{
    public interface IUserRepository : IRepository<UserModel>
    {
        IQueryable<UserModel> LoadAllByPage(out long total, int page, int rows, string order, string sort);

        UserModel Get(string account);
    }
}
