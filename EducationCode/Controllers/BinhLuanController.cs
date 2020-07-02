using EducationCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EducationCode.Controllers
{
    public class BinhLuanController : Controller
    {
        CODESHARKEntities db = new CODESHARKEntities();
        // GET: BinhLuan
        public ActionResult NhapBinhLuan(BINHLUAN bl)
        {
            NGUOIDUNG nd = (NGUOIDUNG)Session["NguoiDung"];
            bl.NGAYDANG = DateTime.Now;
            bl.MANGUOIDUNG = nd.MANGUOIDUNG;
            db.BINHLUANs.Add(bl);
            db.SaveChanges();
            return Redirect("/TrangChu/Index");
        }
    }
}