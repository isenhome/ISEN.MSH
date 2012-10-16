using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace ISEN.MSH.Nhibernate.Models.WorkFlow
{
    public class BaseFlowVertex
    {
        public virtual Guid ID { get; set; }

        public virtual string Name { get; set; }

        public virtual string Content { get; set; }

        public virtual string ActionURL { get; set; }

        public virtual string Type { get; set; }

        public virtual DateTime CreateDate { get; set; }

        public virtual BaseFlow BaseFlow { get; set; }

        public virtual IList<BaseFlowArc> InConditionList { get; set; }

        public virtual IList<BaseFlowArc> OutConditionList { get; set; }

    }
}

