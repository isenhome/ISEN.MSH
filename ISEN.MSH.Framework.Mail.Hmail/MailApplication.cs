using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Configuration;
using ISEN.MSH.Framework.Mail.Hmail.MailException;

namespace ISEN.MSH.Framework.Mail.Hmail
{
    public class MailApplication
    {
        public MailApplication()
        {

        }

        private static hMailServer.IInterfaceApplication mailApp;
        public static hMailServer.IInterfaceApplication GetEntity()
        {
            if (mailApp == null)
            {
                mailApp = MailAuthenticate();
            }
            return mailApp;
        }

        private static hMailServer.IInterfaceApplication MailAuthenticate()
        {
            mailApp = new hMailServer.Application();
            IDictionary accountConfig = (IDictionary)ConfigurationManager.GetSection("mail/account");
            hMailServer.IInterfaceAccount account = mailApp.Authenticate(accountConfig["username"].ToString(), accountConfig["password"].ToString());
            if (account == null)
            {
                throw new MessageException() { message = "账号验证错误" };
            }
            return mailApp;
        }
    }
}
