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
        DataCodeSharkEntities db = new DataCodeSharkEntities();
        public PartialViewResult LocKhoaHocMoiNhat()
        {
            return PartialView(db.tbKHOAHOCs.ToList());
        }
        public PartialViewResult LocKhoaHocXemNhieu()
        {
            return PartialView(db.tbKHOAHOCs.ToList());
        }
        public ActionResult LocTatCaKhoaHoc()
        {
            return View(db.tbKHOAHOCs.ToList());
        }
        public ActionResult TatCacKhoaHocXemNhieu()
        {
            return View(db.tbKHOAHOCs.ToList());
        }
    }
}