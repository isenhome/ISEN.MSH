using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISEN.MSH.Framework.Mail.Hmail.MailException
{
    public class BaseException:Exception
    {
        public string message { get; set; }
    }
}
