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

        /// <summary>
        /// 是否紧急
        /// </summary>
        public virtual bool Emergency { get; set; }

        /// <summary>
        ///  红旗邮件
        /// </summary>
        public virtual string Flag { get; set; }

        /// <summary>
        /// 是否有附件
        /// </summary>
        public virtual bool HasAttachments { get; set; }

        /// <summary>
        /// 是否是草稿
        /// </summary>
        public virtual bool Draft { get; set; }

        /// <summary>
        /// 是否是删除邮件
        /// </summary>
        public virtual bool Junk { get; set; }

        /// <summary>
        /// 是否已读
        /// </summary>
        public virtual bool Seen { get; set; }

        public virtual FolderModel Folder { get; set; }

        public virtual UserModel User { get; set; }

        public virtual DateTime CreateTime { get; set; }

        public virtual DateTime UpdateTime { get; set; }
    }
}
