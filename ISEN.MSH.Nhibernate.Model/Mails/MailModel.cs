using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISEN.MSH.Nhibernate.Model.Users;

namespace ISEN.MSH.Nhibernate.Model.Mails
{
    public class MailModel
    {
        public virtual Guid ID { get; set; }

        public virtual string MessageID { get; set; }

        public virtual string Subject { get; set; }

        public virtual string Content { get; set; }

        public virtual string Sender { get; set; }

        public virtual string To { get; set; }

        public virtual string InReplyTo { get; set; }

        public virtual string ReplyTo { get; set; }

        public virtual DateTime SendTime { get; set; }

        public virtual DateTime ReceiveTime { get; set; }

        public virtual bool Emergency { get; set; }

        public virtual string Flag { get; set; }

        public virtual bool HasAttachments { get; set; }

        public virtual bool Draft { get; set; }

        public virtual bool Junk { get; set; }

        public virtual bool Seen { get; set; }

        public virtual FolderModel Folder { get; set; }

        public virtual UserModel User { get; set; }

        public virtual DateTime CreateTime { get; set; }

        public virtual DateTime UpdateTime { get; set; }
    }
}
