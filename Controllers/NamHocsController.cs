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
    public class NamHocsController : Controller
    {
        private SchoolContext db = new SchoolContext();

        // GET: NamHocs
        public ActionResult Index()
        {
            return View(db.NamHocs.ToList());
        }

        // GET: NamHocs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NamHoc namHoc = db.NamHocs.Find(id);
            if (namHoc == null)
            {
                return HttpNotFound();
            }
            return View(namHoc);
        }

        // GET: NamHocs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NamHocs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDNamHoc,NamBD,NamKT,HocKy")] NamHoc namHoc)
        {
            if (ModelState.IsValid)
            {
                db.NamHocs.Add(namHoc);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(namHoc);
        }

        // GET: NamHocs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NamHoc namHoc = db.NamHocs.Find(id);
            if (namHoc == null)
            {
                return HttpNotFound();
            }
            return View(namHoc);
        }

        // POST: NamHocs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDNamHoc,NamBD,NamKT,HocKy")] NamHoc namHoc)
        {
            if (ModelState.IsValid)
            {
                db.Entry(namHoc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(namHoc);
        }

        // GET: NamHocs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NamHoc namHoc = db.NamHocs.Find(id);
            if (namHoc == null)
            {
                return HttpNotFound();
            }
            return View(namHoc);
        }

        // POST: NamHocs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NamHoc namHoc = db.NamHocs.Find(id);
            db.NamHocs.Remove(namHoc);
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
