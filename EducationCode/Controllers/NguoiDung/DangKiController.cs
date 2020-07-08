using EducationCode.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace EducationCode.Controllers.NguoiDung
{
    public class DangKiController : Controller
    {
        // GET: DangKi
        private CODESHARKEntities db = new CODESHARKEntities();

        public ActionResult DangKi()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Dangki([Bind(Include = "MANGUOIDUNG,TAIKHOAN,MATKHAU,TENDANGNHAP,EMAIL,DIACHI,SOCMND,SODIENTHOAI,AnhNguoiDung")] NGUOIDUNG nGUOIDUNG, String nhaplaimk, string taikhoan)
        {
            if (ModelState.IsValid)
            {
                //Kiểm tra mật khảu có trùng khớp
                if (nhaplaimk != nGUOIDUNG.MATKHAU)
                {
                    ViewBag.ThongBao = "Mật khẩu không trùng khớp";
                    return View();
                }
                //Kiểm tra mật khảu có trùng khớp
                NGUOIDUNG nd = db.NGUOIDUNGs.SingleOrDefault(n => n.TAIKHOAN == nGUOIDUNG.TAIKHOAN);
                if (nd != null)
                {
                    ViewBag.TaiKhoan = "Tài khoản đã tồn tại";
                    return View();
                }
                db.NGUOIDUNGs.Add(nGUOIDUNG);
                db.SaveChanges();
                return Redirect("/DangKi/DangKiThanhCong");
            }
            return View(nGUOIDUNG);
        }

        public ActionResult DangKiThanhCong()
        {
            return View();
        }
    }
}