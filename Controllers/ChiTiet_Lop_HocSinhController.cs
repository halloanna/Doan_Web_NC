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
    public class ChiTiet_Lop_HocSinhController : Controller
    {
        private SchoolContext db = new SchoolContext();

        // GET: ChiTiet_Lop_HocSinh
        public ActionResult Index()
        {
            var chiTiet_Lop_HocSinhs = db.ChiTiet_Lop_HocSinhs.Include(c => c.HoSoHocSinh).Include(c => c.Lop);
            return View(chiTiet_Lop_HocSinhs.ToList());
        }

        // GET: ChiTiet_Lop_HocSinh/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiTiet_Lop_HocSinh chiTiet_Lop_HocSinh = db.ChiTiet_Lop_HocSinhs.Find(id);
            if (chiTiet_Lop_HocSinh == null)
            {
                return HttpNotFound();
            }
            return View(chiTiet_Lop_HocSinh);
        }

        // GET: ChiTiet_Lop_HocSinh/Create
        public ActionResult Create()
        {
            ViewBag.IDHocSinh = new SelectList(db.HoSoHocSinhs, "IDHocSinh", "HoTen");
            ViewBag.IDLop = new SelectList(db.Lops, "IDLop", "IDLop");
            return View();
        }

        // POST: ChiTiet_Lop_HocSinh/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDChiTiet_Lop_HocSinh,IDHocSinh,IDLop,TBHKI,TBHKII")] ChiTiet_Lop_HocSinh chiTiet_Lop_HocSinh)
        {
            if (ModelState.IsValid)
            {
                db.ChiTiet_Lop_HocSinhs.Add(chiTiet_Lop_HocSinh);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.IDHocSinh = new SelectList(db.HoSoHocSinhs, "IDHocSinh", "HoTen", chiTiet_Lop_HocSinh.IDHocSinh);
            ViewBag.IDLop = new SelectList(db.Lops, "IDLop", "IDLop", chiTiet_Lop_HocSinh.IDLop);
            return View(chiTiet_Lop_HocSinh);
        }

        // GET: ChiTiet_Lop_HocSinh/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiTiet_Lop_HocSinh chiTiet_Lop_HocSinh = db.ChiTiet_Lop_HocSinhs.Find(id);
            if (chiTiet_Lop_HocSinh == null)
            {
                return HttpNotFound();
            }
            ViewBag.IDHocSinh = new SelectList(db.HoSoHocSinhs, "IDHocSinh", "HoTen", chiTiet_Lop_HocSinh.IDHocSinh);
            ViewBag.IDLop = new SelectList(db.Lops, "IDLop", "IDLop", chiTiet_Lop_HocSinh.IDLop);
            return View(chiTiet_Lop_HocSinh);
        }

        // POST: ChiTiet_Lop_HocSinh/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDChiTiet_Lop_HocSinh,IDHocSinh,IDLop,TBHKI,TBHKII")] ChiTiet_Lop_HocSinh chiTiet_Lop_HocSinh)
        {
            if (ModelState.IsValid)
            {
                db.Entry(chiTiet_Lop_HocSinh).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.IDHocSinh = new SelectList(db.HoSoHocSinhs, "IDHocSinh", "HoTen", chiTiet_Lop_HocSinh.IDHocSinh);
            ViewBag.IDLop = new SelectList(db.Lops, "IDLop", "IDLop", chiTiet_Lop_HocSinh.IDLop);
            return View(chiTiet_Lop_HocSinh);
        }

        // GET: ChiTiet_Lop_HocSinh/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChiTiet_Lop_HocSinh chiTiet_Lop_HocSinh = db.ChiTiet_Lop_HocSinhs.Find(id);
            if (chiTiet_Lop_HocSinh == null)
            {
                return HttpNotFound();
            }
            return View(chiTiet_Lop_HocSinh);
        }

        // POST: ChiTiet_Lop_HocSinh/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ChiTiet_Lop_HocSinh chiTiet_Lop_HocSinh = db.ChiTiet_Lop_HocSinhs.Find(id);
            db.ChiTiet_Lop_HocSinhs.Remove(chiTiet_Lop_HocSinh);
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
