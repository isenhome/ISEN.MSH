using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISEN.MSH.Framework.Mail.Hmail.Interface;
using ISEN.MSH.Framework.Mail.Hmail.CommonUtils;

namespace ISEN.MSH.Framework.Mail.Hmail.Service
{
    public class Accounts:IAccounts
    {
        public void AddAccount(string address, string password)
        {
            hMailServer.Account account = DomainUtil.GetDomain(address).Accounts.Add();
            account.Address = address;
            account.Password = password;
            account.Active = true;
            account.AdminLevel = hMailServer.eAdminLevel.hAdminLevelNormal;
            account.MaxSize = 20;
            account.Save();
        }

        public void ChangePassword(string address, string password)
        {
            hMailServer.Account account = DomainUtil.GetDomain(address).Accounts.get_ItemByAddress(address);
            account.Password = password;
            account.Save();
        }

        public void DeleteAccount(string address)
        {
            hMailServer.Account account = DomainUtil.GetDomain(address).Accounts.get_ItemByAddress(address);
            account.Delete();
        }
    }
}
