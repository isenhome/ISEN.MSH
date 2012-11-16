using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Spring.Context;
using Spring.Context.Support;

namespace ISEN.MSH.APP.Service.Mail.Nunit
{
    public class TestMail
    {
        [Test]
        public void TestUtilXml()
        {
            ISEN.MSH.APP.Service.Mail.Util.XMLMailUtil.GetEntity().SetPop3("192.168.132.5","110");
        }
    }
}
