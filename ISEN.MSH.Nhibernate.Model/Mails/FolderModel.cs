using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISEN.MSH.Nhibernate.Model.Users;

namespace ISEN.MSH.Nhibernate.Model.Mails
{
    public class FolderModel
    {
        public virtual Guid ID { get; set; }

        public virtual UserModel User { get; set; }

        public virtual string Name { get; set; }

        public virtual DateTime CreateTime { get; set; }

        public virtual DateTime UpdateTime { get; set; }
    }
}
