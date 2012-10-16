using System;
using System.Linq;
using ISEN.MSH.Nhibernate.Models.WorkFlow;
using ISEN.MSH.Service.Interfaces;

namespace ISEN.MSH.Service.Implements
{
    public class BaseFlowVertexManager : GenericManagerBase<BaseFlowVertex>, IBaseFlowVertexManager
    {
       public BaseFlowVertex Get(string name)
       {
           return ((ISEN.MSH.Dao.Interfaces.IBaseFlowVertexRepository)(this.CurrentRepository)).Get(name);
       }
    }
}
