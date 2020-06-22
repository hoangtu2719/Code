using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EducationCode.Models;

namespace EducationCode.Controllers
{   
    public class ChiTietKhoaHocController : Controller
    {
        // GET: ChiTietKhoaHoc
        CODESHARKEntities db = new CODESHARKEntities();
        public ActionResult Index()
        {
            return View();
        }
        public ViewResult ChiTietBaiVietMN(int makhoahoc = 0)
        {
            List<BAIHOC> baihoc = db.BAIHOCs.Where(n => n.MAKHOAHOC== makhoahoc).ToList();
            return View(baihoc);
        }
        public ViewResult ChiTietBaiVietXN(int makhoahoc = 0)
        {
            List<BAIHOC> baihoc = db.BAIHOCs.Where(n => n.MABAIHOC==makhoahoc).ToList();
            return View(baihoc);
        }
    }
}