using EducationCode.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace EducationCode.Controllers
{
    public class TimKiemController : Controller
    {
        // GET: TimKiem
        private CODESHARKEntities db = new CODESHARKEntities();

        public ActionResult TimKiem(string tukhoa)
        {
            List<KHOAHOC> bh = db.KHOAHOCs.Where(n => n.TENKHOAHOC.Contains(tukhoa)).ToList();
            return View(bh);
        }
    }
}