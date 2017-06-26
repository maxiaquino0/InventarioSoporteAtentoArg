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
    public class InventaryObjectsController : Controller
    {
        private InventarioSoporteAtentoArgContext db = new InventarioSoporteAtentoArgContext();

        // GET: InventaryObjects
        public ActionResult Index()
        {
            var inventaryObjects = db.InventaryObjects.Include(i => i.ObjectType);
            return View(inventaryObjects.ToList());
        }

        // GET: InventaryObjects/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InventaryObject inventaryObject = db.InventaryObjects.Find(id);
            if (inventaryObject == null)
            {
                return HttpNotFound();
            }
            return View(inventaryObject);
        }

        // GET: InventaryObjects/Create
        public ActionResult Create()
        {
            var list = Common.GetObjectTypes();
            ViewBag.ObjectTypeID = new SelectList(list, "objectTypeID", "Description");
            return View();
        }

        // POST: InventaryObjects/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "InventaryObjectID,ObjectTypeID,EtiquetteAtento,SerialNumber,Model,Name,Observations,Extension,Owner,QuantityRam,QuantityHDD,ModelProcessor,SpeedProcessor")] InventaryObject inventaryObject)
        {
            if (ModelState.IsValid)
            {
                db.InventaryObjects.Add(inventaryObject);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            var list = Common.GetObjectTypes();
            ViewBag.ObjectTypeID = new SelectList(list, "objectTypeID", "Description", inventaryObject.ObjectTypeID);
            return View(inventaryObject);
        }

        // GET: InventaryObjects/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InventaryObject inventaryObject = db.InventaryObjects.Find(id);
            if (inventaryObject == null)
            {
                return HttpNotFound();
            }
            var list = Common.GetObjectTypes();
            ViewBag.ObjectTypeID = new SelectList(list, "objectTypeID", "Description", inventaryObject.ObjectTypeID);
            return View(inventaryObject);
        }

        // POST: InventaryObjects/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "InventaryObjectID,ObjectTypeID,EtiquetteAtento,SerialNumber,Model,Name,Observations,Extension,Owner,QuantityRam,QuantityHDD,ModelProcessor,SpeedProcessor")] InventaryObject inventaryObject)
        {
            if (ModelState.IsValid)
            {
                db.Entry(inventaryObject).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            var list = Common.GetObjectTypes();
            ViewBag.ObjectTypeID = new SelectList(db.ObjectTypes, "objectTypeID", "Description", inventaryObject.ObjectTypeID);
            return View(inventaryObject);
        }

        // GET: InventaryObjects/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            InventaryObject inventaryObject = db.InventaryObjects.Find(id);
            if (inventaryObject == null)
            {
                return HttpNotFound();
            }
            return View(inventaryObject);
        }

        // POST: InventaryObjects/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            InventaryObject inventaryObject = db.InventaryObjects.Find(id);
            db.InventaryObjects.Remove(inventaryObject);
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
