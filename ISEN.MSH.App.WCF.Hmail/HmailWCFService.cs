using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.ServiceModel;
using ISEN.MSH.Framework.Mail.Hmail.Service;

namespace ISEN.MSH.App.WCF.Hmail
{
    public partial class HmailWCFService : ServiceBase
    {
        public ServiceHost serviceHost = null;

        public HmailWCFService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            if (serviceHost != null)
            {
                serviceHost.Close();
            }

            // Create a ServiceHost for the CalculatorService type and 
            // provide the base address.
            serviceHost = new ServiceHost(typeof(Accounts));

            // Open the ServiceHostBase to create listeners and start 
            // listening for messages.
            serviceHost.Open();
        }

        protected override void OnStop()
        {
            if (serviceHost != null)
            {
                serviceHost.Close();
                serviceHost = null;
            }
        }
        //http://technet.microsoft.com/zh-cn/library/ms733069(v=vs.110)
        //http://www.cnblogs.com/zengle_love/archive/2009/03/22/1419138.html
        //http://hi.baidu.com/zkbob22/item/eb908d0a5808d3046c90488f
        //http://www.hmailserver.com/documentation/v5.3/?page=com_objects
    }
}
