using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using InventarioSoporteAtentoArg.Models;

namespace InventarioSoporteAtentoArg.Controllers
{
    public class ObjectTypesController : Controller
    {
        private InventarioSoporteAtentoArgContext db = new InventarioSoporteAtentoArgContext();

        // GET: ObjectTypes
        public ActionResult Index()
        {
            return View(db.ObjectTypes.ToList());
        }

        // GET: ObjectTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ObjectType objectType = db.ObjectTypes.Find(id);
            if (objectType == null)
            {
                return HttpNotFound();
            }
            return View(objectType);
        }

        // GET: ObjectTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ObjectTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "objectTypeID,Description")] ObjectType objectType)
        {
            if (ModelState.IsValid)
            {
                db.ObjectTypes.Add(objectType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(objectType);
        }

        // GET: ObjectTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ObjectType objectType = db.ObjectTypes.Find(id);
            if (objectType == null)
            {
                return HttpNotFound();
            }
            return View(objectType);
        }

        // POST: ObjectTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "objectTypeID,Description")] ObjectType objectType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(objectType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(objectType);
        }

        // GET: ObjectTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ObjectType objectType = db.ObjectTypes.Find(id);
            if (objectType == null)
            {
                return HttpNotFound();
            }
            return View(objectType);
        }

        // POST: ObjectTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ObjectType objectType = db.ObjectTypes.Find(id);
            db.ObjectTypes.Remove(objectType);
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
