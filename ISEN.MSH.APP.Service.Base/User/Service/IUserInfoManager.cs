using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISEN.MSH.Framework.Service.Base.Service;
using ISEN.MSH.Nhibernate.Model.User;
namespace ISEN.MSH.APP.Service.Base.User.Service
{
    public interface IUserInfoManager : IGenericManager<UserInfo>
    {
        IList<UserInfo> LoadAllByPage(out long total, int page, int rows, string order, string sort);

        UserInfo Get(string account);

        UserInfo Get(string account, string password);

        void Update(UserInfo entity, string password);
    }
}
