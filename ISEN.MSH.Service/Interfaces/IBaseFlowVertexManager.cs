using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ISEN.MSH.Nhibernate.Models.WorkFlow;
namespace ISEN.MSH.Service.Interfaces
{
    public interface IBaseFlowVertexManager : IGenericManager<BaseFlowVertex>
    {
        BaseFlowVertex Get(string Name);
    }
}
