using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISEN.MSH.Nhibernate.Model.User;

namespace ISEN.MSH.Nhibernate.Model.Mail
{
    public class Folder
    {
        public virtual Guid ID { get; set; }

        public virtual UserInfo UserInfo { get; set; }

        public virtual string Name { get; set; }

        public virtual DateTime CreateTime { get; set; }

        public virtual DateTime UpdateTime { get; set; }
    }
}
