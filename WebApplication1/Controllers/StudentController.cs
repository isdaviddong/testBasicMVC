using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            var dat = new List<Models.Student>();
            dat.Add(new Models.Student { StuName = "David", Address = "台北", TEL = "0912345678" });
            dat.Add(new Models.Student { StuName = "Eric", Address = "台北", TEL = "0912345412" });
            dat.Add(new Models.Student { StuName = "Amy", Address = "台北", TEL = "0912356678" });

            ViewData.Model = dat;
            return View(dat);
        }
    }
}