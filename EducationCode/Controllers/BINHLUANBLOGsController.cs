using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using EducationCode.Models;

namespace EducationCode.Controllers
{
    public class BINHLUANBLOGsController : Controller
    {
        private CODESHARKEntities db = new CODESHARKEntities();

        // GET: BINHLUANBLOGs
        public ActionResult Index()
        {
            var bINHLUANBLOGs = db.BINHLUANBLOGs.Include(b => b.BLOG).Include(b => b.NGUOIDUNG);
            return View(bINHLUANBLOGs.ToList());
        }

        // GET: BINHLUANBLOGs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BINHLUANBLOG bINHLUANBLOG = db.BINHLUANBLOGs.Find(id);
            if (bINHLUANBLOG == null)
            {
                return HttpNotFound();
            }
            return View(bINHLUANBLOG);
        }

        // GET: BINHLUANBLOGs/Create
        public ActionResult Create()
        {
            ViewBag.MABLOG = new SelectList(db.BLOGs, "MABLOG", "NOIDUNG");
            ViewBag.MANGUOIDUNG = new SelectList(db.NGUOIDUNGs, "MANGUOIDUNG", "TAIKHOAN");
            return View();
        }

        // POST: BINHLUANBLOGs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MABINHLUANBLOG,MACHUDEBLOG,MANGUOIDUNG,NOIDUNG,NGAYDANG,MABLOG")] BINHLUANBLOG bINHLUANBLOG)
        {
            if (ModelState.IsValid)
            {
                db.BINHLUANBLOGs.Add(bINHLUANBLOG);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MABLOG = new SelectList(db.BLOGs, "MABLOG", "NOIDUNG", bINHLUANBLOG.MABLOG);
            ViewBag.MANGUOIDUNG = new SelectList(db.NGUOIDUNGs, "MANGUOIDUNG", "TAIKHOAN", bINHLUANBLOG.MANGUOIDUNG);
            return View(bINHLUANBLOG);
        }

        // GET: BINHLUANBLOGs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BINHLUANBLOG bINHLUANBLOG = db.BINHLUANBLOGs.Find(id);
            if (bINHLUANBLOG == null)
            {
                return HttpNotFound();
            }
            ViewBag.MABLOG = new SelectList(db.BLOGs, "MABLOG", "NOIDUNG", bINHLUANBLOG.MABLOG);
            ViewBag.MANGUOIDUNG = new SelectList(db.NGUOIDUNGs, "MANGUOIDUNG", "TAIKHOAN", bINHLUANBLOG.MANGUOIDUNG);
            return View(bINHLUANBLOG);
        }

        // POST: BINHLUANBLOGs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MABINHLUANBLOG,MACHUDEBLOG,MANGUOIDUNG,NOIDUNG,NGAYDANG,MABLOG")] BINHLUANBLOG bINHLUANBLOG)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bINHLUANBLOG).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MABLOG = new SelectList(db.BLOGs, "MABLOG", "NOIDUNG", bINHLUANBLOG.MABLOG);
            ViewBag.MANGUOIDUNG = new SelectList(db.NGUOIDUNGs, "MANGUOIDUNG", "TAIKHOAN", bINHLUANBLOG.MANGUOIDUNG);
            return View(bINHLUANBLOG);
        }

        // GET: BINHLUANBLOGs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BINHLUANBLOG bINHLUANBLOG = db.BINHLUANBLOGs.Find(id);
            if (bINHLUANBLOG == null)
            {
                return HttpNotFound();
            }
            return View(bINHLUANBLOG);
        }

        // POST: BINHLUANBLOGs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BINHLUANBLOG bINHLUANBLOG = db.BINHLUANBLOGs.Find(id);
            db.BINHLUANBLOGs.Remove(bINHLUANBLOG);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
