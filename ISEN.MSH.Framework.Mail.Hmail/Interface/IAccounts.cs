using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISEN.MSH.Framework.Mail.Hmail.Interface
{
    public interface IAccounts
    {
        void AddAccount(string address,string password);
       
        void ChangePassword(string address, string password);

        void DeleteAccount(string address);
    }
}
