using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using LumiSoft.Net.POP3.Client;
using LumiSoft.Net.Mime;
using LumiSoft.Net.IMAP.Client;
using LumiSoft.Net.IMAP;
using LumiSoft.Net;

namespace ISEN.MSH.APP.Service.Mail
{
    static class Programe
    {
        [STAThread]
        static void Main(string[] args)
        {
            
        }

        static void pop3()
        { 
            List<string> gotemailids = new List<string>();
            using (LumiSoft.Net.POP3.Client.POP3_Client pop3 = new POP3_Client())
            {
                try
                {
                    //与pop3服务器建立连接
                    pop3.Connect("pop.qq.com", 110, false);
                    //验证身份
                    pop3.Login("84655709@qq.com", "myhaiyan");

                    //获取邮件信息列表
                    POP3_ClientMessageCollection infos = pop3.Messages;
                    foreach (POP3_ClientMessage info in infos)
                    {
                        //每封email会有一个在pop3服务器范围内唯一的id,检查这个id是否存在就可以知道以前有没有接收过这封邮件
                        if (gotemailids.Contains(info.UID))
                            continue;
                        //获取这封邮件的内容
                        byte[] bytes = info.MessageToByte();
                        //记录这封邮件的id
                        gotemailids.Add(info.UID);

                        //解析从pop3服务器发送过来的邮件信息
                        Mime m = Mime.Parse(bytes);
                        if (m != null)
                        {
                            string mailfrom = "";
                            string mailfromname = "";
                            if (m.MainEntity.From != null)
                            {
                                for (int i = 0; i < m.MainEntity.From.Mailboxes.Length; i++)
                                {
                                    if (i == 0)
                                    {
                                        mailfrom = (m.MainEntity.From).Mailboxes[i].EmailAddress;
                                    }
                                    else
                                    {
                                        mailfrom += string.Format(",{0}", (m.MainEntity.From).Mailboxes[i].EmailAddress);
                                    }
                                    mailfromname = (m.MainEntity.From).Mailboxes[0].DisplayName != ""
                                                       ? (m.MainEntity.From).Mailboxes[0].DisplayName
                                                       : (m.MainEntity.From).Mailboxes[0].LocalPart;
                                }
                            }
                            string mailto = "";
                            string mailtotocollection = "";
                            if (m.MainEntity.To != null)
                            {
                                mailtotocollection = m.MainEntity.To.ToAddressListString();

                                for (int i = 0; i < m.MainEntity.To.Mailboxes.Length; i++)
                                {
                                    if (i == 0)
                                    {
                                        mailto = (m.MainEntity.To).Mailboxes[i].EmailAddress;
                                    }
                                    else
                                    {
                                        mailto += string.Format(",{0}", (m.MainEntity.To).Mailboxes[i].EmailAddress);
                                    }

                                }
                            }

                        }
                        //获取附件
                        foreach (MimeEntity entry in m.Attachments)
                        {
                            string filename = entry.ContentDisposition_FileName; //获取文件名称
                            string path = AppDomain.CurrentDomain.BaseDirectory + @"attch\" + filename;
                            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + @"attch"))
                            {
                                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + @"attch");
                            }
                            if (File.Exists(path))
                            {
                                Random random = new Random();
                                int newfile = random.Next(1, 100000);
                                path = AppDomain.CurrentDomain.BaseDirectory + @"attch\" + newfile.ToString();
                                Directory.CreateDirectory(path);
                                path += @"\" + filename;
                            }
                            byte[] data = entry.Data;
                            FileStream pfilestream = null;
                            pfilestream = new FileStream(path, FileMode.Create);
                            pfilestream.Write(data, 0, data.Length);
                            pfilestream.Close();
                        }
                    }

                }
                catch (Exception ex)
                {

                }
            }
        }

        static void imap()
        {
            using (IMAP_Client client = new IMAP_Client())
            {
                client.Connect("192.168.132.5", 143, false);
                client.Login("Server@192.168.132.5", "isenhome");
                client.SelectFolder("INBOX");

                IMAP_SequenceSet sequence = new IMAP_SequenceSet();
                //sequence.Parse("*:1"); // from first to last

                IMAP_Client_FetchHandler fetchHandler = new IMAP_Client_FetchHandler();

                fetchHandler.NextMessage += new EventHandler(delegate(object s, EventArgs e)
                {
                    Console.WriteLine("next message");
                });

                fetchHandler.Envelope += new EventHandler<EventArgs<IMAP_Envelope>>(delegate(object s, EventArgs<IMAP_Envelope> e)
                {
                    IMAP_Envelope envelope = e.Value;
                    if (envelope.From != null && !String.IsNullOrWhiteSpace(envelope.Subject))
                    {
                        Console.WriteLine(envelope.Subject);
                    }

                });

                // the best way to find unread emails is to perform server search
                int[] unseen_ids = client.Search(false, "UTF-8", "unseen");
                Console.WriteLine("unseen count: " + unseen_ids.Count().ToString());

                // now we need to initiate our sequence of messages to be fetched
                sequence.Parse(string.Join(",", unseen_ids));

                // fetch messages now
                client.Fetch(false, sequence, new IMAP_Fetch_DataItem[] { new IMAP_Fetch_DataItem_Envelope() }, fetchHandler);

                // uncomment this line to mark messages as read
                // client.StoreMessageFlags(false, sequence, IMAP_Flags_SetType.Add, IMAP_MessageFlags.Seen);

                

            }
        }

    }
}
