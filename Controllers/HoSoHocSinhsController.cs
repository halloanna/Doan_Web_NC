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
    public class HoSoHocSinhsController : Controller
    {
        private SchoolContext db = new SchoolContext();

        // GET: HoSoHocSinhs
        public ActionResult Index()
        {
            return View(db.HoSoHocSinhs.ToList());
        }

        // GET: HoSoHocSinhs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HoSoHocSinh hoSoHocSinh = db.HoSoHocSinhs.Find(id);
            if (hoSoHocSinh == null)
            {
                return HttpNotFound();
            }
            return View(hoSoHocSinh);
        }

        // GET: HoSoHocSinhs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HoSoHocSinhs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDHocSinh,HoTen,GioiTinh,Image,NgaySinh,DiaChi,Email")] HoSoHocSinh hoSoHocSinh)
        {
            if (ModelState.IsValid)
            {
                db.HoSoHocSinhs.Add(hoSoHocSinh);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(hoSoHocSinh);
        }

        // GET: HoSoHocSinhs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HoSoHocSinh hoSoHocSinh = db.HoSoHocSinhs.Find(id);
            if (hoSoHocSinh == null)
            {
                return HttpNotFound();
            }
            return View(hoSoHocSinh);
        }

        // POST: HoSoHocSinhs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDHocSinh,HoTen,GioiTinh,Image,NgaySinh,DiaChi,Email")] HoSoHocSinh hoSoHocSinh)
        {
            if (ModelState.IsValid)
            {
                db.Entry(hoSoHocSinh).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(hoSoHocSinh);
        }

        // GET: HoSoHocSinhs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            HoSoHocSinh hoSoHocSinh = db.HoSoHocSinhs.Find(id);
            if (hoSoHocSinh == null)
            {
                return HttpNotFound();
            }
            return View(hoSoHocSinh);
        }

        // POST: HoSoHocSinhs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HoSoHocSinh hoSoHocSinh = db.HoSoHocSinhs.Find(id);
            db.HoSoHocSinhs.Remove(hoSoHocSinh);
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
