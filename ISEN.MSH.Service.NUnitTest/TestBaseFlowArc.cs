using System;
using System.Linq;
using NUnit.Framework;
using Spring.Context;
using Spring.Context.Support;
using ISEN.MSH.Service.Interfaces;

namespace ISEN.MSH.Service.NUnitTest
{
    public class TestBaseFlowArc
    {
        [Test]
        public void TestSave()
        {
            IApplicationContext cxt = ContextRegistry.GetContext();
            IBaseFlowVertexManager baseFlowVertexManager = (IBaseFlowVertexManager)cxt.GetObject("Manager.BaseFlowVertex");
            IBaseFlowArcManager baseFlowArcManager = (IBaseFlowArcManager)cxt.GetObject("Manager.BaseFlowArc"); 
        }
    }
}