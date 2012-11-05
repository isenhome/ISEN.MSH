using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.ServiceModel;
using ISEN.MSH.Framework.Mail.Hmail.Service;

namespace ISEN.MSH.App.WCF.Hmail
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[] 
            { 
                new HmailWCFService() 
            };
            ServiceBase.Run(ServicesToRun);
            //using (ServiceHost host = new ServiceHost(typeof(Accounts)))
            //{
            //    host.Opened += delegate
            //    {
            //        Console.WriteLine("CalculaorService已经启动，按任意键终止服务！");
            //    };

            //    host.Open();
            //    Console.Read();
            //}
        }
    }
}
