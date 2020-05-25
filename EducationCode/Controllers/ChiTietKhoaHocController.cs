using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EducationCode.Models;

namespace EducationCode.Controllers
{   
    public class ChiTietKhoaHocController : Controller
    {
        // GET: ChiTietKhoaHoc
        DataCodeSharkEntities db = new DataCodeSharkEntities();
        public ActionResult Index()
        {
            return View();
        }
        public ViewResult ChiTietBaiVietMN(int makhoahoc = 0)
        {
            List<tbBAIHOC> baihoc = db.tbBAIHOCs.Where(n => n.MaKhoahoc== makhoahoc).ToList();
            return View(baihoc);
        }
    }
}