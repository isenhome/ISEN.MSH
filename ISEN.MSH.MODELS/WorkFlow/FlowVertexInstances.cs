using System;
using System.Linq;

namespace ISEN.MSH.Nhibernate.Models.WorkFlow
{
    public class FlowVertexInstances
    {
        public virtual Guid ID { get; set; }

        public virtual BaseFlowVertex BaseFlowVertex { get; set; }

        //public virtual FlowItemsInstances FlowItemsInstance { get; set; }

        public virtual string State { get; set; }

        public virtual UserInfo Participator { get; set; }

        public virtual DateTime CreateDate { get; set; }

    }
}
