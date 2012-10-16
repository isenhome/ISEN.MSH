using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISEN.MSH.Nhibernate.Models
{
    /// <summary>
    /// 用户与部门关系表
    /// </summary>
    public class RelationUserInfoDepartment
    {
        /// <summary>
        /// ID
        /// </summary>
        public virtual Guid ID { get; set; }

        /// <summary>
        /// 用户
        /// </summary>
        public virtual UserInfo UserInfo { get; set; }

        /// <summary>
        /// 部门
        /// </summary>
        public virtual Department Department { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public virtual DateTime CreateDateTime { get; set; }

        /// <summary>
        /// 是否有效
        /// </summary>
        public virtual bool IsEnable { get; set; }

        /// <summary>
        /// 变更原因
        /// </summary>
        public virtual string Describe { get; set; }
    }
}
