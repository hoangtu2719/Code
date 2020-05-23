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
        CodeEntities db = new CodeEntities();
        // GET: Menu
        public PartialViewResult Menu()
        {
            return PartialView();
        }
    }
}