using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISEN.MSH.APP.Service.Mail.Exception
{
    public class MailException :System.Exception
    {
        public string message { get; set; }
    }
}
