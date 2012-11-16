using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.IO;
using System.Runtime.Remoting.Proxies;
using System.Runtime.Remoting.Messaging;
using ISEN.MSH.APP.Service.Mail.Exception;
using ISEN.MSH.APP.Service.Mail.Filter;

namespace ISEN.MSH.APP.Service.Mail.Util
{
    public class XMLMailUtil
    {
        private static XMLMailUtil entity;

        public static XMLMailUtil GetEntity()
        {
            if (entity == null)
            {
                entity = new XMLMailUtil();
            }
            return entity;
        }



            //ICompanyManager target = new CompanyManager() { Dao = new CompanyDao(), UserName = "admin" };
            
            //ProxyFactory factory = new ProxyFactory(target);
            //factory.AddAdvice(new AroundAdvice());

            //ICompanyManager manager = (ICompanyManager)factory.GetProxy();



        public XMLMailUtil()
        {
            Init();
        }

        public XmlDocument xml { get; set; }

        private void Init()
        {
            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"/config"))
            {
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"/config");
            }
            if (!File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"/config/Mail.conf.xml"))
            {
                XmlDocument xml = new XmlDocument();
                XmlDeclaration xmlDeclaration = xml.CreateXmlDeclaration("1.0", "utf-8", null);
                xml.AppendChild(xmlDeclaration);
                string strXml = "<mail><server><pop3><location></location><port></port></pop3><imap><location></location><port></port></imap></server><attachemet><path></path></attachemet></mail>";
                xml.LoadXml(strXml);
                xml.SelectSingleNode("/mail/server/pop3/location").InnerText = "127.0.0.1";
                xml.SelectSingleNode("/mail/server/pop3/port").InnerText = "110";
                xml.SelectSingleNode("/mail/server/imap/location").InnerText = "127.0.0.1";
                xml.SelectSingleNode("/mail/server/imap/port").InnerText = "995";
                xml.SelectSingleNode("/mail/attachemet/path").InnerText = AppDomain.CurrentDomain.BaseDirectory + @"attachment";
                xml.Save(AppDomain.CurrentDomain.BaseDirectory + @"/config/Mail.conf.xml");
                this.xml = xml;
            }
            if (this.xml == null)
            {
                XmlDocument xml = new XmlDocument();
                xml.Load(AppDomain.CurrentDomain.BaseDirectory + @"/config/Mail.conf.xml");
                this.xml = xml;
            }
        }

        public void SetPop3(string location, string port)
        {
            this.xml.SelectSingleNode("/mail/server/pop3/location").InnerText = location;
            this.xml.SelectSingleNode("/mail/server/pop3/port").InnerText = port;
            this.xml.Save(AppDomain.CurrentDomain.BaseDirectory + @"/config/Mail.conf.xml");
        }

        public void SetImap(string location, string port)
        {
            this.xml.SelectSingleNode("/mail/server/imap/location").InnerText = location;
            this.xml.SelectSingleNode("/mail/server/imap/port").InnerText = port;
            this.xml.Save(AppDomain.CurrentDomain.BaseDirectory + @"/config/Mail.conf.xml");
        }

        public void SetAttachment(string path)
        {
            this.xml.SelectSingleNode("/mail/attachemet/path").InnerText = path;
        }

        public void CheckConfFile()
        {
            if (Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"/config") && File.Exists(AppDomain.CurrentDomain.BaseDirectory + @"/config/Mail.conf.xml"))
            {
                XmlDocument xml = new XmlDocument();
                xml.Load(AppDomain.CurrentDomain.BaseDirectory + @"/config/Mail.conf.xml");
                if (this.xml.InnerText.Trim() != xml.InnerText.Trim())
                {
                    Random random = new Random();
                    int temp = random.Next();
                    File.Move(AppDomain.CurrentDomain.BaseDirectory + @"/config/Mail.conf.xml", AppDomain.CurrentDomain.BaseDirectory + @"/config/Mail.conf.error." + temp + ".xml");
                    Init();
                    throw new MailException() { message = "邮件配置错误，已重置配置文件，请重新配置，源错误文件为：Mail.conf.error." + temp + ".xml" };
                }
            }
            else
            {
                Init();
            }
        }
    }
}
