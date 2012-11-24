using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace ISEN.MSH.APP.Service.Mail.Util
{
    public interface IXMLMailUtil
    {
        XmlDocument xml { get; set; }
        void SetPop3(string location, string port);
        void SetImap(string location, string port);
        void SetAttachment(string path);
        void CheckConfFile();
    }
}
