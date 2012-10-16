using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISEN.MSH.Nhibernate.Models.WorkFlow
{
    public class BaseFlowRequirement
    {
        public virtual Guid ID { get; set; }

        public virtual string Name { get; set; }

        //public virtual string Value { get; set; }

        public virtual BaseFlow BaseFlow { get; set; }

        public virtual DateTime CreateDate { get; set; }
    }
}
