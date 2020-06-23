using System.Web.Mvc;

namespace EducationCode.Controllers.NguoiDung
{
    public class DangXuatController : Controller
    {
        // GET: DangXuat
        public ActionResult DangXuat()
        {
            Session["NguoiDung"] = null;
            return Redirect("/TrangChu/Index");
        }
    }
}