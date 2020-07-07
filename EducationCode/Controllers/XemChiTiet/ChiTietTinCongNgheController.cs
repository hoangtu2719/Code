using EducationCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EducationCode.Controllers.XemChiTiet
{
    public class ChiTietTinCongNgheController : Controller
    {
        CODESHARKEntities db = new CODESHARKEntities();
        // GET: ChiTietTinCongNghe
        public ActionResult ChiTietTCN( int machitiet = 0)
        {
            TINCONGNGHE tincongnghe = db.TINCONGNGHEs.SingleOrDefault(n => n.MATCN == machitiet);
            return View(tincongnghe);
        }
    }
}