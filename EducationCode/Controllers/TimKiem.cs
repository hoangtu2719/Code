using EducationCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EducationCode.Models;

namespace EducationCode.Controllers
{
    public class TimKiem : Controller
    {
        CODESHARKEntities db = new CODESHARKEntities();
        // GET: BinhLuan
        public ActionResult TimKiem(string tukhoa)
        {
            List<BAIHOC> bh = db.BAIHOCs.Where(n => n.TENBAIHOC.Contains(tukhoa)).ToList();
            return View(bh);
        }
    }
}