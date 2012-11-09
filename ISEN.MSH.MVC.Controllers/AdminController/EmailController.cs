using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using ISEN.MSH.MVC.Controllers.Filters;
using System.IO;
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

        public void File()
        {
            foreach (string upload in Request.Files)
            {
                string path = AppDomain.CurrentDomain.BaseDirectory + "uploads";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                string filename = Path.GetFileName(Request.Files[upload].FileName);
                Request.Files[upload].SaveAs(Path.Combine(path, filename));
            }
        }
    }
}
