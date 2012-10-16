using System;
using System.Collections.Generic;
using System.Linq;
using ISEN.MSH.Nhibernate.Models.WorkFlow;

namespace ISEN.MSH.Service.NUnitTest
{
    public class FlowData
    {
        private BaseFlow leaveApplication;

        private BaseFlowVertex leaveApplicationVertex0;//开始节点
        private BaseFlowVertex leaveApplicationVertex1;
        private BaseFlowVertex leaveApplicationVertex2;
        private BaseFlowVertex leaveApplicationVertex3;
        private BaseFlowVertex leaveApplicationVertex4;
        private BaseFlowVertex leaveApplicationVertex5;
        private BaseFlowVertex leaveApplicationVertex6;
        private BaseFlowVertex leaveApplicationVertex7;
        private BaseFlowVertex leaveApplicationVertex8;
        private BaseFlowVertex leaveApplicationVertex9;//结束节点

        private BaseFlowArc leaveApplicationArc0;
        private BaseFlowArc leaveApplicationArc1;
        private BaseFlowArc leaveApplicationArc2;
        private BaseFlowArc leaveApplicationArc3;
        private BaseFlowArc leaveApplicationArc4;
        private BaseFlowArc leaveApplicationArc5;
        private BaseFlowArc leaveApplicationArc6;
        private BaseFlowArc leaveApplicationArc7;
        private BaseFlowArc leaveApplicationArc8;
        private BaseFlowArc leaveApplicationArc9;
        private BaseFlowArc leaveApplicationArc10;
        private BaseFlowArc leaveApplicationArc11;
        private BaseFlowArc leaveApplicationArc12;
        private BaseFlowArc leaveApplicationArc13;
        private BaseFlowArc leaveApplicationArc14;
        private BaseFlowArc leaveApplicationArc15;
        private BaseFlowArc leaveApplicationArc16;
        private BaseFlowArc leaveApplicationArc17;
        private BaseFlowArc leaveApplicationArc18;
        private BaseFlowArc leaveApplicationArc19;
        private BaseFlowArc leaveApplicationArc20;

