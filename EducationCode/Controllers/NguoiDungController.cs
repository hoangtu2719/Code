﻿using System;
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
     
   

    }
}