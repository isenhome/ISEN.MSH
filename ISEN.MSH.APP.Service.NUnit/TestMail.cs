using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Spring.Context;
using Spring.Context.Support;
using Spring.Web.Mvc;

namespace ISEN.MSH.APP.Service.NUnit
{
    public class TestMail
    {
        [Test]
        public void TestUtilXml()
        {
            IApplicationContext cxt = ContextRegistry.GetContext();
            //ISEN.MSH.APP.Service.Mail.Util.XMLMailUtil.GetEntity().SetPop3("192.168.132.5","110");
        }
    }
}
