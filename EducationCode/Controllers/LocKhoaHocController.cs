using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EducationCode.Models;

namespace EducationCode.Controllers
{
    public class LocKhoaHocController : Controller
    {
        // GET: LocKhoaHoc
        DataCodeSharkEntities db = new DataCodeSharkEntities();
        public PartialViewResult LocKhoaHocMoiNhat()
        {
            return PartialView(db.tbKHOAHOCs.ToList());
        }
    }
}