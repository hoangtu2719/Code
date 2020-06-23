using EducationCode.Models;
using System.Linq;
using System.Web.Mvc;

namespace EducationCode.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        private CODESHARKEntities db = new CODESHARKEntities();

        public PartialViewResult Menu()
        {
            return PartialView();
        }

        public PartialViewResult DanhSachKhoaHoc()
        {
            return PartialView(db.KHOAHOCs.ToList());
        }

        public PartialViewResult Banner()
        {
            return PartialView();
        }
    }
}