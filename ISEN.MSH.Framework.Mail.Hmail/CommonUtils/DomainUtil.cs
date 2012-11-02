using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISEN.MSH.Framework.Mail.Hmail.MailException;

namespace ISEN.MSH.Framework.Mail.Hmail.CommonUtils
{
    public class DomainUtil
    {
        public static hMailServer.IInterfaceDomain GetDomain(string address)
        {
            string[] tempaddress = address.Split((new char[]{'@'}));
            hMailServer.Domain domain = MailApplication.GetEntity().Domains.get_ItemByName(tempaddress[1]);
            if (domain == null)
            {
                throw new MessageException() { message = tempaddress[1] + "错误，无此邮箱" };
            }
            return domain;
        }
    }
}
