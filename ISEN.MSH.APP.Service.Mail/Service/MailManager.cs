using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISEN.MSH.Framework.Service.Base.Service;
using ISEN.MSH.Nhibernate.Model.Mails;

namespace ISEN.MSH.APP.Service.Mail.Service
{
    public class MailManager : GenericManagerBase<MailModel>, IMailManager
    {

        public MailManager()
        { 
            
        }

        private void Init()
        { 
            
        }

        public IList<MailModel> LoadAllByPage(out long total, int page, int rows, string order, string sort)
        {
            return ((Dao.IMailRepository)(this.CurrentRepository))
                .LoadAllByPage(out total, page, rows, order, sort).ToList();
        }

        public IList<MailModel> LoadReceiveMail(out long total, int page, int rows, string order)
        {
            throw new NotImplementedException();
        }

        public IList<MailModel> LoadSendMail(out long total, int page, int rows, string order)
        {
            throw new NotImplementedException();
        }

        public IList<MailModel> LoadStorMail(out long total, int page, int rows, string order)
        {
            throw new NotImplementedException();
        }

        public IList<MailModel> LoadDeleteMail(out long total, int page, int rows, string order)
        {
            throw new NotImplementedException();
        }

        public bool SendMail(MailModel mail)
        {
            throw new NotImplementedException();
        }

        public bool SendReplyTo(MailModel mail)
        {
            throw new NotImplementedException();
        }

        public bool SendInReplyTo(MailModel mail)
        {
            throw new NotImplementedException();
        }

        public bool StoreSingleMail(MailModel mail)
        {
            throw new NotImplementedException();
        }

        public bool StoreMails(IList<MailModel> mails)
        {
            throw new NotImplementedException();
        }

        public bool DeleteSingleMail(MailModel mail)
        {
            throw new NotImplementedException();
        }

        public bool DeleteMails(IList<MailModel> mails)
        {
            throw new NotImplementedException();
        }

        public bool SetMailSeenState(IList<MailModel> mails, bool seen)
        {
            throw new NotImplementedException();
        }

        public bool SetMailEmergency(IList<MailModel> mails, bool emergency)
        {
            throw new NotImplementedException();
        }

        public bool SetMailFlag(IList<MailModel> mails, string Flag)
        {
            throw new NotImplementedException();
        }

        public bool SetMailDraft(IList<MailModel> mails, bool draft)
        {
            throw new NotImplementedException();
        }

        public bool SetMailJunk(IList<MailModel> mails, bool junk)
        {
            throw new NotImplementedException();
        }
    }
}
