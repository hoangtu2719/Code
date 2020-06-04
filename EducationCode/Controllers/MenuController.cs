using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EducationCode.Models;

namespace EducationCode.Controllers
{
    public class MenuController : Controller
    {
        // GET: Menu
        CODESHARKEntities db = new CODESHARKEntities();
        public PartialViewResult Menu()
        {
            return PartialView();
        }
        public PartialViewResult DanhSachKhoaHoc()
        {
            return PartialView(db.KHOAHOCs.ToList());
        }
    }
}