using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using ISEN.MSH.Service.Implements;

namespace ISEN.MSH.Wcf.Hosts
{
    public class Host
    {
        public void StartWcf()
        {
            using (ServiceHost host = new ServiceHost(typeof(UserInfoManager)))
            {
                host.Opened += delegate
                {
                    Console.WriteLine("OperationService已经启动，按任意键终止服务！");
                };
                host.Open();
            }
        }

        private static Host host = null;

        public static Host GetInstance()
        {
            if (host == null)
            {
                host = new Host();
            }
            return host;
        }
    }
}
