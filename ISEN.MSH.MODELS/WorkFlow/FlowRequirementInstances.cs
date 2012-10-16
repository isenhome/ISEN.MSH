using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISEN.MSH.Nhibernate.Models.WorkFlow
{
    public class FlowRequirementInstances
    {
        public virtual Guid ID { get; set; }

        public virtual string Name { get; set; }

        public virtual FlowInstances FlowInstances { get; set; }

        public virtual DateTime CreateDate { get; set; }
    }
}
