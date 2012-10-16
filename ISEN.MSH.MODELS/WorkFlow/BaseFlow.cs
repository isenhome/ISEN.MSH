using System;
using System.Linq;
using System.Collections.Generic;

namespace ISEN.MSH.Nhibernate.Models.WorkFlow
{
    public class BaseFlow
    {
        public virtual Guid ID { get; set; }

        public virtual string Name { get; set; }

        public virtual string Content { get; set; }

        public virtual DateTime CreateTime { get; set; }

        public virtual IList<BaseFlowVertex> BaseFlowVertexList { get; set; }

        public virtual IList<BaseFlowRequirement> BaseFlowRequirementList { get; set; }
    }
}