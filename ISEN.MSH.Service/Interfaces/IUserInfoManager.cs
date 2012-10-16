using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISEN.MSH.Nhibernate.Models;
using System.ServiceModel;
namespace ISEN.MSH.Service.Interfaces
{
    [ServiceContract(Name = "UserService")]
    public interface IUserInfoManager : IGenericManager<UserInfo>
    {
        [OperationContract]
        IList<UserInfo> LoadAllByPage(out long total, int page, int rows, string order, string sort);

        UserInfo Get(string account);

        UserInfo Get(string account, string password);

        void Update(UserInfo entity, string password);
    }
}
