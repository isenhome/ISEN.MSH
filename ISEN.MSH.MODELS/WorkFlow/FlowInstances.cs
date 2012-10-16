using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ISEN.MSH.Nhibernate.Models.WorkFlow
{
    public class FlowInstances
    {
        public virtual Guid ID { get; set; }

        public virtual BaseFlow BaseFlow { get; set; }

        /// <summary>
        /// 记录当前流程状态（运行中、已完结）
        /// </summary>
        public virtual string State { get; set; }

        public virtual DateTime CreateDate { get; set; }

        public virtual UserInfo Creator { get; set; }

        public virtual IList<FlowRequirementInstances> FlowRequirementInstancesList { get; set; }

    }
}
