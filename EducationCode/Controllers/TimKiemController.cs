using EducationCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EducationCode.Controllers
{
    public class TimKiemController : Controller
    {
        // GET: TimKiem
        CODESHARKEntities db = new CODESHARKEntities();
        public ActionResult TimKiem(string tukhoa)
        {
            List<KHOAHOC> bh = db.KHOAHOCs.Where(n => n.TENKHOAHOC.Contains(tukhoa)).ToList();
            return View(bh);
        }
    }
}