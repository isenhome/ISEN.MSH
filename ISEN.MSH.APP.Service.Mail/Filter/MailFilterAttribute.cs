using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Remoting.Proxies;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Remoting.Activation;
using ISEN.MSH.APP.Service.Mail.Util;
using AopAlliance.Intercept;

namespace ISEN.MSH.APP.Service.Mail.Filter
{
    public class AroundAdvice : IMethodInterceptor
    {
        public object Invoke(IMethodInvocation invocation)
        {
            //拦截Save方法
            //if (invocation.Method.Name == "Save")
            //{
            //    ICompanyManager target = (ICompanyManager)invocation.Target;

            //    return manager.IsPass(target.UserName) ? invocation.Proceed() : null;
            //}
            //else
            //{
            //    return invocation.Proceed();
            //}
        }
    }
}
