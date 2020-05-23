using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EducationCode.Models;

namespace EducationCode.Controllers
{
    public class NguoiDungController : Controller
    {
        CodeEntities db = new CodeEntities();
        // GET: NguoiDung
        public ActionResult NguoiDung()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Dangnhap(FormCollection f)
        {
            String taikhoan = f["txttaikhoan"].ToString();
            String matkhau = f["txtmatkhau"].ToString();
            NGUOIDUNG nd = db.NGUOIDUNGs.SingleOrDefault(n => n.TenNguoiDung == taikhoan && n.MatKhau == matkhau);
            if(nd != null)
            {
                Session["NguoiDung"] = nd;
                return Redirect(Request.UrlReferrer.ToString());
            }
            else
            {
                ViewBag.ThongBao = "Dang nhap that bai"
            }
        }

    }
}