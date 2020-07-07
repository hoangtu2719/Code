using EducationCode.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace EducationCode.Controllers
{
    public class TinCongNgheController : Controller
    {
        // GET: TinCongNghe
        private CODESHARKEntities db = new CODESHARKEntities();

        public PartialViewResult DanhMucTinCongNghe()
        {
            return PartialView(db.CHUDETCNs.ToList());
        }

        public ViewResult LocChuDe(int machude = 0)
        {
            List<TINCONGNGHE> tincongnghe = db.TINCONGNGHEs.Where(n => n.MACHUDE == machude).ToList();
            return View(tincongnghe);
        }
    }
}