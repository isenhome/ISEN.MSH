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
        public IList<MailModel> LoadAllByPage(out long total, int page, int rows, string order, string sort)
        {
            return ((Dao.IMailRepository)(this.CurrentRepository))
                .LoadAllByPage(out total, page, rows, order, sort).ToList();
        }

        public void LoadAllFromServerByImap()
        { 
            
        }
    }
}
