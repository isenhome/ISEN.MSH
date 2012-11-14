using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISEN.MSH.Nhibernate.Model.User;

namespace ISEN.MSH.Nhibernate.Model.Mail
{
    public class Mail
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

        public virtual Folder Folder { get; set; }

        public virtual List<Attachment> Attachments { get; set; }

        public virtual UserInfo UserInfo { get; set; }

        public virtual DateTime CreateTime { get; set; }

        public virtual DateTime UpdateTime { get; set; }
    }
}
