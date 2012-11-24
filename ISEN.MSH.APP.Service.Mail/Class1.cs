using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using LumiSoft.Net.POP3.Client;
using LumiSoft.Net.Mime;
using LumiSoft.Net.IMAP.Client;
using LumiSoft.Net.IMAP;
using LumiSoft.Net;

namespace ISEN.MSH.APP.Service.Mail
{
    static class Programe
    {
        [STAThread]
        static void Main(string[] args)
        {
            ISEN.MSH.APP.Service.Mail.Util.XMLMailUtil.GetEntity().SetPop3("192.168.132.5", "110");
            System.Console.ReadLine();
        }
    }
}
