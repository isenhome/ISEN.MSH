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
            System.Console.WriteLine(invocation.Method.Name);
            //拦截方法
            switch (invocation.Method.Name)
            {
                case "SetPop3":
                case "SetAttachment":
                case "SetImap":
                    XMLMailUtil.GetEntity().CheckConfFile();
                    break;
                default:
                    break;
            }
            return invocation.Proceed();

        }
    }
}
