using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using ISEN.MSH.MVC.Controllers.Filters;
using System.Web;

namespace ISEN.MSH.MVC.Controllers.AdminController
{
    [UserActionFilter]
    public class EmailController:BaseController
    {
        public ActionResult Index()
        {
            return BaseView();
        }

        public ActionResult ShortCut()
        {
            return PartialView();
        }

        public void UploadFile()
        {
            foreach (string upload in Request.Files)
            {
                string path = AppDomain.CurrentDomain.BaseDirectory + "uploads";
                if (!System.IO.Directory.Exists(path))
                {
                    System.IO.Directory.CreateDirectory(path);
                }
                string filename = System.IO.Path.GetFileName(Request.Files[upload].FileName);
                Request.Files[upload].SaveAs(System.IO.Path.Combine(path, filename));
            }
        }

        public JsonResult DeleteFile(string fileID,string fileName)
        {
            object result;
            string path = AppDomain.CurrentDomain.BaseDirectory + @"uploads\" + fileName;
            if (System.IO.File.Exists(path))
            {
                //如果存在则删除
                System.IO.File.Delete(path);
                result = new { result_code = 200, success = true };
            }
            else
            {
                result = new { result_code = 400, success = false };
            }
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}
