using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISEN.MSH.Framework.Service.Base.Service;
using ISEN.MSH.Nhibernate.Model.Mails;
namespace ISEN.MSH.APP.Service.Mail.Service
{
    public interface IMailManager : IGenericManager<MailModel>
    {
        IList<MailModel> LoadAllByPage(out long total, int page, int rows, string order, string sort);

        IList<MailModel> LoadReceiveMail(out long total,int page,int rows,string order);

        IList<MailModel> LoadSendMail(out long total, int page, int rows, string order);

        IList<MailModel> LoadStorMail(out long total, int page, int rows, string order);

        IList<MailModel> LoadDeleteMail(out long total, int page, int rows, string order);

        bool SendMail(MailModel mail);

        bool SendReplyTo(MailModel mail);

        bool SendInReplyTo(MailModel mail);

        bool StoreSingleMail(MailModel mail);

        bool StoreMails(IList<MailModel> mails);

        bool DeleteSingleMail(MailModel mail);

        bool DeleteMails(IList<MailModel> mails);

        bool SetMailSeenState(IList<MailModel> mails,bool seen);

        bool SetMailEmergency(IList<MailModel> mails, bool emergency);

        bool SetMailFlag(IList<MailModel> mails, string Flag);

        bool SetMailDraft(IList<MailModel> mails, bool draft);

        bool SetMailJunk(IList<MailModel> mails, bool junk);
    }
}