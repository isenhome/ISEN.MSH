using System;
using System.Linq;
using NUnit.Framework;
using Spring.Context;
using Spring.Context.Support;
using ISEN.MSH.Service.Interfaces;

namespace ISEN.MSH.Service.NUnitTest
{
    public class TestBaseFlow
    {
        [Test]
        public void TestSave()
        {
            IApplicationContext cxt = ContextRegistry.GetContext();
            IBaseFlowManager baseFlowManager = (IBaseFlowManager)cxt.GetObject("Manager.BaseFlow");

            var baseFlow = new ISEN.MSH.Nhibernate.Models.WorkFlow.BaseFlow
            {
                ID = Guid.NewGuid(),
                Name = "请假流程",
                Content = "这是请假流程",
                CreateTime = DateTime.Now
            };

            baseFlowManager.Save(baseFlow);
        }
    }
}
