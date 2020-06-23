using EducationCode.Models;
using System.Linq;
using System.Web.Mvc;

namespace EducationCode.Controllers.NguoiDung
{
    public class DangNhapController : Controller
    {
        // GET: DangNhap
        private CODESHARKEntities db = new CODESHARKEntities();

        public ActionResult DangNhap()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DangNhap(FormCollection f)
        {
            string staikhoan = f["taikhoan"].ToString();
            string smatkhau = f["matkhau"].ToString();
            NGUOIDUNG nd = db.NGUOIDUNGs.SingleOrDefault(n => n.TAIKHOAN == staikhoan && n.MATKHAU == smatkhau);
            if (nd != null)
            {
                Session["NguoiDung"] = nd;
                return Redirect("/TrangChu/Index");
            }
            else if (staikhoan == "")
            {
                ViewBag.TBTK = "Nhập tài khoản";
            }
            else if (smatkhau == "")
            {
                ViewBag.TBMK = "Nhập mật khảu";
            }
            else
            {
                ViewBag.ThongBao = " <div class=alert - danger>Bạn nhập sai. Vui lòng nhập lại</div>";
            }
            return View();
        }
    }
}