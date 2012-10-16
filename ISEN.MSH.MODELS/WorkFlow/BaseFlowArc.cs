using System;
using System.Linq;
using System.Collections;

namespace ISEN.MSH.Nhibernate.Models.WorkFlow
{
    public class BaseFlowArc
    {
        public virtual Guid ID { get; set; }

        public virtual string Info { get; set; }

        //public virtual string Describe { get; set; }

        //public virtual bool Value { get; set; }                

        public virtual DateTime CreateDate { get; set; }        

        public virtual BaseFlowVertex HeadVertex { get; set; }

        public virtual BaseFlowVertex TailVertex { get; set; }


    }

}
