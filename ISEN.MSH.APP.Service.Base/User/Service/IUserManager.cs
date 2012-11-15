using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISEN.MSH.Framework.Service.Base.Service;
using ISEN.MSH.Nhibernate.Model.Users;
namespace ISEN.MSH.APP.Service.Base.User.Service
{
    public interface IUserManager : IGenericManager<UserModel>
    {
        IList<UserModel> LoadAllByPage(out long total, int page, int rows, string order, string sort);

        UserModel Get(string account);

        UserModel Get(string account, string password);

        void Update(UserModel entity, string password);
    }
}
