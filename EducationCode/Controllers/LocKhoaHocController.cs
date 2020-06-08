using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EducationCode.Models;

namespace EducationCode.Controllers
{
    public class LocKhoaHocController : Controller
    {
        // GET: LocKhoaHoc
        CODESHARKEntities db = new CODESHARKEntities();
        public PartialViewResult LocKhoaHocMoiNhat()
        {
            return PartialView(db.KHOAHOCs.ToList());
        }
        public PartialViewResult LocKhoaHocXemNhieu()
        {
            return PartialView(db.KHOAHOCs.ToList());
        }
        public ActionResult LocTatCaKhoaHoc()
        {
            return View(db.KHOAHOCs.ToList());
        }
        public ActionResult TatCacKhoaHocXemNhieu()
        {
            return View(db.KHOAHOCs.ToList());
        }
    }
}