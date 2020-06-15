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
    public class ChiTietBangDiemMonHocsController : Controller
    {
        private SchoolContext db = new SchoolContext();

        // GET: ChiTietBangDiemMonHocs
        public ActionResult Index()
        {
            var chiTietBangDiemMonHocs = db.ChiTietBangDiemMonHocs.Include(c => c.BangDiemMonHoc).Include(c => c.HoSoHocSinh);
            return View(chiTietBangDiemMonHocs.ToList());
        }

        // GET: ChiTietBangDiemMonHocs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiTietBangDiemMonHoc chiTietBangDiemMonHoc = db.ChiTietBangDiemMonHocs.Find(id);
            if (chiTietBangDiemMonHoc == null)
            {
                return HttpNotFound();
            }
            return View(chiTietBangDiemMonHoc);
        }

        // GET: ChiTietBangDiemMonHocs/Create
        public ActionResult Create()
        {
            ViewBag.IDBangDiemMonHoc = new SelectList(db.BangDiemMonHocs, "IDBangDiem", "IDBangDiem");
            ViewBag.IDHocSinh = new SelectList(db.HoSoHocSinhs, "IDHocSinh", "HoTen");
            return View();
        }

        // POST: ChiTietBangDiemMonHocs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDChiTietBangDiemMonHoc,IDBangDiemMonHoc,IDHocSinh,Diem15p,Diem1t,DiemTB")] ChiTietBangDiemMonHoc chiTietBangDiemMonHoc)
        {
            if (ModelState.IsValid)
            {
                db.ChiTietBangDiemMonHocs.Add(chiTietBangDiemMonHoc);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IDBangDiemMonHoc = new SelectList(db.BangDiemMonHocs, "IDBangDiem", "IDBangDiem", chiTietBangDiemMonHoc.IDBangDiemMonHoc);
            ViewBag.IDHocSinh = new SelectList(db.HoSoHocSinhs, "IDHocSinh", "HoTen", chiTietBangDiemMonHoc.IDHocSinh);
            return View(chiTietBangDiemMonHoc);
        }

        // GET: ChiTietBangDiemMonHocs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiTietBangDiemMonHoc chiTietBangDiemMonHoc = db.ChiTietBangDiemMonHocs.Find(id);
            if (chiTietBangDiemMonHoc == null)
            {
                return HttpNotFound();
            }
            ViewBag.IDBangDiemMonHoc = new SelectList(db.BangDiemMonHocs, "IDBangDiem", "IDBangDiem", chiTietBangDiemMonHoc.IDBangDiemMonHoc);
            ViewBag.IDHocSinh = new SelectList(db.HoSoHocSinhs, "IDHocSinh", "HoTen", chiTietBangDiemMonHoc.IDHocSinh);
            return View(chiTietBangDiemMonHoc);
        }

        // POST: ChiTietBangDiemMonHocs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDChiTietBangDiemMonHoc,IDBangDiemMonHoc,IDHocSinh,Diem15p,Diem1t,DiemTB")] ChiTietBangDiemMonHoc chiTietBangDiemMonHoc)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chiTietBangDiemMonHoc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IDBangDiemMonHoc = new SelectList(db.BangDiemMonHocs, "IDBangDiem", "IDBangDiem", chiTietBangDiemMonHoc.IDBangDiemMonHoc);
            ViewBag.IDHocSinh = new SelectList(db.HoSoHocSinhs, "IDHocSinh", "HoTen", chiTietBangDiemMonHoc.IDHocSinh);
            return View(chiTietBangDiemMonHoc);
        }

        // GET: ChiTietBangDiemMonHocs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiTietBangDiemMonHoc chiTietBangDiemMonHoc = db.ChiTietBangDiemMonHocs.Find(id);
            if (chiTietBangDiemMonHoc == null)
            {
                return HttpNotFound();
            }
            return View(chiTietBangDiemMonHoc);
        }

        // POST: ChiTietBangDiemMonHocs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ChiTietBangDiemMonHoc chiTietBangDiemMonHoc = db.ChiTietBangDiemMonHocs.Find(id);
            db.ChiTietBangDiemMonHocs.Remove(chiTietBangDiemMonHoc);
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
