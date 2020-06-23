using EducationCode.Models;
using System.Linq;
using System.Web.Mvc;

namespace EducationCode.Controllers
{
    public class ChiTietBaiHocController : Controller
    {
        // GET: ChiTietBaiHoc
        private CODESHARKEntities db = new CODESHARKEntities();

        public ActionResult ChiTietBaiHoc(int machitiet = 0)
        {
            BAIHOC baihoc = db.BAIHOCs.SingleOrDefault(n => n.MABAIHOC == machitiet);
            return View(baihoc);
        }
    }
}