﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ISEN.MSH.MVC.Controllers.AdminController
{
    public class WorkFlowController : BaseController
    {
        //
        // GET: /WorkFlow/

        public ActionResult CreateWorkFlow()
        {
            return View();
        }

        public ActionResult NewWorkFlow()
        {
            return View();
        }

    }
}
