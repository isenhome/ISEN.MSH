using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISEN.MSH.Nhibernate.Model.Mail
{
    public class Attachment
    {
        public virtual Guid ID { get; set; }

        public virtual Mail Mail { get; set; }

        public virtual string Name { get; set; }

        public virtual double Size { get; set; }

        public virtual DateTime CreateTime { get; set; }

        public virtual DateTime UpdateTime { get; set; }
    }
}
