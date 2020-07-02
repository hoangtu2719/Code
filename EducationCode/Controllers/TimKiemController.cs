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
            List<BAIHOC> bh = db.BAIHOCs.Where(n => n.TENBAIHOC.Contains(tukhoa)).ToList();
            return View(bh);
        }
    }
}