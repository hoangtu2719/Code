using EducationCode.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace EducationCode.Controllers
{
    public class ChiTietKhoaHocController : Controller
    {
        // GET: ChiTietKhoaHoc
        private CODESHARKEntities db = new CODESHARKEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ViewResult ChiTietBaiVietMN(int makhoahoc = 0)
        {
            List<BAIHOC> baihoc = db.BAIHOCs.Where(n => n.MAKHOAHOC == makhoahoc).ToList();
            return View(baihoc);
        }

        public ViewResult ChiTietBaiVietXN(int makhoahoc = 0)
        {
            List<BAIHOC> baihoc = db.BAIHOCs.Where(n => n.MAKHOAHOC == makhoahoc).ToList();
            return View(baihoc);
        }
    }
}