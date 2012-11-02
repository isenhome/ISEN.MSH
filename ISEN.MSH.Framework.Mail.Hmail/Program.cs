using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISEN.MSH.Framework.Mail.Hmail.Service;

namespace ISEN.MSH.Framework.Mail.Hmail
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Accounts accounts = new Accounts();
            //accounts.AddAccount("testAdd@192.168.132.5", "testAdd");
            //accounts.ChangePassword("testAdd@192.168.132.5", "isenhome");
            //accounts.DeleteAccount("testAdd@192.168.132.5");
        }
    }
}
