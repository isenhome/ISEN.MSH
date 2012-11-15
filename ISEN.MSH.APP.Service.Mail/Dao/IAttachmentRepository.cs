using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISEN.MSH.Framework.Service.Base.Dao;
using ISEN.MSH.Nhibernate.Model.Mails;

namespace ISEN.MSH.APP.Service.Mail.Dao
{
    public interface IAttachmentRepository : IRepository<AttachmentModel>
    {
        IQueryable<AttachmentModel> LoadAllByPage(out long total, int page, int rows, string order, string sort);
    }
}
