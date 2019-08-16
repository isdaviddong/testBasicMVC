using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class PassDataController : Controller
    {
        // GET: PassData
        public ActionResult PassViewData()
        {
            ViewData["Name"] = "David";
            ViewData["age"] = 18;
            ViewData["TEL"] = "0912345678";

            return View();

        }

        public ActionResult PassViewBag()
        {
            ViewBag.Name = "David";
            ViewBag.age = 18;
            ViewBag.TEL = "0912345678";
            ViewBag.Address = "台北市";
            ViewBag.XXXX = "台北市";

            
            return View();

        }
    }
}