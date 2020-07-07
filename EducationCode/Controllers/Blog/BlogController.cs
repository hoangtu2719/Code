using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EducationCode.Models;

namespace EducationCode.Controllers
{
    public class BlogController : Controller
    {
        CODESHARKEntities db = new CODESHARKEntities();
        // GET: Blog
        public ActionResult NhapBlog(BLOG blog)
        {
            NGUOIDUNG nd = (NGUOIDUNG)Session["NguoiDung"];
            blog.NGAYDANG = DateTime.Now;
            blog.MANGUOIDUNG = nd.MANGUOIDUNG;
            db.BLOGs.Add(blog);
            db.SaveChanges();
            //return Redirect("/TrangChu/Index");
            return Redirect(Request.UrlReferrer.ToString());
        }
        public ActionResult BinhLuanBlog(BINHLUANBLOG blb)
        {
            NGUOIDUNG nd = (NGUOIDUNG)Session["NguoiDung"];
            blb.NGAYDANG = DateTime.Now;
            blb.MANGUOIDUNG = nd.MANGUOIDUNG;
            db.BINHLUANBLOGs.Add(blb);
            db.SaveChanges();
            return Redirect("/TrangChu/Index");
        }
    }
}