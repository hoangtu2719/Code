using EducationCode.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EducationCode.Controllers
{
    public class TraLoiController : Controller
    {
        // GET: TraLoi
        CODESHARKEntities db = new CODESHARKEntities();
        public ActionResult TraLoi(TRALOI tl)
        {
            NGUOIDUNG nd = (NGUOIDUNG)Session["NguoiDung"];
            tl.NGAYDANG = DateTime.Now;
            tl.MANGUOIDUNG = nd.MANGUOIDUNG;
            db.TRALOIs.Add(tl);
            db.SaveChanges();
            return Redirect("/TrangChu/Index");
        }
    }
}