using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISEN.MSH.Framework.Service.Base.Dao;
using ISEN.MSH.Nhibernate.Model.Mails;

namespace ISEN.MSH.APP.Service.Mail.Dao
{
    public interface IMailRepository : IRepository<MailModel>
    {
        IQueryable<MailModel> LoadAllByPage(out long total, int page, int rows, string order, string sort);
    }
}
