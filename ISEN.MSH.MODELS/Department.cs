using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISEN.MSH.Nhibernate.Models
{
    /// <summary>
    /// 树形结构 
    /// </summary>
    public class Department
    {
        /// <summary>
        /// ID
        /// </summary>
        public virtual Guid ID { get; set; }

        /// <summary>
        /// 上级部门ID
        /// </summary>
        public virtual Guid ParentID { get; set; }
        
        /// <summary>
        /// 部门名称
        /// </summary>
        public virtual string Name { get; set; }

        /// <summary>
        /// 部门介绍
        /// </summary>
        public virtual string Describe { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        public virtual DateTime CreateDateTime { get; set; }

        /// <summary>
        /// 是否有效
        /// </summary>
        public virtual bool IsEnable { get; set; }

    }
}
