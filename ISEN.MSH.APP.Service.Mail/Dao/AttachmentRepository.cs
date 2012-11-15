using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISEN.MSH.Framework.Service.Base.Util;
using ISEN.MSH.Framework.Service.Base.Dao;
using ISEN.MSH.APP.Service.Mail.Dao;
using ISEN.MSH.Nhibernate.Model.Mails;

namespace ISEN.MSH.APP.Service.Mail.Dao
{
    public class AttachmentRepository : RepositoryBase<AttachmentModel>, IAttachmentRepository
    {
        public IQueryable<AttachmentModel> LoadAllByPage(out long total, int page, int rows, string order, string sort)
        {
            var list = this.LoadAll();

            total = list.LongCount();
            list = list.OrderBy(sort + " " + order);
            list = list.Skip((page - 1) * rows).Take(rows);

            return list;
        }
    }
}