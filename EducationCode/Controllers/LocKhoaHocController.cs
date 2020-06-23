using EducationCode.Models;
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
            return PartialView(db.KHOAHOCs.ToList());
        }
    }
}