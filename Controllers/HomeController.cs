using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NgoNguyenHoangPhuong_KiemtraFE.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult test()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult trangchu()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult tiki ()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}