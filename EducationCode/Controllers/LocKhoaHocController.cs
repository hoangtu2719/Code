using EducationCode.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace EducationCode.Controllers
{
    public class LocKhoaHocController : Controller
    {
        // GET: LocKhoaHoc
        private CODESHARKEntities db = new CODESHARKEntities();

        public PartialViewResult LocKhoaHocMoiNhat()
        {
            return PartialView(db.KHOAHOCs.ToList());
        }

        public PartialViewResult LocKhoaHocXemNhieu()
        {
            List<KHOAHOC> kh = db.KHOAHOCs.OrderByDescending(n => n.LUOTXEM).Take(4).ToList();
            return PartialView("LocKhoaHocMoiNhat", kh);
        }
        public PartialViewResult LocBaiVietXemNhieu()
        {
            return PartialView(db.BAIHOCs.ToList());
        }
    }
}