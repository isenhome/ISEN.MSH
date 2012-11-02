using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;

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
        }
    }
}
