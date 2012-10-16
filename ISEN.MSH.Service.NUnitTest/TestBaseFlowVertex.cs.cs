using System;
using System.Linq;
using NUnit.Framework;
using Spring.Context;
using Spring.Context.Support;
using ISEN.MSH.Service.Interfaces;
using System.Collections.Generic;

namespace ISEN.MSH.Service.NUnitTest
{
    public class TestBaseFlowItems
    {
        [Test]
        public void TestSave()
        {
            IApplicationContext cxt = ContextRegistry.GetContext();
            IBaseFlowVertexManager baseFlowVertexManager = (IBaseFlowVertexManager)cxt.GetObject("Manager.BaseFlowVertex");
            IBaseFlowManager baseFlowManager = (IBaseFlowManager)cxt.GetObject("Manager.BaseFlow");
        }

    }
}