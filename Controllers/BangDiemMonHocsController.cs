using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DOAN_WEB_NC.DAL;
using DOAN_WEB_NC.Models;

namespace DOAN_WEB_NC.Controllers
{
    public class BangDiemMonHocsController : Controller
    {
        private SchoolContext db = new SchoolContext();

        // GET: BangDiemMonHocs
        public ActionResult Index()
        {
            var bangDiemMonHocs = db.BangDiemMonHocs.Include(b => b.Lop).Include(b => b.MonHoc);
            return View(bangDiemMonHocs.ToList());
        }

        // GET: BangDiemMonHocs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BangDiemMonHoc bangDiemMonHoc = db.BangDiemMonHocs.Find(id);
            if (bangDiemMonHoc == null)
            {
                return HttpNotFound();
            }
            return View(bangDiemMonHoc);
        }

        // GET: BangDiemMonHocs/Create
        public ActionResult Create()
        {
            ViewBag.IDLop = new SelectList(db.Lops, "IDLop", "IDLop");
            ViewBag.IDMonHoc = new SelectList(db.MonHocs, "IDMonHoc", "TenMonHoc");
            return View();
        }

        // POST: BangDiemMonHocs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDBangDiem,IDMonHoc,IDLop")] BangDiemMonHoc bangDiemMonHoc)
        {
            if (ModelState.IsValid)
            {
                db.BangDiemMonHocs.Add(bangDiemMonHoc);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IDLop = new SelectList(db.Lops, "IDLop", "IDLop", bangDiemMonHoc.IDLop);
            ViewBag.IDMonHoc = new SelectList(db.MonHocs, "IDMonHoc", "TenMonHoc", bangDiemMonHoc.IDMonHoc);
            return View(bangDiemMonHoc);
        }

        // GET: BangDiemMonHocs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BangDiemMonHoc bangDiemMonHoc = db.BangDiemMonHocs.Find(id);
            if (bangDiemMonHoc == null)
            {
                return HttpNotFound();
            }
            ViewBag.IDLop = new SelectList(db.Lops, "IDLop", "IDLop", bangDiemMonHoc.IDLop);
            ViewBag.IDMonHoc = new SelectList(db.MonHocs, "IDMonHoc", "TenMonHoc", bangDiemMonHoc.IDMonHoc);
            return View(bangDiemMonHoc);
        }

        // POST: BangDiemMonHocs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDBangDiem,IDMonHoc,IDLop")] BangDiemMonHoc bangDiemMonHoc)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bangDiemMonHoc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IDLop = new SelectList(db.Lops, "IDLop", "IDLop", bangDiemMonHoc.IDLop);
            ViewBag.IDMonHoc = new SelectList(db.MonHocs, "IDMonHoc", "TenMonHoc", bangDiemMonHoc.IDMonHoc);
            return View(bangDiemMonHoc);
        }

        // GET: BangDiemMonHocs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BangDiemMonHoc bangDiemMonHoc = db.BangDiemMonHocs.Find(id);
            if (bangDiemMonHoc == null)
            {
                return HttpNotFound();
            }
            return View(bangDiemMonHoc);
        }

        // POST: BangDiemMonHocs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            BangDiemMonHoc bangDiemMonHoc = db.BangDiemMonHocs.Find(id);
            db.BangDiemMonHocs.Remove(bangDiemMonHoc);
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
