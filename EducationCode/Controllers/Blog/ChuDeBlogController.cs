using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EducationCode.Models;
namespace EducationCode.Controllers.Blog
{
    public class ChuDeBlogController : Controller
    {
        CODESHARKEntities db = new CODESHARKEntities();
        // GET: ChuDeBlog
        public PartialViewResult ChuDeBlog()
        {
            return PartialView(db.CHUDEBLOGs.ToList());
        }
        public ViewResult LocChuDeBlog(int machude = 0)
        {
            List<BLOG> chudeblog = db.BLOGs.Where(n => n.MACHUDEBLOG == machude).ToList();
            return View(chudeblog);
        }
    }
}