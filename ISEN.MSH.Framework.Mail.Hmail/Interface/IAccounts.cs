using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace ISEN.MSH.Framework.Mail.Hmail.Interface
{
    [ServiceContract(Name = "AccountService", Namespace = "http://hi.baidu.com/isenhome/")]
    public interface IAccounts
    {
        [OperationContract]
        void AddAccount(string address,string password);

        [OperationContract]
        void ChangePassword(string address, string password);

        [OperationContract]
        void DeleteAccount(string address);
    }
}
