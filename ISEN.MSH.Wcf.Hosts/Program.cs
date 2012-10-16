using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.ServiceModel.Description;
using ISEN.MSH.Service.Implements;

namespace ISEN.MSH.Wcf.Hosts
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(UserInfoManager)))
            {
                host.Opened += delegate
                {
                    Console.WriteLine("OperationService已经启动，按任意键终止服务！");
                };
                host.Open();
                Console.Read();
            }
        }
    }
}
