using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace ISEN.MSH.MVC.Controllers.AdminController
{
    public class ReportController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetData()
        {
            StringBuilder str = new StringBuilder();
            str.Append("<graph caption='每月销售额柱形图' xAxisName='月份' yAxisName='Units' showNames='1' decimalPrecision='0' formatNumberScale='0'>");
            str.Append("<set name='一月' value='462' color='AFD8F8' />");
            str.Append("<set name='二月' value='857' color='F6BD0F' />");
            str.Append("<set name='三月' value='671' color='8BBA00' />");
            str.Append("<set name='四月' value='494' color='FF8E46' />");
            str.Append("<set name='五月' value='761' color='008E8E' />");
            str.Append("<set name='六月' value='960' color='D64646' />");
            str.Append("<set name='七月' value='629' color='8E468E' />");
            str.Append("<set name='八月' value='622' color='588526' />");
            str.Append("<set name='九月' value='376' color='B3AA00' />");
            str.Append("<set name='十月' value='494' color='008ED6' />");
            str.Append("<set name='十一月' value='761' color='9D080D' />");
            str.Append("<set name='十二月' value='960' color='A186BE' />");
            str.Append("</graph>");
            var data = new { d = str.ToString() };
            return Json(data);
        }

        public ActionResult Flot()
        {
            return View();
        }

        public JsonResult GetFlotData()
        {
            StringBuilder str = new StringBuilder();
            str.Append("");
            var data = new { };
            return Json(data);
        }

        public ActionResult CompareJson()
        {
            return View();
        }
    }
}
