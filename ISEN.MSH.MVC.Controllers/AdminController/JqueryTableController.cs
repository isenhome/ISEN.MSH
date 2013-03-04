using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using ISEN.MSH.MVC.Controllers.Filters;

namespace ISEN.MSH.MVC.Controllers.AdminController
{
    [UserActionFilter]
    public class JqueryTableController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetData()
        {
            return Json(new
            {
                aaData = new List<object> {
                                         new string[] {"1","公司信息","地址信息","城市信息"},
                                         new string[] {"1","公司信息","地址信息","城市信息"},
                                         new string[] {"1","公司信息","地址信息","城市信息"},
                                         new string[] {"1","公司信息","地址信息","城市信息"},
                                         new string[] {"1","公司信息","地址信息","城市信息"},
                                         new string[] {"1","公司信息","地址信息","城市信息"},
                                         new string[] {"1","公司信息","地址信息","城市信息"},
                                         new string[] {"1","公司信息","地址信息","城市信息"},
                                         new string[] {"1","公司信息","地址信息","城市信息"},
                                         new string[]{"1","公司信息","地址信息","城市信息"}
                                           }
            }, JsonRequestBehavior.AllowGet);
        }
    }
}