        public FlowData()
        {
            //leaveApplication = new BaseFlow { ID = Guid.NewGuid(), Name = "请假流程", Content = "用于发起请假流程的唯一标示", CreateTime = DateTime.Now };


            //leaveApplicationArc0 = new BaseFlowArc { ID = Guid.NewGuid(), Describe = "默认处理",  CreateDate = DateTime.Now, HeadVertex = leaveApplicationVertex0, TailVertex = leaveApplicationVertex1 };

            //leaveApplicationArc1 = new BaseFlowArc { ID = Guid.NewGuid(), Describe = "默认处理",  CreateDate = DateTime.Now, HeadVertex = leaveApplicationVertex1, TailVertex = leaveApplicationVertex2 };
            //leaveApplicationArc2 = new BaseFlowArc { ID = Guid.NewGuid(), Describe = "流程发起人是为部门经理",  CreateDate = DateTime.Now, HeadVertex = leaveApplicationVertex1, TailVertex = leaveApplicationVertex3 };
            //leaveApplicationArc3 = new BaseFlowArc { ID = Guid.NewGuid(), Describe = "流程发起人为人力资源主管",  CreateDate = DateTime.Now, HeadVertex = leaveApplicationVertex1, TailVertex = leaveApplicationVertex4 };
            //leaveApplicationArc20 = new BaseFlowArc { ID = Guid.NewGuid(), Describe = "流程发起人为人力资源经理",  CreateDate = DateTime.Now, HeadVertex = leaveApplicationVertex1, TailVertex = leaveApplicationVertex5 };

            //leaveApplicationArc4 = new BaseFlowArc { ID = Guid.NewGuid(), Describe = "返回申请人修改",  CreateDate = DateTime.Now, HeadVertex = leaveApplicationVertex2, TailVertex = leaveApplicationVertex1 };
            //leaveApplicationArc5 = new BaseFlowArc { ID = Guid.NewGuid(), Describe = "默认处理",  CreateDate = DateTime.Now, HeadVertex = leaveApplicationVertex2, TailVertex = leaveApplicationVertex3 };
            //leaveApplicationArc6 = new BaseFlowArc { ID = Guid.NewGuid(), Describe = "部门经理不同意请假",  CreateDate = DateTime.Now, HeadVertex = leaveApplicationVertex2, TailVertex = leaveApplicationVertex9 };

            //leaveApplicationArc7 = new BaseFlowArc { ID = Guid.NewGuid(), Describe = "返回申请人修改",  CreateDate = DateTime.Now, HeadVertex = leaveApplicationVertex3, TailVertex = leaveApplicationVertex1 };
            //leaveApplicationArc8 = new BaseFlowArc { ID = Guid.NewGuid(), Describe = "请假时间超过3天",  CreateDate = DateTime.Now, HeadVertex = leaveApplicationVertex3, TailVertex = leaveApplicationVertex4 };
            //leaveApplicationArc9 = new BaseFlowArc { ID = Guid.NewGuid(), Describe = "默认处理",  CreateDate = DateTime.Now, HeadVertex = leaveApplicationVertex3, TailVertex = leaveApplicationVertex6 };
            ////leaveApplicationArc10 = new BaseFlowArc { ID = Guid.NewGuid(), Describe = "",  CreateDate = DateTime.Now, HeadVertex = leaveApplicationVertex3, TailVertex = leaveApplicationVertex5 };

            //leaveApplicationArc11 = new BaseFlowArc { ID = Guid.NewGuid(), Describe = "",  CreateDate = DateTime.Now, HeadVertex = leaveApplicationVertex4, TailVertex = leaveApplicationVertex5 };
            //leaveApplicationArc12 = new BaseFlowArc { ID = Guid.NewGuid(), Describe = "默认处理",  CreateDate = DateTime.Now, HeadVertex = leaveApplicationVertex4, TailVertex = leaveApplicationVertex6 };
            //leaveApplicationArc13 = new BaseFlowArc { ID = Guid.NewGuid(), Describe = "",  CreateDate = DateTime.Now, HeadVertex = leaveApplicationVertex4, TailVertex = leaveApplicationVertex9 };

            //leaveApplicationArc14 = new BaseFlowArc { ID = Guid.NewGuid(), Describe = "",  CreateDate = DateTime.Now, HeadVertex = leaveApplicationVertex5, TailVertex = leaveApplicationVertex6 };
            //leaveApplicationArc15 = new BaseFlowArc { ID = Guid.NewGuid(), Describe = "",  CreateDate = DateTime.Now, HeadVertex = leaveApplicationVertex5, TailVertex = leaveApplicationVertex9 };

            //leaveApplicationArc16 = new BaseFlowArc { ID = Guid.NewGuid(), Describe = "",  CreateDate = DateTime.Now, HeadVertex = leaveApplicationVertex6, TailVertex = leaveApplicationVertex7 };
            //leaveApplicationArc17 = new BaseFlowArc { ID = Guid.NewGuid(), Describe = "",  CreateDate = DateTime.Now, HeadVertex = leaveApplicationVertex6, TailVertex = leaveApplicationVertex8 };

            //leaveApplicationArc18 = new BaseFlowArc { ID = Guid.NewGuid(), Describe = "",  CreateDate = DateTime.Now, HeadVertex = leaveApplicationVertex7, TailVertex = leaveApplicationVertex8 };

            //leaveApplicationArc19 = new BaseFlowArc { ID = Guid.NewGuid(), Describe = "",  CreateDate = DateTime.Now, HeadVertex = leaveApplicationVertex8, TailVertex = leaveApplicationVertex9 };

            //leaveApplicationVertex0 = new BaseFlowVertex { ID = Guid.NewGuid(), Name = "开始", Content = "此节点为流程开始节点", ActionURL = "workflow/baseflowitems", Type = "normal", CreateDate = DateTime.Now, BaseFlow = leaveApplication };
            //leaveApplicationVertex1 = new BaseFlowVertex { ID = Guid.NewGuid(), Name = "发起请假", Content = "此节点为发起请假节点", ActionURL = "workflow/baseflowitems", Type = "normal", CreateDate = DateTime.Now, BaseFlow = leaveApplication };
            //leaveApplicationVertex2 = new BaseFlowVertex { ID = Guid.NewGuid(), Name = "部门审批", Content = "此节点为部门审批节点", ActionURL = "workflow/baseflowitems", Type = "normal", CreateDate = DateTime.Now, BaseFlow = leaveApplication };
            //leaveApplicationVertex3 = new BaseFlowVertex { ID = Guid.NewGuid(), Name = "人力主管审批", Content = "此节点为人力主管审批节点", ActionURL = "workflow/baseflowitems", Type = "normal", CreateDate = DateTime.Now, BaseFlow = leaveApplication };
            //leaveApplicationVertex4 = new BaseFlowVertex { ID = Guid.NewGuid(), Name = "人力经理审批", Content = "此节点为人力经理审批节点", ActionURL = "workflow/baseflowitems", Type = "normal", CreateDate = DateTime.Now, BaseFlow = leaveApplication };
            //leaveApplicationVertex5 = new BaseFlowVertex { ID = Guid.NewGuid(), Name = "公司副总经理审批", Content = "此节点为公司副总经理审批节点", ActionURL = "workflow/baseflowitems", Type = "normal", CreateDate = DateTime.Now, BaseFlow = leaveApplication };
            //leaveApplicationVertex6 = new BaseFlowVertex { ID = Guid.NewGuid(), Name = "核销", Content = "此节点为核销节点", ActionURL = "workflow/baseflowitems", Type = "normal", CreateDate = DateTime.Now, BaseFlow = leaveApplication };
            //leaveApplicationVertex7 = new BaseFlowVertex { ID = Guid.NewGuid(), Name = "部门经理核实", Content = "此节点为部门经理核实节点", ActionURL = "workflow/baseflowitems", Type = "normal", CreateDate = DateTime.Now, BaseFlow = leaveApplication };
            //leaveApplicationVertex8 = new BaseFlowVertex { ID = Guid.NewGuid(), Name = "人力核实", Content = "此节点为人力核实节点", ActionURL = "workflow/baseflowitems", Type = "normal", CreateDate = DateTime.Now, BaseFlow = leaveApplication };
            //leaveApplicationVertex9 = new BaseFlowVertex { ID = Guid.NewGuid(), Name = "结束", Content = "此节点为结束节点", ActionURL = "workflow/baseflowitems", Type = "normal", CreateDate = DateTime.Now, BaseFlow = leaveApplication };
        }


        public List<BaseFlow> LoadAllBaseFlow()
        {
            return new List<BaseFlow>
            {
               leaveApplication
            };
        }

        public List<BaseFlowVertex> LoadAllBaseFlowVertex()
        {
            return new List<BaseFlowVertex>
            {
                leaveApplicationVertex1,
                leaveApplicationVertex2,
                leaveApplicationVertex3,
                leaveApplicationVertex4,
                leaveApplicationVertex5,
                leaveApplicationVertex6,
                leaveApplicationVertex7,
                leaveApplicationVertex8
            };
        }
    }
}
