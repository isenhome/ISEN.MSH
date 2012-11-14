using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using ISEN.MSH.MVC.Controllers.Filters;
using ISEN.MSH.APP.Service.Calendar.Models;

namespace ISEN.MSH.MVC.Controllers.AdminController
{
    [UserActionFilter]
    public class CalendarController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult SubmitWork(Work work)
        {
            if (work.idcode == null)
            {
                work.idcode = Guid.NewGuid().ToString();
            }
            var result = new { result_code = 200, success = true, data = new { work } };
            return Json(result);
        }

        [HttpGet]
        public JsonResult GetWork(Work data)
        {
            Work work = new Work();
            work.idcode = data.idcode;
            work.title = data.title;
            work.isallday = data.isallday;
            work.start =data.start;
            work.end = data.end;
            work.remindtime = "15";
            work.isremind = "true";
            work.content = "new work content";
            var result = new { result_code = 200, success = true, data = new { work } };
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult RemoveWork(Work work)
        {
            var result = new { result_code = 200, success = true, data = new { work } };
            return Json(result);
        }

        [HttpPost]
        public JsonResult ResizeWork(Work work)
        {
            var result = new { result_code = 200, success = true, data = new { work } };
            return Json(result);
        }
    }
}
